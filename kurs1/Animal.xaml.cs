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

namespace kurs1
{
    /// <summary>
    /// Логика взаимодействия для Window1.xaml
    /// </summary>
    public partial class Animalw : Window
    {
        public void updatedta()
        {
            ZOOPARK db = new ZOOPARK();
            List<Animal> animalsl = new List<Animal>(); 
            animalsl = db.Animal.ToList();
            DtAnimal.ItemsSource = animalsl;
        }
        

        public Animalw()
        {
            InitializeComponent();
            updatedta();
        }

        public void Delete()
        {
            ZOOPARK db = new ZOOPARK();
            if (DtAnimal.SelectedItem is Animal selectedAnimal)
            {
                Animal Anim = db.Animal.Where(a => a.id_Animal == selectedAnimal.id_Animal).FirstOrDefault();
                db.Animal.Remove(Anim);
                db.SaveChanges();
                updatedta();
            }
        }

        private void AnimalReg_Click(object sender, RoutedEventArgs e)
        {
            Reg_Animal reg = new Reg_Animal();
            reg.Show();
            this.Close();
        }
        private void AnimalDel_Click(object sender, RoutedEventArgs e)
        {
            Delete();
        }

        private void AnimalMenu_Click(object sender, RoutedEventArgs e)
        {
            menuw();
        }

        public void menuw()
        {
            MainWindow mw = new MainWindow();
            mw.Show();
            this.Close();
        }
    }
}
