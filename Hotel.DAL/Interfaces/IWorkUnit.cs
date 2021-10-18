using Hotel.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hotel.DAL.Interfaces
{
    public interface IWorkUnit
    {
        IRepository<Category> Categories { get; }
        IRepository<Customer> Customers { get; }
        IRepository<PriceCategory> PriceCategories { get; }
        IRepository<Reservation> Reservations { get; }
        IRepository<Room> Rooms { get; }
        void Save();
    }
}
