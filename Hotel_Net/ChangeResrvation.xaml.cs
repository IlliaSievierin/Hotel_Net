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
    /// <summary>
    /// Логика взаимодействия для ChangeResrvation.xaml
    /// </summary>
    public partial class ChangeResrvation : Window
    {
        private ReservationDTO reservation;
        private IReservationService service;

        public ChangeResrvation(ReservationDTO reservation,IReservationService service)
        {
            InitializeComponent();
            this.reservation = reservation;
            this.service = service;
        }

        private void Grid_Loaded(object sender, RoutedEventArgs e)
        {
            if (reservation != null)
            {
                RoomId.Text = reservation.RoomId.ToString();
                CustomerId.Text = reservation.CustomerId.ToString();
                ReservationDate.Text = reservation.ReservationDate.ToString();
                ArrivalDate.Text = reservation.ArrivalDate.ToString();
                DepartureDate.Text = reservation.DepartureDate.ToString();
                CheckIn.IsEnabled = reservation.CheckIn;
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var newReservation = new ReservationDTO()
            {
                RoomId = int.Parse(RoomId.Text),
                CustomerId = int.Parse(CustomerId.Text),
                ReservationDate = ReservationDate.SelectedDate.Value,
                ArrivalDate = ArrivalDate.SelectedDate.Value,
                DepartureDate = DepartureDate.SelectedDate.Value,
                CheckIn = CheckIn.IsEnabled
            };

            if (reservation != null)
            {
                service.Update(newReservation,reservation.Id);
            }
            else
            {
                service.Create(newReservation);
            }
        }
    }
}
