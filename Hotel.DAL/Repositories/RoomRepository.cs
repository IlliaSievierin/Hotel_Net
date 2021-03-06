using Hotel.DAL.EF;
using Hotel.DAL.Entities;
using Hotel.DAL.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hotel.DAL.Repositories
{
    class RoomRepository : IRepository<Room>
    {

        private HotelContext db;

        public RoomRepository(HotelContext db)
        {
            this.db = db;
        }

        public IEnumerable<Room> GetAll()
        {
            return db.Rooms;
        }

        public Room Get(int id)
        {
            return db.Rooms.Find(id);
        }

        public void Create(Room room)
        {
            db.Rooms.Add(room);
        }

        public void Delete(int id)
        {
            Room room = Get(id);
            if (room != null)
                db.Rooms.Remove(room);
        }

        public void Update(Room newRoom, int id)
        {
            Room room = Get(id);
            if (room != null)
            {
                room.CategoryId = newRoom.CategoryId;
                room.Active = newRoom.Active;
                db.Entry(room).State = EntityState.Modified;
            }
        }
    }
}
