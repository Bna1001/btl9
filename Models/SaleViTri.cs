using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace btlnhom09.Models
{
    public class SaleViTri
    {
        [Key]
        public string ViTriSaleID { get; set; }
        public string VitriSale { get; set; }
    }
}