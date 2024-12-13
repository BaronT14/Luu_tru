ALTER TABLE HOADON
ADD CONSTRAINT DF_HOADON_DATRA DEFAULT 0 FOR DATRA;
GO


ALTER TABLE KHACHHANG
	ADD CONSTRAINT Uni_SDT UNIQUE (SDT);
GO

------------------trigger--------------
CREATE TRIGGER trg_UpdateTongTienHoaDon
ON CTHD
AFTER INSERT, UPDATE, DELETE
AS
BEGIN
    SET NOCOUNT ON;

    -- Lấy danh sách các MaHD bị ảnh hưởng
    DECLARE @affectedMaHD TABLE (MaHD VARCHAR(10));

    -- Lưu các MaHD từ INSERTED
    INSERT INTO @affectedMaHD (MaHD)
    SELECT DISTINCT MaHD FROM Inserted;

    -- Lưu các MaHD từ DELETED
    INSERT INTO @affectedMaHD (MaHD)
    SELECT DISTINCT MaHD FROM Deleted;

    -- Cập nhật TongTien cho từng MaHD bị ảnh hưởng
    UPDATE HoaDon
    SET TongTien = (
        -- Tổng từ CTHD
        SELECT ISNULL(SUM(ThanhTien), 0)
        FROM CTHD
        WHERE CTHD.MaHD = HoaDon.MaHD
    ) + (
        -- Tổng từ CTDV
        SELECT ISNULL(SUM(DICHVU.GIADV * CTDV.SOLUONG), 0)
        FROM CTDV
        JOIN DICHVU ON CTDV.MADV = DICHVU.MADV
        WHERE CTDV.MaHD = HoaDon.MaHD
    )
    WHERE MaHD IN (SELECT DISTINCT MaHD FROM @affectedMaHD);
END;


go


CREATE TRIGGER trg_UpdateTongTienHoaDon_CTDV
ON CTDV
AFTER INSERT, UPDATE, DELETE
AS
BEGIN
    SET NOCOUNT ON;

    -- Lấy danh sách các MaHD bị ảnh hưởng
    DECLARE @affectedMaHD TABLE (MaHD VARCHAR(10));

    -- Lưu các MaHD từ INSERTED
    INSERT INTO @affectedMaHD (MaHD)
    SELECT DISTINCT MaHD FROM Inserted;

    -- Lưu các MaHD từ DELETED
    INSERT INTO @affectedMaHD (MaHD)
    SELECT DISTINCT MaHD FROM Deleted;

    -- Cập nhật TongTien cho từng MaHD bị ảnh hưởng
    UPDATE HoaDon
    SET TongTien = (
        -- Tổng từ CTHD
        SELECT ISNULL(SUM(ThanhTien), 0)
        FROM CTHD
        WHERE CTHD.MaHD = HoaDon.MaHD
    ) + (
        -- Tổng từ CTDV
        SELECT ISNULL(SUM(DICHVU.GIADV * CTDV.SOLUONG), 0)
        FROM CTDV
        JOIN DICHVU ON CTDV.MADV = DICHVU.MADV
        WHERE CTDV.MaHD = HoaDon.MaHD
    )
    WHERE MaHD IN (SELECT DISTINCT MaHD FROM @affectedMaHD);
END;



go



CREATE TRIGGER trg_DeleteHoaDonWhenNoCTHD
ON CTHD
AFTER DELETE
AS
BEGIN
    SET NOCOUNT ON;

    -- Xóa hóa đơn nếu không còn chi tiết hóa đơn nào liên quan
    DELETE FROM HoaDon
    WHERE MaHD IN (
        SELECT d.MaHD
        FROM Deleted d
        WHERE NOT EXISTS (
            SELECT 1
            FROM CTHD
            WHERE CTHD.MaHD = d.MaHD
        )
    );
END;


CREATE TRIGGER trg_CheckTangPhong
ON Phong
AFTER INSERT
AS
BEGIN
    SET NOCOUNT ON;
	DECLARE @TANG int = (SELECT TANG FROM KHACHSAN)
    -- Kiểm tra điều kiện: Tang của phòng không được lớn hơn Tang của khách sạn
    IF EXISTS (
        SELECT 1
        FROM Inserted I
        WHERE I.Tang > @TANG
    )
    BEGIN
        -- Nếu điều kiện vi phạm, huỷ bỏ thao tác thêm phòng
        RAISERROR ('Số tầng của phòng không được lớn hơn số tầng của khách sạn!', 16, 1);
        ROLLBACK TRANSACTION;
    END
END;
GO


