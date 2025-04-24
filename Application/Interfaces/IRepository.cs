using OWF.API.Domain.Interfaces;

namespace OWF.API.Application.Interfaces;

public interface IRepository<T> where T : class, IBaseModel
{
    public Task<IResult<List<T>>> GetAllAsync();
    public Task<IResult<T>> GetByIdAsync(long id);
    public Task<IResult<T>> CreateAsync(T entity);
    public Task<IResult<T>> UpdateAsync(T entity);
    public Task<IResult> DeleteAsync(long id);
}