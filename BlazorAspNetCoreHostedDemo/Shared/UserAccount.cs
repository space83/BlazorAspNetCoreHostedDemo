using System.ComponentModel.DataAnnotations;

namespace BlazorAspNetCoreHostedDemo.Shared
{
    public class UserAccount
    {
        public int Id { get; set; }

        [StringLength(10)]
        public string UserName { get; set;}

        [StringLength(20)]
        public string Password { get; set;}

        [StringLength(15)]
        public string Role { get; set;}

        [StringLength(30)]
        public string FirstName { get; set; }

        [StringLength(30)]
        public string LastName { get; set; }

        [StringLength(30)]
        public string Email { get; set; }

        [StringLength(5)]
        public string Gender { get; set; }

        [StringLength(10)]
        public string ContactNo { get; set; }

        [StringLength(25)]
        public string Country { get; set; }

    }
}