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
    /// Логика взаимодействия для Reg_Animal.xaml
    /// </summary>
    public partial class Reg_Animal : Window
    {
        public Reg_Animal()
        {
            InitializeComponent();
        }

        private void Reg_Click(object sender, RoutedEventArgs e)
        {
            string ida = Tb_id_Animal.Text;
            string idc = Tb_cage.Text;
            ZOOPARK db = new ZOOPARK();
            Animal reg = new Animal()
            {
                id_Animal = Convert.ToInt32(ida),
                Name_Animal = Tb_Name.Text,
                Species = Tb_Species.Text,
                DateOfBirth = Tb_DateOfBirth.Text,
                Gender = Tb_Sex.Text,
                id_Cage = Convert.ToInt32(idc),
            };
            db.Animal.Add(reg);
            db.SaveChanges();
            MessageBox.Show("Вы Добавили животное");
            Animalw animalw = new Animalw();
            animalw.Show();
            this.Close();
        }
    }
}
