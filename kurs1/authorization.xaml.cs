using System.Windows;
using System.Windows.Controls;
using System.Data.SqlClient;
using System.Data;
using System.Linq;

namespace kurs1
{
    /// <summary>
    /// Логика взаимодействия для Window1.xaml
    /// </summary>
    public partial class authorization : Window
    {
        public authorization()
        {
            InitializeComponent();
        }


        private void Authorization_Click(object sender, RoutedEventArgs e)
        {
            ZOOPARK db = new ZOOPARK(); 
            string pass = passwordbox.Password.Trim();
            string log = loginbox.Text.Trim();
            Staff auth = null;
            if (loginbox.Text == "" || passwordbox.Password == "")
            {
                MessageBox.Show("Есть пустое поле!");
            }
            else
            {         
                    auth = db.Staff.Where(user => user.Login_staff == log && user.Password_staff == pass ).FirstOrDefault();
                if (auth != null)
                {
                    if (auth.Position == "Staff")
                    {
                        MainWindow mw = new MainWindow();
                        mw.Show();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Доступ запещен");
                    }
                }
                else
                {
                    MessageBox.Show("Вас нет в базе");
                }
            }
        }

        private void loginbox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            registration reg = new registration();
            reg.Show();
            this.Close();
        }
    }
}
