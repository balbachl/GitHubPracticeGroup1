using System.ComponentModel.DataAnnotations;

namespace GitHubPractice.Models
{
    public class Membership
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public DateTime JoinDate { get; set; } = DateTime.Now;
        public bool IsActive { get; set; } = true;

        [DataType(DataType.Date)]
        [Display(Name = "Birth Date")]
        public DateTime BirthDate { get; set; }
    }
}
