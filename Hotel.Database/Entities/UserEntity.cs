using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Identity;

namespace Database.Entities
{
    public class UserEntity : IdentityUser 
    {
        public Guid Id { get; set; }

        public string Firstname { get; set; }

        public string Lastname { get; set; }

        public string Middlename { get; set; }

        public string Email { get; set; }

        public long Phone { get; set; }

        public ICollection<BookingAssignedUserEntity> BookingAssignedUserPerson { get; set; }
    }
}
