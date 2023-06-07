namespace BlazorAspNetCoreHostedDemo.Shared
{
    public class UserSession
    {
        public string UserName { get; set;}
        public string Token { get; set;}
        public string Role { get; set; }
        public int ExpiresIn { get; set; }
        public DateTime ExpiryTimeStamp { get; set; }

        //additional info
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Gender { get; set; }
        public string ContactNo { get; set; }
        public string Country { get; set; }

    }
}
