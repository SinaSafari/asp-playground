using System.Threading.Tasks;
using dnc.Models;

namespace dnc.Data
{
    public interface IAuthRepository
    {
        Task<ServiceResponse<string>> Register(User user, string password);
        Task<ServiceResponse<string>> Login(string username, string password);
        Task<bool> UserExists(string username);
    }
}