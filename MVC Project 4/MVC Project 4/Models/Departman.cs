using System;
using System.ComponentModel.DataAnnotations;

namespace MVC_Project_4.Models
{
    public class Departman
    {
        [Key]
        public int DepartmanID { get; set; }
        public string DepartmanAd { get; set; }
        public List<Personel> PersonelList { get; set; }
    }
}
