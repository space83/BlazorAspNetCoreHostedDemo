using System.ComponentModel.DataAnnotations;

namespace BlazorAspNetCoreHostedDemo.Shared
{
    public class UserAccount
    {
        public int Id { get; set; }

        [StringLength(10)]
        [Required(ErrorMessage = "User Name is mandatory")]
        public string UserName { get; set;}

        [StringLength(20)]
        [Required(ErrorMessage = "Password is mandatory")]
        public string Password { get; set;}

        [StringLength(15)]
        [Required(ErrorMessage = "Role is mandatory")]
        public string Role { get; set;}

        [StringLength(30)]
        public string? FirstName { get; set; }

        [StringLength(30)]
        public string? LastName { get; set; }

        [StringLength(30)]
        [DataType(DataType.EmailAddress)]
        [RegularExpression(@"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$", ErrorMessage = "Please enter a valid e-mail adress")]
        public string? Email { get; set; }

        [StringLength(5)]
        public string? Gender { get; set; }

        [StringLength(10)]
        public string? ContactNo { get; set; }

        [StringLength(25)]
        public string? Country { get; set; }

    }

    public enum Role
    {
        Administrator,
        User
    }

    public enum Gender
    {
        Male,
        Female
    }

    public enum Country
    {
        Malaysia,
        Singapore,
        Indonesia,
        Thailand
    }


}