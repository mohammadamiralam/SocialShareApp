using System.Threading.Tasks;
using SocialShareApp.API.Models;

namespace SocialShareApp.API.Data
{
    public interface IAuthRepository
    {
        Task<User> Register(User user, string password);
        Task<User> Login(string username, string password);
        Task<bool> UserExists(string username);
    }
}