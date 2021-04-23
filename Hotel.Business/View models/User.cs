using System;

namespace Business.ViewModels
{
    public class User
    {
        public Guid Id { get; set; }

        public string Firstname { get; set; }

        public string Lastname { get; set; }

        public string Middlename { get; set; }

        public string Email { get; set; }

        public long Phone { get; set; }
    }
}
