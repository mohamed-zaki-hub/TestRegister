using System.ComponentModel.DataAnnotations;

namespace TestRegister.Models
{
    public class Facility

    {
        public int Id { get; set; }
        [Required]
        public string Accessibility { get; set; }
        [Required]
        public string Bedroom { get; set; }
        public string FrontDeskServices { get; set; }
        
        public string LivingArea { get; set; }
        public string Parking { get; set; }
        public string Transportation { get; set; }
        public string Building { get; set; }
        public string Cleaning { get; set; }
        public string RoomAmenities { get; set; }
        public string Media { get; set; }
        public string Safty { get; set; }
        public string Bathroom { get; set; }
        public string Food { get; set; }
        public string Language { get; set; }
        public string Kitchen { get; set; } 


    }
}
