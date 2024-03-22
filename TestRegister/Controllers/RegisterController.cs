using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Identity.Client;
using System.ComponentModel.DataAnnotations;
using TestRegister.Data;
using TestRegister.Dots;
using TestRegister.Models;

namespace TestRegister.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RegisterController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        private readonly IWebHostEnvironment _enviroment;
        
        public RegisterController(ApplicationDbContext context, IWebHostEnvironment enviroment)
        {
            _context = context;
            _enviroment = enviroment;
        }
        [HttpPost("ManagerData")]
        public async Task<IActionResult> CreateMangerData([FromForm]MDdots dto)
        {
            using var datastream = new MemoryStream();
            using var datastream2 = new MemoryStream();
            await dto.NationalId.CopyToAsync(datastream);
            await dto.NationalId2.CopyToAsync(datastream2);
            var managerdata = new ManagerData {
                Name = dto.Name,
                Email = dto.Email,
                Email2 = dto.Email2,
                Phone = dto.Phone,
                Phone2 = dto.Phone2,
                NationalId = datastream.ToArray(),
                NationalId2 = datastream2.ToArray(),
            }; 
            await _context.AddAsync(managerdata);
            _context.SaveChanges();
            return Ok();
        }
        [HttpPost("Facilities")]
        public async Task<IActionResult> CreateFacilities([FromForm] Facility fac)
        {
          await _context.AddAsync(fac);
            _context.SaveChanges();
            return Ok(fac);

        }
        [HttpPost("AddEmployees")]
        public async Task<IActionResult> CreateEmployees([FromForm] EmpDots dto)
        {
            using var datastream = new MemoryStream();
            
            await dto.Photo.CopyToAsync(datastream);
            
            var employee = new Employee
            {
                Name = dto.Name,
                E_mail = dto.E_mail,
                Phone = dto.Phone,
                Photo = datastream.ToArray(),
                
            };
            await _context.AddAsync(employee);
            _context.SaveChanges();
            return Ok();

        }
        
        [HttpPost("Awards")]
        public async Task<IActionResult> CreateAward([FromForm] AwardDots dto)
        {
            using var datastream = new MemoryStream();
            using var datastream2 = new MemoryStream();
            await dto.AwardPhoto1.CopyToAsync(datastream);
            await dto.AwardPhoto2.CopyToAsync(datastream2);
            var award = new Award
            {
                AwardProvider = dto.AwardProvider,
                AwardPhoto1 =datastream.ToArray() ,
                AwardPhoto2 =datastream2.ToArray() ,
                

            };
            await _context.AddAsync(award);
            _context.SaveChanges();
            return Ok();

        }
        [HttpPost("Attractions")]
        public async Task<IActionResult> CreateAttraction([FromForm] AttractionDtos dto)
        {
            using var datastream = new MemoryStream();
            await dto.PhotoPlace.CopyToAsync(datastream);
            var attraction = new Attraction
            {
                Title = dto.Title,
                Distance = dto.Distance,
                Description = dto.Description,
                PhotoPlace = datastream.ToArray(),


            };
            await _context.AddAsync(attraction);
            _context.SaveChanges();
            return Ok();

        }
    }
}
