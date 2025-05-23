﻿using OWF.API.Domain.Interfaces;

namespace OWF.API.Domain.Users;

public class User : IBaseModel, ICloneable
{
    public long Id { get; init; } = DateTimeOffset.UtcNow.ToUnixTimeMilliseconds();

    public string Name { get; set; } = null!;
    public string Username { get; set; } = null!;
    public byte[] Password { get; set; } = [];

    public IBaseModel.ModelState State { get; set; } = IBaseModel.ModelState.ACTIVE;
    public DateTimeOffset CreatedAt { get; init; }
    public DateTimeOffset UpdatedAt { get; set; }
    public DateTimeOffset DeletedAt { get; set; }

    public object Clone()
    {
        return MemberwiseClone();
    }
}