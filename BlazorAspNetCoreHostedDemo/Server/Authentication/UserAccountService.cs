using BlazorAspNetCoreHostedDemo.Server.Data;
using BlazorAspNetCoreHostedDemo.Shared;
using Microsoft.AspNetCore.Mvc;

namespace BlazorAspNetCoreHostedDemo.Server.Authentication
{
    public class UserAccountService
    {
        private readonly DataContext _context;


        public UserAccountService(DataContext context)
        {
            _context = context;
        }

        public UserAccount? GetUserAccountByUserName(string userName)
        {
            return _context.UserAccount.FirstOrDefault(x => x.UserName == userName);
        }

        public List<UserAccount> GetUsers()
        {
            return _context.UserAccount.ToList();
        }

        public UserAccount? GetUser(int userId)
        {
            return _context.UserAccount.FirstOrDefault(x => x.Id == userId);
        }

        public void AddUser(UserAccount user)
        {
            _context.UserAccount.Add(user);
            _context.SaveChanges();
        }


    }
}
