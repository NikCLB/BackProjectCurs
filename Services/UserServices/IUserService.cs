using BackProjectCurs.Entity;

namespace BackProjectCurs.Services.UserServices
{
    public interface IUserService
    {
        Task<bool> AddUsers(User user);

   
    }
}
