namespace MoroDrumsWeb.Models{
    public class Video{
        public int Id{ get; set; }
        public string Name{ get; set; }
        public string Description{ get; set; }
        public string VideoUrl{ get; set; }
        public int CourseId{ get; set; }
        public Course Course{ get; set; }
    }
}