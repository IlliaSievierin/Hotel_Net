using System;
using System.Collections.Generic;
using System.Text;

namespace Hotel.DAL.Entities
{
    public class Room
    {
        public int Id { get; set; }

        public string RoomNumber { get; set; }

        public int CategoryId { get; set; }

        public bool Active { get; set; }

        public virtual Category Category { get; set; }

        public virtual ICollection<Reservation> Reservation { get; set; }
    }
}
