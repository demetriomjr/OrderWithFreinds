using OWF.API.Domain.Users;

namespace OWF.API.Application.Interfaces;

public interface IUserRepository : IRepository<User>
{
    public Task<IResult<User>> GetByUsernameAsync(string username);
    public Task<IResult<bool>> ComparePasswordAsync(User user, string password);
}