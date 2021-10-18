using System;
using System.Collections.Generic;
using System.Text;

namespace Hotel.DAL.Entities
{
    public class Customer
    {
        public int Id { get; set; }

        public string LastName { get; set; }

        public string FirstName { get; set; }

        public string MiddleName { get; set; }

        public DateTime DateOfBirth { get; set; }

        public string Passport { get; set; }

        public virtual ICollection<Reservation> Reservation { get; set; }
    }
}
