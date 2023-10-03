using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BTL06.Models
{
    [Table("Kho")]
    public class Kho
    {
        [Key]
        public string KhoID {get; set; }
        public string SanPhamName {get; set; }
        [ForeignKey("SanPhamName")]
        public SanPham? SanPham {get; set;}
        public string NumberKho {get; set; }
        public string KhoStoreExists{get; set; }
        public string ExportKho {get; set; }
        
     
    }
}  