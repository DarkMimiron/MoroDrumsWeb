using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace MoroDrumsWeb.Models{
    public class Course{
        public int Id{ get; set; }
        public string Name{ get; set; }
        public string Description{ get; set; }
        public string CourseURL{ get; set; }
        public ICollection<Video> Videos{ get; set; }

        public Course(){
            Videos = new Collection<Video>();
        }
    }
}