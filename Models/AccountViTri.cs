using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace btlnhom09.Models
{
    public class AccountViTri
    {
        [Key]
        public string ViTriAccountID { get; set; }
        public string VitriAccount { get; set; }
    }
}