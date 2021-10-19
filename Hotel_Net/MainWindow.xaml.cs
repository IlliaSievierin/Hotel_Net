using Hotel.BLL.Interfaces;
using Hotel.PL;
using System.Windows;

namespace Hotel_Net
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private ICustomerService customerService;
        private ICategoryService categoryService;
        private IPriceCategoryService priceCategoryService;
        private IReservationService reservationService;
        private IRoomService roomService;

        public MainWindow(ICustomerService customerService,
            ICategoryService categoryService,
            IPriceCategoryService priceCategoryService, 
            IReservationService reservationService,
            IRoomService roomService)
        {
            InitializeComponent();
            this.customerService = customerService;
            this.categoryService = categoryService;
            this.priceCategoryService = priceCategoryService;
            this.reservationService = reservationService;
            this.roomService = roomService;
        }

        private void ButtonCustomer_Click(object sender, RoutedEventArgs e)
        {
            var clientPage = new CustomerPage(customerService);
            clientPage.Show();
        }

        private void ButtonCategory_Click(object sender, RoutedEventArgs e)
        {
            var categoryPage = new CategoryPage(categoryService);
            categoryPage.Show();
        }

        private void ButtonPriceCategory_Click(object sender, RoutedEventArgs e)
        {
            var priceCategoryPage = new PriceCategoryPage(priceCategoryService);
            priceCategoryPage.Show();
        }

        private void ButtonReservation_Click(object sender, RoutedEventArgs e)
        {
            var reservationPage = new ReservationPage(reservationService);
            reservationPage.Show();
        }

        private void ButtonRoom_Click(object sender, RoutedEventArgs e)
        {
            var roomPage = new RoomPage(roomService);
            roomPage.Show();
        }
    }
}
