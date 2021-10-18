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

    public partial class PriceCategoryPage : Window
    {
        private IPriceCategoryService service;
        public PriceCategoryPage(IPriceCategoryService service)
        {
            InitializeComponent();
            this.service = service;
        }

        private void Grid_Loaded(object sender, RoutedEventArgs e)
        {
            PricaCategoryDataGrid.ItemsSource = service.GetAll();
        }

        private void ButtonAdd_Click(object sender, RoutedEventArgs e)
        {
            var priceCategoryPage = new ChangePriceCategory(null, service);
            priceCategoryPage.Show();
            this.Close();
        }

        private void ButtonUpdate_Click(object sender, RoutedEventArgs e)
        {
            var priceCategoryPage = new ChangePriceCategory(PricaCategoryDataGrid.SelectedItem as PriceCategoryDTO, service);
            priceCategoryPage.Show();
            this.Close();
        }

        private void ButtonDelete_Click(object sender, RoutedEventArgs e)
        {
            var item = PricaCategoryDataGrid.SelectedItem as PriceCategoryDTO;
            service.Delete(item.Id);
            PricaCategoryDataGrid.ItemsSource = service.GetAll();
        }
    }
}
