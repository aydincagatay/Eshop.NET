using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ecom.Models
{
    public class Register
    {
        [Required]
        [DisplayName("Adınız")]
        public string Name { get; set; }
        [Required]
        [DisplayName("Soy adınız")] 
        public string Surname { get; set; }
        [Required]
        [DisplayName("Kullanıcı adınız")] 
        public string Username { get; set; }
        [Required]
        [DisplayName("Email")]
        [EmailAddress(ErrorMessage ="Geçersiz email,..")]
        public string Email { get; set; }
        [Required]
        [DisplayName("Şifre")]
        public string Password { get; set; }
        [Required]
        [DisplayName("Şifre tekrarı")]
        [Compare("Password",ErrorMessage ="Şifreler aynı değil") ]
        public string RePassword { get; set; }

    }
}