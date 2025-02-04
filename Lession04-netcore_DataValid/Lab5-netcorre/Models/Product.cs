using System.ComponentModel.DataAnnotations;

namespace Lab5_netcorre.Models
{
    public class Product
    {
        public int Id { get; set; }
        [MinLength(6)]
        [MaxLength(150)]

        public string Name { get; set; }
        public string Image {  get; set; }
        [Range(1000,double.MaxValue,ErrorMessage ="Giá cả phải lớn hơn 1000")]
        public decimal Price { get; set; }
        [Range(0,double.MaxValue,ErrorMessage ="Giá sale không được âm")]
        [Compare(nameof(Price), ErrorMessage = "SalePrice phải nhỏ hơn giá gốc ít nhất 10%.")]

        public float SalePrice {  get; set; }
        [StringLength(1500,ErrorMessage ="Chi tiết không được vượt quá 1500 ký tự")]
        
        public string Description { get; set; }
    }
}
