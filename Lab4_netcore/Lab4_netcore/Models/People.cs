﻿using System.ComponentModel.DataAnnotations;
namespace Lab4_netcore.Models
{
    public class People
    {
        public int Id { get; set; }
        [Display(Name ="Họ và tên")]
        public string Name { get; set; }
        [Display(Name = "Email")]
        public string Email {  get; set; }
        [Display(Name = "Số điện thoại")]
        public string Phone { get; set; }
        [Display(Name = "Địa chỉ")]
        public string Address {  get; set; }
        [Display(Name = "Avatar")]
        public string Avatar { get; set; }
        [Display(Name = "Ngày sinh")]
        public DateTime Birthday { get; set; }
        [Display(Name = "Bio")]
        public string Bio {  get; set; }
        [Display(Name = "Giới tính")]
        public byte Gender { get; set; }
    }
}
