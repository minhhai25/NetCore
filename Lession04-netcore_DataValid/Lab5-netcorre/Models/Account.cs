using Microsoft.AspNetCore.Mvc;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Lab5_netcorre.Models
{
    public class Account
    {
        [Key] public int Id { get; set; }
        [Display (Name ="Họ và tên"),
         Required(ErrorMessage ="Họ và tên không được để trống"),
        MinLength(6,ErrorMessage ="Họ tên phải ít nhất 6 ký tự "),
        MaxLength(20,ErrorMessage ="Họ và tên có nhiều nhất 20 ký tự")
         ]
        public string FullName { get; set; }
        [
            Display(Name ="Địa chỉ Email"),
            Required(ErrorMessage ="Địa chỉ email không được để trống"),
            EmailAddress(ErrorMessage ="Địa chỉ email không đúng định dạng")
            ]
        public string Email {  get; set; }
        [DisplayName("Số điện thoại")]
        [Required(ErrorMessage = "Phone không được để trống")]
        //[RegularExpression(@"^0\d{9,12$}", ErrorMessage = "ký tự đầu bắt buộc phải bằng 0 và dài 10-12 chữ số")]
        [Remote(action:"VerifyPhone",controller:"Account")]
        public string Phone {  get; set; }
        [DisplayName("Địa chỉ thường trú")]
        [Required(ErrorMessage = "Địa chỉ không được để trống ")]
        [StringLength(35,ErrorMessage ="không được vượt quá 35 ký tự")]
        public string Address {  get; set; }
        [Display(Name ="Avatar")]
        public string Avatar { get; set; }
        [Display(Name ="Ngày sinh ")]
        [Required(ErrorMessage = "Ngày sinh không được để trống ")]
        [DataType(DataType.Date)]
        public DateTime Birthday { get; set; }
        [Display(Name ="Giới tính")]
        public string Gender { get; set; }
        [Display(Name ="Mật khẩu")]
        [DataType(DataType.Password)]

        public string Password {  get; set; }
        [Display(Name = "Link fabook cá nhân")]
        [Required(ErrorMessage ="Link facebook không được để trống")]
        public string Facebook {  get; set; }

    }
}
