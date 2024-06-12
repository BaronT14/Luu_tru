-- nguyen van thanh
INSERT INTO KHOA VALUES 
('TC', N'Tài chính kế toán'),
('SH', N'Công nghệ sinh học'),
('QT', N'Quản trị kinh doan'),
('TH', N'Công nghệ thông tin'),
('TP', N'Công nghệ thực phẩm')
select * from SINHVIEN

INSERT INTO LOP(MALOP, TENLOP, SISO, MAKH) VALUES
('10DHSH1', N'10 Đại học sinh học 1', 55, 'SH'),
('10DHTH1', N'10 Đại học tin học 1', 50, 'TH'),
('12DHTC1', N'10 Đại học tài chính 1', 75, 'TC')


INSERT INTO SINHVIEN VALUES
('SV004', N'Nguyễn Văn A', 21-01-1995, N'Nam', N'Đồng Nai', '10DHSH1'),
('SV001', N'Trần Lệ Quyên', 21-01-1995, N'Nữ', N'TPHCM', '10DHTH1'),
('SV002', N'Nguyễn Thế Bình', 21-01-1995, N'Nam', N'Tây Ninh', '12DHTC1'),
('SV003', N'Tố Ánh Nguyệt', 21-01-1995, N'Nữ', N'Vũng Tàu', '10DHSH1')

UPDATE LOP
SET LOPTRUONG = 'SV001'
Where MALOP = '10DHTH1'

UPDATE LOP
SET LOPTRUONG = 'SV002'
Where MALOP = '12DHTC1'

UPDATE LOP
SET LOPTRUONG = 'SV003'
Where MALOP = '10DHSH1'

INSERT INTO GIANGVIEN VALUES
('GV001', N'Phạm Thế Bảo', 'TH'),
('GV002', N'Lê Thể Truyền', 'TH'),
('GV003', N'Trương Anh Dũng', 'SH')

INSERT INTO MONHOC VALUES
('CSDL', N'Cơ sở dữ liệu', 3),
('TRR', N'Toán rời rạc', 3),
('TTQT', N'Thanh toán quốc tế', 2)

INSERT INTO DIEM VALUES
('SV001', 'CSDL', 1, 9),
('SV002', 'TRR', 1, 6),
('SV002', 'TRR', 2, 8),
('SV003', 'TTQT', 1, 7)

INSERT INTO GIANGDAY VALUES
('GV001', 'CSDL', '2021-2022', 1),
('GV001', 'TRR', '2020-2021', 2),
('GV002', 'TTQT', '2021-2022', 1),
('GV003', 'TRR', '2021-2022', 2)

INSERT INTO THANNHAN VALUES
('TN001', N'Nguyễn Thế Thành', N'Nam'),
('TN002', N'Tô Ánh Hồng', N'Nữ'),
('TN003', N'Lê Thanh An', N'Nam')


INSERT INTO QUANHE VALUES
('TN001', 'SV001', N'Bố'),
('TN002', 'SV002', N'Mẹ'),
('TN003', 'SV003', N'Bố')