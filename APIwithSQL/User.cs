using System.ComponentModel.DataAnnotations;

namespace APIwithSQL
{
    public class User
    {
        public int Id { get; set; }


        [Display(Name = "User ID")]
        public string UserID { get; set; }= string.Empty ;


        [Display(Name = "First Name")]
        public string FirstName { get; set; } = string.Empty;


        [Display(Name = "Last Name")]
        public string LastName { get; set; } = string.Empty;


        [Display(Name = "Job Position")]
        public string JobPosition { get; set; } = string.Empty;


        public string Email { get; set; } = string.Empty;


        [Display(Name = "User Role")]
        public string UserRole { get; set; } = string.Empty!;

    }
}
