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
    /// Логика взаимодействия для CategoryPage.xaml
    /// </summary>
    public partial class CategoryPage : Window
    {
        private ICategoryService service;
        public CategoryPage(ICategoryService service)
        {
            InitializeComponent();
            this.service = service;
        }

        private void Grid_Loaded(object sender, RoutedEventArgs e)
        {
            CategoryDataGrid.ItemsSource = service.GetAll();
        }

        private void ButtonAdd_Click(object sender, RoutedEventArgs e)
        {
            var changeCategory = new ChangeCategory(null, service);
            changeCategory.Show();
            this.Close();
        }

        private void ButtonUpdate_Click(object sender, RoutedEventArgs e)
        {
            var changeCategory = new ChangeCategory(CategoryDataGrid.SelectedItem as CategoryDTO, service);
            changeCategory.Show();
            this.Close();
        }

        private void ButtonDelete_Click(object sender, RoutedEventArgs e)
        {
            var item = CategoryDataGrid.SelectedItem as CategoryDTO;
            service.Delete(item.Id);
            CategoryDataGrid.ItemsSource = service.GetAll();
        }
    }
}
