using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
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

namespace Uppgift.Views
{
    /// <summary>
    /// Interaction logic for NewCustomerView.xaml
    /// </summary>
    
    public partial class NewCustomerView : UserControl
    {

        public NewCustomerView()
        {
            InitializeComponent();

        }

        

        private void btnAdd_Click_1(object sender, RoutedEventArgs e)
        {
          try 
          { 
            SqlConnection con =new SqlConnection();
            con.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\samer\Desktop\WIN21\DataBase\CustomersCasesSystem\Uppgift\Data\uppgift.mdf;
                                    Integrated Security=True;Connect Timeout=30";
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "INSERT INTO Addresses (StreetName, PostalCode, City, Country) " +
                "values (@st, @pc, @ci, @ca)";
            cmd.Parameters.AddWithValue("@st", tbstreetname.Text);
            cmd.Parameters.AddWithValue("@pc", tbpostalcode.Text);
            cmd.Parameters.AddWithValue("@ci", tbcity.Text);
            cmd.Parameters.AddWithValue("@ca", tbcountry.Text);

            cmd.Connection = con;

            cmd.ExecuteNonQuery();

            cmd.CommandText = "INSERT INTO Customers (FirstName, Lastname, Email, Tele, Mobile, AddressId)" +
                " values(@nm, @ls, @em, @te, @mo, @ad)";

            cmd.Parameters.AddWithValue("@nm", tbFirstName.Text);
            cmd.Parameters.AddWithValue("@ls", tbLastName.Text);
            cmd.Parameters.AddWithValue("@em", tbEmail.Text);
            cmd.Parameters.AddWithValue("@te", tbPhoneNumber.Text);
            cmd.Parameters.AddWithValue("@mo", tbMobile.Text);
            cmd.Parameters.AddWithValue("@ad", tbAddressId.Text);

            cmd.Connection = con;

            int a = cmd.ExecuteNonQuery();

            con.Close();

                if (a == 1)
                {
                    MessageBox.Show("Record Added");
                }
                else
                    MessageBox.Show("Error");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        
    }
}
