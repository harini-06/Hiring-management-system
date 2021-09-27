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
    /// Interaction logic for Homepage.xaml
    /// </summary>
    public partial class Homepage : Window
    {
        public Homepage()
        {
            InitializeComponent();
        }

        private void assmt_v_Click(object sender, RoutedEventArgs e)
        {
            var win = new Viewassessment();
            win.Show();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var win = new profile();
            win.Show();
        }

        private void view_Click(object sender, RoutedEventArgs e)
        {
            var win = new jobdetails();
            win.Show();
        }

      
    }
}
