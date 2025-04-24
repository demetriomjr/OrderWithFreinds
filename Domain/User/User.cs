using OWF.API.Domain.Interfaces;

namespace OWF.API.Domain.User;

public class User : IBaseModel, ICloneable
{
    public long Id { get; set; } = DateTimeOffset.UtcNow.ToUnixTimeMilliseconds();

    public string Name { get; set; } = null!;
    public string Username { get; set; } = null!;
    public byte[] Password { get; set; } = [];
    
    public IBaseModel.ModelState State { get; set; }
    public DateTimeOffset CreatedAt { get; init; }
    public DateTimeOffset UpdatedAt { get; set; }
    public DateTimeOffset DeletedAt { get; set; }
    
    public object Clone()
    {
        return MemberwiseClone();
    }
}