using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MoroDrumsWeb.Persistence;

namespace MoroDrumsWeb.Controllers{
    [Route("api/courses")]
    public class CourseController : Controller{
        private readonly MoroDrumsContext _context;

        public CourseController(MoroDrumsContext context){
            _context = context;
        }
        
        // GET api/courses
        [HttpGet]
        public async Task<IActionResult> GetCourses(){
            var courses = await _context.Courses
                .Include(c => c.Videos)
                .ToListAsync();

            if (courses == null)
                return NotFound();
            
            return Ok(courses);
        }

        // GET api/courses/id
        [HttpGet("{id}")]
        public async Task<IActionResult> GetCourse(int id){
            var course = await _context.Courses
                .Include(c => c.Videos)
                .FirstOrDefaultAsync(c => c.Id == id);

            if (course == null)
                return NotFound();

            return Ok(course);
        }
    }
}