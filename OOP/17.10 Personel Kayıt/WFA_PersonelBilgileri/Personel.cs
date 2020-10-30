using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFA_PersonelBilgileri
{
   public class Personel
    {
        public int Id { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string TcKimlikNo { get; set; }
        public DateTime DogumTarihi { get; set; }
        public string TelefonNo { get; set; }
        public string Email { get; set; }
        public string Adres { get; set; }
        public DateTime IseGirisTarih { get; set; }
        public Unvan Unvan { get; set; }
        public string Fotograf { get; set; }
    }
}
