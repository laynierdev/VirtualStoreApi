﻿namespace VirtualStoreApi.Models;

public class User
{
    public int Id { get; set; }
    public string Auth0Id { get; set; }
    public string? Address { get; set; }
    public string? Phone { get; set; }
    
}
