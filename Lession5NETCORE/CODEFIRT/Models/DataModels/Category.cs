using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace CODEFIRT.Models.DataModels
{
    
    [Table("Categories")]
    public class Category
    {
        [DisplayName("Mã loại")]
        public int CategoryId { get; set; }

        [DisplayName("Tên loại")]
        [StringLength(100)]
        public string CategoryName { get; set; }

        // Thuộc tính quan hệ
        public ICollection<Book> Books { get; set; }
    }

}
