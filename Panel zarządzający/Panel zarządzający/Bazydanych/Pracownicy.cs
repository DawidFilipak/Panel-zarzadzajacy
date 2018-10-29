using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Linq.Mapping;

namespace Panel_zarządzający.Bazydanych
{
    [Table(Name="Pracownicy")]
   public class Pracownicy
    {
        [Column(Name = "Imie")]
        public string Imie;
        public string Nazwisko;
        public string Adres;
        public string Email;
        public string Login;
        public string Password;
    }
    
}
