namespace OWF.API.Domain.Interfaces;

public interface IBaseModel
{
    public enum ModelState
    {
        DELETED = -1,
        INACTIVE = 0,
        ACTIVE = 1,
    }
    
    public long Id { get; set; }
    public ModelState State { get; set; }
    public DateTimeOffset CreatedAt { get; init; }
    public DateTimeOffset UpdatedAt { get; set; }
    public DateTimeOffset DeletedAt { get; set; }
}