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

namespace Phonebook2WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void StandardUser_Checked(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("pressed standard user");
        }

        private void Supervisor_Checked(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("clicked supervisor");
        }

        private void ViewPhonebook_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("btn clicked");
            //if (standardUser.Checked)
            //{
            //    Phon
            //}
        }
    }
}
