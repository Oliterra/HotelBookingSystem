using System;
using System.Collections.Generic;

namespace Business.Models
{
    public class UserModel
    {
        public Guid Id { get; set; }

        public string Firstname { get; set; }

        public string Lastname { get; set; }

        public string Middlename { get; set; }

        public string Email { get; set; }

        public long Phone { get; set; }

        public ICollection<BookingAssignedUserModel> BookingAssignedUserPerson { get; set; }
    }
}
