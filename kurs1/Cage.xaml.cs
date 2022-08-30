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
using System.Data;
using System.Data.SqlClient;

namespace kurs1
{
    /// <summary>
    /// Логика взаимодействия для Window2.xaml
    /// </summary>
    public partial class Cagew : Window
    {
        public Cagew()
        {
            InitializeComponent();
            updatedt();
        }

        

        private void addc_Click(object sender, RoutedEventArgs e)
        {
            Reg_Cage reg_Cage = new Reg_Cage();
            reg_Cage.Show();
            this.Close();
        }

        public void updatedt()
        {
            ZOOPARK db = new ZOOPARK();
            List<CAGE> cAGEs = new List<CAGE>();
            cAGEs = db.CAGE.ToList();
            Dtcage.ItemsSource = cAGEs.ToList();
        }

        public void delete()
        {
            ZOOPARK db=new ZOOPARK();
            if (Dtcage.SelectedItem is CAGE selectedCage)
            {
                CAGE cAGE = db.CAGE.Where(c => c.id_Cage ==  selectedCage.id_Cage).FirstOrDefault();
                db.CAGE.Remove(cAGE);
                db.SaveChanges();
                updatedt();
            }
        }

        private void dellc_Click(object sender, RoutedEventArgs e)
        {
            delete();
        }

        private void Menu_Click(object sender, RoutedEventArgs e)
        {
            Animalw animalw = new Animalw();
            animalw.menuw();
            this.Close();
        }
    }
}


    
