using Hotel.BLL.DTO;
using Hotel.BLL.Interfaces;
using System.Windows;

namespace Hotel.PL
{

    public partial class ReservationPage : Window
    {
        private IReservationService service;

        public ReservationPage(IReservationService service)
        {
            InitializeComponent();
            this.service = service;
        }

        private void Grid_Loaded(object sender, RoutedEventArgs e)
        {
            ReservationDataGrid.ItemsSource = service.GetAll();
        }

        private void ButtonAdd_Click(object sender, RoutedEventArgs e)
        {
            var resrvationPage = new ChangeResrvation(null, service);
            resrvationPage.Show();
            this.Close();
        }

        private void ButtonUpdate_Click(object sender, RoutedEventArgs e)
        {
            var resrvationPage = new ChangeResrvation(ReservationDataGrid.SelectedItem as ReservationDTO, service);
            resrvationPage.Show();
            this.Close();
        }

        private void ButtonDelete_Click(object sender, RoutedEventArgs e)
        {
            var item = ReservationDataGrid.SelectedItem as ReservationDTO;
            service.Delete(item.Id);
            ReservationDataGrid.ItemsSource = service.GetAll();
        }

    }
}
