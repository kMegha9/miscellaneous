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
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace DisconnectedDemo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public DataSet Disconnected()
        {
            DataSet dsEmployee = new DataSet();
            SqlConnection connObj = new SqlConnection();
            //retrieve the connection string from confi file using the property
            connObj.ConnectionString = ConfigurationManager.ConnectionStrings["conStr"].ToString();
            //initialize dataadapter to fetch data fron the DB by estabilishing the connnection
            SqlDataAdapter daEmp = new SqlDataAdapter("select * from Megha.Employee", connObj);
            //fill data into the dataset
            daEmp.Fill(dsEmployee, "Employee");
            daEmp.FillSchema(dsEmployee, SchemaType.Source, "Employee");
            return dsEmployee;
        }
        public MainWindow()
        {
            InitializeComponent();
        }
        private void button_Click(object sender, RoutedEventArgs e)
        {

        }
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            DataSet ds = Disconnected();
            dg_Emp.ItemsSource = ds.Tables[0].DefaultView;
        }
    }
}
