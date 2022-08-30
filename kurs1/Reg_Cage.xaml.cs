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
    /// Логика взаимодействия для Reg_Cage.xaml
    /// </summary>
    public partial class Reg_Cage : Window
    {
        public Reg_Cage()
        {
            InitializeComponent();
        }

        private void Reg_Click(object sender, RoutedEventArgs e)
        {
            ZOOPARK db = new ZOOPARK();
            CAGE cAGE = new CAGE()
            {
                id_Cage = Convert.ToInt32(Tb_idCage.Text),
                Name_cage = Tb_Name.Text,
                Size_cage = Tb_Size.Text,
                
            };
            db.CAGE.Add(cAGE);
            db.SaveChanges();
            Cagew cagew = new Cagew();
            cagew.Show();
            this.Close();
            
            Cagew cac = new Cagew();
            cac.updatedt();
        }
    }
}
