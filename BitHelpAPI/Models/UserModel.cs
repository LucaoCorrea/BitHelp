﻿using BitHelpAPI.Enum;

namespace BitHelpAPI.Models
{
    public class UserModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public UserRole Role { get; set; } 
        public DateTime CreatedAt { get; set; }
    }
}
