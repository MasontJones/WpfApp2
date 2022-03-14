using Data;
using MySql.Data.MySqlClient;
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


namespace RecordDatabase
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Add_Actor_Button_Click(object sender, RoutedEventArgs e)
        {
            AddActorWindow addActorWindow = new AddActorWindow();
            this.Visibility = Visibility.Collapsed;
            addActorWindow.ShowDialog();
            this.Visibility = Visibility.Visible;
            /* var dbCon = DBConnection.Instance();
            dbCon.Server = "209.106.201.103";
            dbCon.databaseName = "group3";
            dbCon.UserName = "dbstudent6";
            dbCon.Password = "freshsugar87";
            if (dbCon.IsConnect())
            {

                //suppose col0 and col1 are defined as VARCHAR in the DB
                string query = "SELECT * FROM Actor";
                var cmd = new MySqlCommand(query, DBConnection.Connection);
                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    int actorID = reader.GetInt32(0);
                    string firstName = reader.GetString(1);
                    string lastName = reader.GetString(2);
                    string birthDate = reader.GetString(3);
                    MessageBox.Show(actorID + "," + firstName + "," + lastName + "," + birthDate);
                }
                dbCon.Close();*/
            }

        private void Search_Actor_Button_Click(object sender, RoutedEventArgs e)
        {
            SearchActorWindow searchActorWindow = new SearchActorWindow();
            this.Visibility = Visibility.Collapsed;
            searchActorWindow.ShowDialog();
            this.Visibility = Visibility.Visible;
        }
    }

 
    
}
