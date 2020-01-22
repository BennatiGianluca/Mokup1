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

namespace mokup1
{

    public partial class MainWindow : Window
    {
        
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string name = txtName.Text;
            string surname = txtLname.Text;
            string data = pData.SelectedDate.ToString();
            if (name =="" || surname == "")
            {
                MessageBox.Show($"Insert name or surname");
            }
            else
            {
                MessageBox.Show($"Welcome {name} {surname}");
            }
        }

        private void CkB_Checked(object sender, RoutedEventArgs e)
        {
            btnPrint.IsEnabled = true;           
        }
    }
}
