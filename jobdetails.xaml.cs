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
using System.Windows.Shapes;

namespace hireme_1
{
    /// <summary>
    /// Interaction logic for jobdetails.xaml
    /// </summary>
    public partial class jobdetails : Window
    {
        public jobdetails()
        {
            InitializeComponent();
        }

       

        private void sv_Click(object sender, RoutedEventArgs e)
        {
            var win = new unregistered_apply();
            win.Show();

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var win = new Homepage();
            win.Show();
        }
    }
}
