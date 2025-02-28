using System.ComponentModel.DataAnnotations;

namespace Lession7NETCORE.Models
{
    public class Login
    {
        [Required(ErrorMessage ="Tên đăng nhập không thể trống")]
        [Display(Name ="Tên đăng nhập")]
        public string UserName { get; set; }
        [Required(ErrorMessage = "mật khẩu không thể trống")]
        [Display(Name = "mật khẩu")]
        public string Password { get; set; }
        public bool Remember { get; set; }
    }
}
