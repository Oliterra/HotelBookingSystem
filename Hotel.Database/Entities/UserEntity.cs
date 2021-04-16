using System.Collections.Generic;

namespace Hotel.Database.Entities
{
    public class UserEntity
    {
        public int Id { get; set; }

        public string Firstname { get; set; }

        public string Lastname { get; set; }

        public string Middlename { get; set; }

        public string Email { get; set; }

        public long Phone { get; set; }

        public virtual ICollection<BookingAssignedUserEntity> BookingAssignedUserPerson { get; set; }
    }
}
