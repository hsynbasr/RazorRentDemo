using Microsoft.Build.Framework;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace RazorRentDemo.Model
{
    public class Reservation
    {
        public int Id { get; set; }//Db oluşturacak
        [System.ComponentModel.DataAnnotations.Required,StringLength(50),Display(Name ="Customer Name")]
        public string CustomerName { get; set; }//uı dan gelecek
        public DateTime Start { get; set; }//now
        public DateTime End { get; set; }//passs
        public int TotalPrice { get; set; }

        public Car Car { get; set; }//id
    }
}
