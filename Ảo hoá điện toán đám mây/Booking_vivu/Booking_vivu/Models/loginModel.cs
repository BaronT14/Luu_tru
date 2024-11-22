using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Booking_vivu.Models
{
    public class loginModel
    {
        [Required(ErrorMessage = "Vui lòng nhập số điện thoại")]
        public string PhoneNumber { get; set; }

        [Required(ErrorMessage = "Vui lòng nhập mật khẩu")]
        public string Password { get; set; }

        public loginModel(string Phone, string pass)
        {
            this.PhoneNumber = Phone;
            this.Password = pass;
        }
    }
}