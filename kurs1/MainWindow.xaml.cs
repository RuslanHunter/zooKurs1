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
using System.Data.SqlClient;

namespace kurs1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            Animalw anm = new Animalw();
            anm.Show();
            this.Close();
        }
        private void button2_Click(object sender, RoutedEventArgs e)
        {
            Cagew cag = new Cagew();
            cag.Show();
            this.Close();
        }

        private void button3_Click(object sender, RoutedEventArgs e)
        {
           Operationsw op = new Operationsw();
            op.Show();
            this.Close();
        }
    }
}
