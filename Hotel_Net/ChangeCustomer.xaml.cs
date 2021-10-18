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
    public partial class ChangeCustomer : Window
    {
        private CustomerDTO customer;
        private ICustomerService service;

        public ChangeCustomer(CustomerDTO customer,ICustomerService service)
        {
            InitializeComponent();
            this.customer = customer;
            this.service = service;
        }

        private void Grid_Loaded(object sender, RoutedEventArgs e)
        {
            if (customer != null)
            {
                FirstName.Text = customer.FirstName;
                LastName.Text = customer.LastName;
                MiddleName.Text = customer.MiddleName;
                DateOfBirth.SelectedDate = customer.DateOfBirth;
                Passport.Text = customer.Passport;
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var newCustomer = new CustomerDTO()
            {
                FirstName = FirstName.Text,
                LastName = LastName.Text,
                MiddleName = MiddleName.Text,
                DateOfBirth = DateOfBirth.DisplayDate,
                Passport = Passport.Text
            };

            if(customer != null)
            {
                service.Update(customer.Id,newCustomer);
            }
            else
            {
                service.Create(newCustomer);
            }
        }
    }
}
