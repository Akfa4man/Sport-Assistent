using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sport_Assistent
{
    public partial class ClientWind : Form, IMainPanel
    {
        private string login;
        private string password;
        private MySqlConnection connector;
        public Panel MainPanel
        {
            get { return mainPanel; }
        }

        public ClientWind(string login, string password)
        {
            InitializeComponent();
            this.login = login;
            this.password = password;
            //Ex();
            ProfileClient();
        }
        private void Ex()
        {
            connector = new MySqlConnection(ConfigurationManager.ConnectionStrings["ProfileClient"].ConnectionString);
            connector.Open();
            MySqlCommand command = new MySqlCommand("INSERT INTO clientdatabase (surname, name, patronymic, login, password) VALUES (@Value1, @Value2, @Value3, @Value4, @Value5)", connector);
            command.Parameters.Add("@Value1", MySqlDbType.VarChar).Value = "Корольков";
            command.Parameters.Add("@Value2", MySqlDbType.VarChar).Value = "Иван";
            command.Parameters.Add("@Value3", MySqlDbType.VarChar).Value = "Юрьевич";
            command.Parameters.Add("@Value4", MySqlDbType.VarChar).Value = login;//ошибка выходит, збс)))
            command.Parameters.Add("@Value5", MySqlDbType.VarChar).Value = password;
            command.ExecuteNonQuery();
            connector.Close();
        }
        private void ProfileClient()
        {
            connector = new MySqlConnection(ConfigurationManager.ConnectionStrings["ProfileClient"].ConnectionString);
            DataTable dataTable = new DataTable();
            MySqlDataAdapter sqlDataAdapter = new MySqlDataAdapter();
            connector.Open();
            MySqlCommand command = new MySqlCommand("SELECT * FROM `clientdatabase` WHERE `login`=@ul AND `password`=@up", connector);
            command.Parameters.Add("@ul", MySqlDbType.VarChar).Value = login;
            command.Parameters.Add("@up", MySqlDbType.VarChar).Value = password;
            sqlDataAdapter.SelectCommand = command;
            sqlDataAdapter.Fill(dataTable);
            connector.Close();
            surname.Text = (string)dataTable.Rows[0]["surname"];
            name.Text= (string)dataTable.Rows[0]["name"];
            patronymic.Text= (string)dataTable.Rows[0]["patronymic"];
        }

        private void trainerLabel_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void mainPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void userNameLabel_Click(object sender, EventArgs e)
        {

        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            VisualEffects.WindowChange(new EntryWind());
        }

        private void profilePage_Click(object sender, EventArgs e)
        {

        }

        private void Zameni_Menia_Leha_sdelai_krasivo_Click(object sender, EventArgs e)
        {

        }

        private void surname_Click(object sender, EventArgs e)
        {

        }

        private void name_Click(object sender, EventArgs e)
        {

        }

        private void patronymic_Click(object sender, EventArgs e)
        {

        }
    }
}
