using Hotel.BLL.DTO;
using Hotel.BLL.Interfaces;
using System.Windows;

namespace Hotel.PL
{
    /// <summary>
    /// Логика взаимодействия для RoomPage.xaml
    /// </summary>
    public partial class RoomPage : Window
    {
        private IRoomService service;

        public RoomPage(IRoomService service)
        {
            InitializeComponent();
            this.service = service;
        }

        private void Grid_Loaded(object sender, RoutedEventArgs e)
        {
            RoomDataGrid.ItemsSource = service.GetAll();
        }

        private void ButtonAdd_Click(object sender, RoutedEventArgs e)
        {
            var roomPage = new ChangeRoom(null, service);
            roomPage.Show();
            this.Close();
        }

        private void ButtonUpdate_Click(object sender, RoutedEventArgs e)
        {
            var roomPage = new ChangeRoom(RoomDataGrid.SelectedItem as RoomDTO, service);
            roomPage.Show();
            this.Close();
        }

        private void ButtonDelete_Click(object sender, RoutedEventArgs e)
        {
            var item = RoomDataGrid.SelectedItem as RoomDTO;
            service.Delete(item.Id);
            RoomDataGrid.ItemsSource = service.GetAll();
        }
    }
}
