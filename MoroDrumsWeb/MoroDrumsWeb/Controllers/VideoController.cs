using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MoroDrumsWeb.Persistence;

namespace MoroDrumsWeb.Controllers{
    [Route("/api/videos")]
    public class VideoController : Controller{
        private readonly MoroDrumsContext _context;

        public VideoController(MoroDrumsContext context){
            _context = context;
        }
        
        // GET api/videos
        [HttpGet]
        public async Task<IActionResult> GetVideos(){
            var videos = await _context.Videos.ToListAsync();

            if (videos == null)
                return NotFound();
            
            return Ok(videos);
        }

        // GET api/videos/{id}
        [HttpGet("{id}")]
        public async Task<IActionResult> GetVideo(int id){
            var video = await _context.Videos.FindAsync(id);

            if (video == null)
                return NotFound();

            return Ok(video);
        }
    }
}