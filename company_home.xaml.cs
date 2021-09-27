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
    /// Interaction logic for tp.xaml
    /// </summary>
    public partial class tp : Window
    {
        List<candidate> candidates;
        public tp()
        {
            InitializeComponent();
        }

        //DoubleAnimation da = new DoubleAnimation(20, TimeSpan.FromSeconds(1.5));

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            candidates = new List<candidate> { new candidate { name = "Max John", company="siemens"},
                 new candidate { name = "Ben Dsouza", company="SAP"},
                new candidate { name = "John Williams", company="Infosys"},
                 new candidate { name = "Bina paul", company="Wipro"},
                 new candidate { name = "Joseph A",company="siemens"},
                };
            lbx_harini.ItemsSource = candidates;


            candidates = new List<candidate> { new candidate { name1 = "Max John", company1 = "siemens" },
                new candidate { name1 = "Ben Dsouza", company1 = "SAP" },
                new candidate { name1 = "Andreas", company1 = "Volkswagen" }
            };
            lbx_harini1.ItemsSource = candidates;



        }





        private void Btn_Managejobs_Click(object sender, RoutedEventArgs e)
        {
            var win = new managejobs();
            win.Show();
        }

        private void lbx_harini_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var win = new resume();
            win.Show();
        }






        //private void Grd_Menue_MouseEnter(object sender, MouseEventArgs e)
        //{
        //    da.To = 300;
        //    Grd_Menue.BeginAnimation(Grid.WidthProperty, da);
        //}




        //private void Grd_Menue_MouseLeave(object sender, MouseEventArgs e)
        //{
        //    da.To = 20;
        //    Grd_Menue.BeginAnimation(Grid.WidthProperty, da);
        //}
    }
}
