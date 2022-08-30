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
    /// Логика взаимодействия для Oper_Reg.xaml
    /// </summary>
    public partial class Oper_Reg : Window
    {
        public Oper_Reg()
        {
            InitializeComponent();
        }

        private void Reg_Click(object sender, RoutedEventArgs e)
        {
            Operationsw opw = new Operationsw();
            ZOOPARK db = new ZOOPARK();
            Operations op = new Operations()
            {
                timeOperations = DateTime.Now.ToString(),
                id_Animal = Convert.ToInt32(Tb_id_Animal.Text),
                id_Staff = Convert.ToInt32(Tb_id_Staff.Text),
                TypeOfOperation = Tb_operations.Text,
            };
            db.Operations.Add(op);
            db.SaveChanges();
            MessageBox.Show("Операция создана!!!");
            opw.Show();
            this.Close();
            opw.updatedt();
        }
    }
}
