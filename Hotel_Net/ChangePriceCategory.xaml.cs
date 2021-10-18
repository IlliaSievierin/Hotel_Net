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
    /// Логика взаимодействия для ChangePriceCategory.xaml
    /// </summary>
    public partial class ChangePriceCategory : Window
    {
        private PriceCategoryDTO priceCategory;
        private IPriceCategoryService service;

        public ChangePriceCategory(PriceCategoryDTO priceCategory, IPriceCategoryService service)
        {
            InitializeComponent();
            this.priceCategory = priceCategory;
            this.service = service;
        }

        private void Grid_Loaded(object sender, RoutedEventArgs e)
        {
            if (priceCategory != null)
            {
                CategoryId.Text = priceCategory.CategoryId.ToString();
                Price.Text = priceCategory.Price.ToString();
                StartDay.SelectedDate = priceCategory.StartDate;
                EndDay.SelectedDate = priceCategory.EndDate;
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var newPriceCategory = new PriceCategoryDTO()
            {
                CategoryId = int.Parse(CategoryId.Text),
                Price = decimal.Parse(Price.Text),
                StartDate = StartDay.SelectedDate.Value,
                EndDate = EndDay.SelectedDate.Value
            };

            if (priceCategory != null)
            {
                service.Update(priceCategory.Id, newPriceCategory);
            }
            else
            {
                service.Create(newPriceCategory);
            }
        }

    }
}
