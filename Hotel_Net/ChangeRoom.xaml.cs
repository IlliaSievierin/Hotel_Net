using Hotel.BLL.DTO;
using Hotel.BLL.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Hotel.PL
{
    public partial class ChangeRoom : Window
    {
        private RoomDTO room;
        private IRoomService service;

        public ChangeRoom(RoomDTO room, IRoomService service)
        {
            InitializeComponent();
            this.room = room;
            this.service = service;
        }

        private void Grid_Loaded(object sender, RoutedEventArgs e)
        {
            if (room != null)
            {
                RoomNumber.Text = room.RoomNumber;
                CategoryId.Text = room.CategoryId.ToString();
                Active.IsEnabled = room.Active;
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var newRoom = new RoomDTO()
            {
                RoomNumber = RoomNumber.Text,
                CategoryId = int.Parse(CategoryId.Text),
                Active = Active.IsEnabled
            };

            if (room != null)
            {
                service.Update(newRoom, room.Id);
            }
            else
            {
                service.Create(newRoom);
            }
        }
    }
}
