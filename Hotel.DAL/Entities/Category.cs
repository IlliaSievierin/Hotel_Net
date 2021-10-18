using System;
using System.Collections.Generic;
using System.Text;

namespace Hotel.DAL.Entities
{
    public class Category
    {
        public int Id { get; set; }

        public string CategoryName { get; set; }

        public int Bed { get; set; }

        public virtual ICollection<PriceCategory> PriceCategory { get; set; }

        public virtual ICollection<Room> Room { get; set; }
    }
}
