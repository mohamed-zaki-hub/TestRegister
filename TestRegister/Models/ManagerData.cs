using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TestRegister.Models
{
    public class ManagerData
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Email2 { get; set; }
        public string Phone { get; set; }
        public string Phone2 { get; set; }
        
        public byte[] NationalId { get; set; }
        public byte[] NationalId2 { get; set; }
        
        
    }
}
