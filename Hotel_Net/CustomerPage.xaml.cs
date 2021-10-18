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
    /// Логика взаимодействия для CustomerPage.xaml
    /// </summary>
    public partial class CustomerPage : Window
    {
        private ICustomerService service;
        public CustomerPage(ICustomerService service)
        {
            InitializeComponent();
            this.service = service;
        }

        private void Grid_Loaded(object sender, RoutedEventArgs e)
        {
            CustomerDataGrid.ItemsSource = service.GetAll();
        }

        private void ButtonAdd_Click(object sender, RoutedEventArgs e)
        {
            var clientPage = new ChangeCustomer(null, service);
            clientPage.Show();
            this.Close();
        }

        private void ButtonUpdate_Click(object sender, RoutedEventArgs e)
        {
            var clientPage = new ChangeCustomer(CustomerDataGrid.SelectedItem as CustomerDTO, service);
            clientPage.Show();
            this.Close();
        }

        private void ButtonDelete_Click(object sender, RoutedEventArgs e)
        {
            var item = CustomerDataGrid.SelectedItem as CustomerDTO;
            service.Delete(item.Id);
            CustomerDataGrid.ItemsSource = service.GetAll();
        }

    }
}
