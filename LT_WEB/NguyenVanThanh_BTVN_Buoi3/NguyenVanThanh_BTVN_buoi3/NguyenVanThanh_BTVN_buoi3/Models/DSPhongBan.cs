namespace NguyenVanThanh_BTVN_buoi3.Models
{
    public class PhongBan
    {
        public string maphong { get; set; }
        public string tenphong { get; set; }
        public PhongBan(string maphong, string tenphong)
        {
            this.maphong = maphong;
            this.tenphong = tenphong;
        }
    }
}
