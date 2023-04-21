using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace touristProject.Entities.DTOs.Users
{
    public class UserForLoginDto
    {
        //Sisteme giriş yapmak için oluşturulmuş DTo nesnesidir.

        public string Email { get; set; }
        public string Password { get; set; }
    }
}
