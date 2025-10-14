using System.ComponentModel.DataAnnotations;

namespace GitHubPractice.Models
{
    public class Membership
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        [Display(Name="Date Joined")]
        public DateTime JoinDate { get; set; } = DateTime.Now;
        [Display(Name="Currently Active")]
        public bool IsActive { get; set; } = true;

        [DataType(DataType.Date)]
        [Display(Name = "Birth Date")]
        public DateTime BirthDate { get; set; }
    }
}
