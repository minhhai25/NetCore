using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Lession04_netcore_DataValid.Models
{
    public class Member
    {
        public string MemberId {  get; set; }
        [DisplayName("Tên")]
        [Required(ErrorMessage ="UserName không được đẻ trống")]
        [StringLength(20,MinimumLength = 2,ErrorMessage ="UserName trong khoảng 3 đến 20 ký tự")]
        public string UserName { get; set; }
        [DisplayName("Họ và tên")]
        [Required(ErrorMessage = "FullName không được đẻ trống")]
        [StringLength(20, MinimumLength = 2, ErrorMessage = "FullName trong khoảng 3 đến 20 ký tự")]
        public string FullName { get; set; }
        [DisplayName("Password")]
        [Required(ErrorMessage = "Password không được để trống")]
        //kiểu dữ liệu email
        [DataType(DataType.Password)]
        public string Password {  get; set; }
        [DisplayName("Email")]
        [Required(ErrorMessage = "Email không được để trống")]
        //kiểu dữ liệu email
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [DisplayName("Phone")]
        [Required(ErrorMessage = "Phone không được để trống")]
        [RegularExpression(@"^0\d{9,12$}",ErrorMessage ="ký tự đầu bắt buộc phải bằng 0 và dài 10-12 chữ số")]
        [DataType(DataType.PhoneNumber)]
        public string Phone { get; set; }
        public DateTime Birthday { get; set; }
    }
}
