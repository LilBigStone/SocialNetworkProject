using System.Threading.Tasks;
using SocialNetworkProject.Models;

namespace SocialNetworkProject.Services
{
    public interface IUserService
    {
        Task RegisterAsync(User user, string password);
        Task<User> AuthenticateAsync(string username, string password);
    }
}
