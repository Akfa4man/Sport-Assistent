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
using MySql.Data.MySqlClient;

namespace Sport_Assistent
{
    public partial class EntryWind : Form, IMainPanel
    {
        private MySqlConnection connector;
        public Panel MainPanel
        {
            get { return mainPanel; }
        }

        public EntryWind()
        {
            InitializeComponent();
            //string s = ConfigurationManager.ConnectionStrings["Profile"].ConnectionString;
        }

        private void passwordLabel_Click(object sender, EventArgs e)
        {

        }

        private void loginLabel_Click(object sender, EventArgs e)
        {

        }

        private void loginTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void passwordTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void beginButton_Click(object sender, EventArgs e)
        {
        }

        private void entryButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Коммит 1");
            try
            {
                connector = new MySqlConnection(ConfigurationManager.ConnectionStrings["ProfileStart"].ConnectionString);
                connector.Open();
            }
            catch(Exception ex)
            {
                MessageBox.Show($"Ошибка подключения к базам данных: {ex.Message}\nПовторите попытку позже!");
                return;
            }
            string login = emailTextBox.Text;
            string password = passwordTextBox.Text;
            DataTable dataTable = new DataTable();
            MySqlDataAdapter sqlDataAdapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand("SELECT * FROM `startingdatabase` WHERE `login`=@ul AND `password`=@up", connector);
            command.Parameters.Add("@ul", MySqlDbType.VarChar).Value = login;
            command.Parameters.Add("@up", MySqlDbType.VarChar).Value = password;
            sqlDataAdapter.SelectCommand = command;
            sqlDataAdapter.Fill(dataTable);
            connector.Close();
            //var d = dataTable;
            //var s = dataTable.Rows[0]["role"];
            if (dataTable.Select().Length == 1)
            {
                switch ((uint)dataTable.Rows[0]["role"])
                {
                    case 4:
                        VisualEffects.WindowChange(new AdminWind());
                        break;
                    case 2:
                        VisualEffects.WindowChange(new AccountantWind());
                        break;
                    case 0:
                        VisualEffects.WindowChange(new ClientWind(login,password));
                        break;
                    case 3:
                        VisualEffects.WindowChange(new SPAdminWind());
                        break;
                    case 1:
                        VisualEffects.WindowChange(new TrainerWind());
                        break;
                    default:
                        MessageBox.Show("Ошибка нахождения нужного профильного окна! Срочно обратитесь администрации при нахождении этой ошибки!");
                        break;
                }
            }
            else MessageBox.Show("Профиль не найден!");
        }

        private void registrationButton_Click(object sender, EventArgs e)
        {
            VisualEffects.WindowChange(new RegistrationWind());
        }

        private void entryPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void accesRestorationButton_Click(object sender, EventArgs e)
        {
            VisualEffects.WindowChange(new AccesRestorationWind());
        }

        private void EntryWind_Load(object sender, EventArgs e)
        {
           
        }

        private void mainPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
