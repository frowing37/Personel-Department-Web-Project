using System;
using System.ComponentModel.DataAnnotations;

namespace MVC_Project_4.Models
{
    public class Personel
    {
        [Key]
        public int PersonelID { get; set; }
        public string PersonelAd { get; set; }
        public string PersonelSoyad { get; set; }
        public string PersonelSehir { get; set; }
        
        public Departman DepartmanId { get; set; }
    }
}
