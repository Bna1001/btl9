using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace btlnhom09.Models
{
    public class CeoViTri
    {
        [Key]
        public string ViTriCeoID { get; set; }
        public string VitriCeo { get; set; }
    }
}