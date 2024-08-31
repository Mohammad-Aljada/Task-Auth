using System.ComponentModel.DataAnnotations;

namespace Task_Auth.Models
{
    public class User
    {
        [Key]
        [Display(Name ="UserId")]
        public Guid UserId { get; set; }

        [Display(Name = "UserName")]

        public string? UserName { get; set; }

        [Display(Name = "Password")]

        [DataType(DataType.Password)]

        public string? Password { get; set; }
        [Display(Name = "CreatedAt")]

        public DateTime? CreatedAt { get; set; }
        [Display(Name = "isActive")]

        public bool isActive { get; set; }
    }
}
