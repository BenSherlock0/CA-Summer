using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace PaulSherlock_S00189970
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        PhoneData db = new PhoneData();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            var query = from p in db.Phones
                        select p.Name;

            var phones = query.ToList();

            lbxName.ItemsSource = phones;
        }

        private void lbxName_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            string name = lbxName.SelectedValue.ToString();

            var query = from p in db.Phones
                        where p.Name == name
                        select p.Price;

            var price = query.ToList();

            tbxPrice.Text = $"€{price}";

            
        }
    }
}
