using ApiSinhVien.Data;
using ApiSinhVien.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ApiSinhVien.Controllers
{
    // Controllers/StudentController.cs
    [ApiController]
    [Route("api/[controller]")]
    public class StudentController : ControllerBase
    {
        private readonly StudentContext _context;

        public StudentController(StudentContext context)
        {
            _context = context;
        }

        [HttpGet("{uid}")]
        public async Task<ActionResult<Student>> GetByUid(string uid)
        {
            var student = await _context.Students.FirstOrDefaultAsync(s => s.Uid == uid);
            if (student == null)
                return NotFound();
            return student;
        }
    }

}
