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
    /// Interaction logic for Viewassessment.xaml
    /// </summary>
    public partial class Viewassessment : Window
    {
        public Viewassessment()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var win = new Homepage();
            win.Show();
        }
    }
    }

