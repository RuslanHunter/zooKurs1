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
using Microsoft.Data;

namespace kurs1
{
    /// <summary>
    /// Логика взаимодействия для Window1.xaml
    /// </summary>
    public partial class registration : Window
    {
        public registration()
        {
            InitializeComponent();
        }

        public void reg()
        {
            ZOOPARK db = new ZOOPARK();
            string log = Tb_Login.Text;
            string passw = Tbs_password.Password;
            string Name = Tb_Name.Text;
            string Surname = Tb_Surname.Text;
            string Patronymic = Tb_Patronymic.Text;
            string position = Tb_Position.Text;
            Staff regs = new Staff
            {
                Name = Name,
                Surname = Surname,
                Patronymic = Patronymic,
                Position = position,
                Login_staff = log,
                Password_staff = passw,
            };
            db.Staff.Add(regs);
            db.SaveChanges();
            MessageBox.Show("Вы зарегестрированы");
            authorization auth = new authorization();
            auth.Show();
            this.Close();
        }

        private void Reg_Click(object sender, RoutedEventArgs e)
        {
            reg();
        }

    }
}
