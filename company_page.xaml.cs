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
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace hireme_1
{
    /// <summary>
    /// Interaction logic for company_page.xaml
    /// </summary>
    public partial class company_home : Window
    {
        public company_home()
        {
            InitializeComponent();
        }


        DoubleAnimation da = new DoubleAnimation(20, TimeSpan.FromSeconds(1.5));

        private void Grd_Menue_MouseLeave(object sender, MouseEventArgs e)
        {
            da.To = 20;
            Grd_Menue.BeginAnimation(Grid.WidthProperty, da);
        }

        private void Grd_Menue_MouseEnter(object sender, MouseEventArgs e)
        {
            da.To = 300;
            Grd_Menue.BeginAnimation(Grid.WidthProperty, da);
        }

        private void Btn_Applicants_Click(object sender, RoutedEventArgs e)
        {
            var win = new company_home();
            win.Show();
        }
    }
}
