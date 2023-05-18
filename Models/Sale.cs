using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace btlnhom09.Models
{
    public class Sale
    {
        [Key]
        [Required(ErrorMessage ="ID không được bỏ trống")]
        public string SaleID{ get; set; }
        [Required(ErrorMessage ="Họ Và Tên không được bỏ trống")]
        [Display(Name = "Họ và tên")]
        public string SaleName { get; set; }
        [Required(ErrorMessage =" SĐT Không được bỏ trống")]
        [Display(Name = "SĐT")]
        public string SalePhoneNumber{ get; set; }
        [Required(ErrorMessage =" Địa chỉ Không được bỏ trống")]
        [Display(Name = "Địa chỉ")]
        public string SaleAddress{ get; set; }
        [Display(Name = "Ngày Sinh")]
        public string SaleBirth{ get; set; }
        [Display(Name = "Giới tính")]
        public string SaleSex{ get; set; }
        [Required(ErrorMessage =" Tài khoản Ngân hàng Không được bỏ trống")]
        [Display(Name = "TK Ngân hàng BIDV")]
        public string SaleBank{ get; set; }
        [Required(ErrorMessage =" Số Căn Cước Không được bỏ trống")]
        [Display(Name ="Số Căn Cước")]
        public string SaleCCCD { get; set; }
        [Display(Name = "Vị Trí")]
        public string ViTriSaleID { get; set; }
        [ForeignKey("ViTriSaleID")]
        public SaleViTri? SaleViTri { get; set; }
        [Display(Name = "Lương")]
        public string LuongID { get; set; }
        [ForeignKey("LuongID")]
        public Luong? Luong { get; set; }
        [Display(Name = "Hợp đồng")]
        public string HopDongID { get; set; }
        [ForeignKey("HopDongID")]
        public HopDong? HopDong { get; set; }
        [Display(Name = "Ngày làm")]
        public string SaleStart{ get; set; }
        [Display(Name = "Ngày hết hợp đồng")]
        public string SaleEnd{ get; set; }
    }
}