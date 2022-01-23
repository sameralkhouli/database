using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Dynamic;
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
using Uppgift.Data;
using Uppgift.Services;
using static Uppgift.Views.ICustomerService;

namespace Uppgift.Views
{
    /// <summary>
    /// Interaction logic for CustomerView.xaml
    /// </summary>
    public partial class CustomerView : UserControl
    {
        public CustomerView()
        {
            InitializeComponent();
            //lvUsers.Items.Clear();
            //foreach (var customer in customerService.GetAll())
            //{
            //    lvUsers.Items.Add(customer);
            //}
        }

      //  private readonly ICustomerService customerService = new CustomerService();

        private readonly CustomerService customerService = new CustomerService();

       // private readonly SqlContext _context = new();
      

        public IEnumerable LoadCollectionData { get; private set; }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            //string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\samer\Desktop\WIN21\DataBase\CustomersCasesSystem\Uppgift\Data\uppgift.mdf;Integrated Security=True;Connect Timeout=30";
            //string sql = "SELECT FirstName, LastName, Email, Mobile FROM Customers";
            //SqlConnection connection = new SqlConnection(connectionString);
            //SqlDataAdapter dataadapter = new SqlDataAdapter(sql, connection);
            //DataSet ds = new DataSet();
            //connection.Open();
            //dataadapter.Fill(ds, "Customers");

           

            //DataGrid.ItemsSource = LoadCollectionData;
        }
    }
}
