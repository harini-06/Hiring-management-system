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
    /// Interaction logic for Landing_page.xaml
    /// </summary>
    public partial class Landing_page : Window
    {
        public Landing_page()
        {
            InitializeComponent();
        }

        private void Sign_In_Click(object sender, RoutedEventArgs e)
        {
            var Win = new Homepage();
            Win.Show();
        }

        private void register_Click(object sender, RoutedEventArgs e)
        {
            var Win = new MainWindow();
            Win.Show();
        }

        private void Looking_for_job_Click(object sender, RoutedEventArgs e)
        {
            var Win = new Homepage();
            Win.Show();
        }
    }
}
