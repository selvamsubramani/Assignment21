using System.ComponentModel.DataAnnotations;

namespace FSE.Assignment21.MVCClient.Models
{
    public class Job
    {
        [Display(Name = "Job Id")]
        public int Id { get; set; }
        [Display(Name = "Job Role")]
        public string Role { get; set; }
        [Display(Name = "Job Description")]
        public string Description { get; set; }
        [Display(Name = "Experience")]
        public string Experience { get; set; }
        [Display(Name = "Location")]
        public string Venue { get; set; }
    }
}