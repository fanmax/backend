﻿using ShareBook.Domain.Common;
using ShareBook.Domain.Enums;

namespace ShareBook.Domain
{
    public class User : BaseEntity
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string PasswordSalt { get; set; }
        public string Linkedin { get; set; }
        public string Cep { get; set; }
        public Profile Profile { get;  set; } = Profile.User;
       
    }
}
