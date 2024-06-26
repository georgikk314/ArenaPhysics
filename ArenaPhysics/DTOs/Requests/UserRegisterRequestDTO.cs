﻿using System.ComponentModel.DataAnnotations;

namespace ArenaPhysics.DTOs.Requests
{
    public class UserRegisterRequestDTO
    {
        [MinLength(3)]
        [MaxLength(100)]
        public string Username { get; set; }
        [MinLength(6)]
        public string Password { get; set; }
        [EmailAddress]
        public string Email { get; set; }
        [MaxLength(250)]
        public string FirstName { get; set; }
        [MaxLength(250)]
        public string LastName { get; set; }
        public int Age { get; set; }
        public DateTime DateOfCreation { get; set; }
        
    }
}
