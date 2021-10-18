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

        public MainWindow(ICustomerService customerService,
            ICategoryService categoryService,
            IPriceCategoryService priceCategoryService, 
            IReservationService reservationService)
        {
            InitializeComponent();
            this.customerService = customerService;
            this.categoryService = categoryService;
            this.priceCategoryService = priceCategoryService;
            this.reservationService = reservationService;
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
    }
}
