using System;
using System.Collections.Generic;
using System.Text;

namespace biletix3.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

        public string Isim { get; set; }
        public string Soyisim { get; set; }
        public string Telno { get; set; }
        public int Cinsiyet { get; set; }
        public string Dogum { get; set; }


    }
}
