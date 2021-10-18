using System;
using System.Collections.Generic;
using System.Text;

namespace Hotel.DAL.Entities
{
    public class PriceCategory
    {
        public int Id { get; set; }

        public int CategoryId { get; set; }

        public decimal Price { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        public virtual Category Category { get; set; }
    }
}
