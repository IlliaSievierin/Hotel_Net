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
    /// Логика взаимодействия для ChangeCategory.xaml
    /// </summary>
    public partial class ChangeCategory : Window
    {
        private CategoryDTO category;
        private ICategoryService service;

        public ChangeCategory(CategoryDTO category, ICategoryService service)
        {
            InitializeComponent();
            this.category = category;
            this.service = service;
        }

        private void Grid_Loaded(object sender, RoutedEventArgs e)
        {
            if (category != null)
            {
                CategoryName.Text = category.CategoryName;
                Bed.Text = category.Bed.ToString();
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var newCategory = new CategoryDTO()
            {
                CategoryName = CategoryName.Text,
                Bed = int.Parse(Bed.Text)
            };

            if (category != null)
            {
                service.Update(category.Id, newCategory);
            }
            else
            {
                service.Create(newCategory);
            }
        }

    }
}
