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
    /// Логика взаимодействия для Operationsw.xaml
    /// </summary>
    public partial class Operationsw : Window
    {
        public Operationsw()
        {
            InitializeComponent();
            updatedt();
        }

        public void updatedt()
        {
            ZOOPARK db = new ZOOPARK();
            List<Operations> OperL = new List<Operations>();
            OperL = db.Operations.ToList();
            DtOper.ItemsSource = OperL;
        }

        public void add()
        {
           Oper_Reg or = new Oper_Reg();
            or.Show();
            this.Close();
            updatedt();
        }

        public void del()
        {
            ZOOPARK db = new ZOOPARK();
            if (DtOper.SelectedItem is Operations selectedOperation)
            {
                Operations Oper = db.Operations.FirstOrDefault(x => x.id_Operations.Equals(selectedOperation.id_Operations));
                db.Operations.Remove(Oper);
                db.SaveChanges();
                updatedt();
            }
        }

        private void OperDel_Click(object sender, RoutedEventArgs e)
        {
            del();
        }

        private void OperReg_Click(object sender, RoutedEventArgs e)
        {
            add();
        }

        private void OperMenu_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mw = new MainWindow();
            mw.Show();
            this.Close();
        }
    }
}
