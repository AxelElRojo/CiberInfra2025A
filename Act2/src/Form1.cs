using MySql.Data.MySqlClient;

namespace Act2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string username = txtUser.Text, passwd = txtPasswd.Text, host = txtHost.Text, port = txtPort.Text, db = txtDB.Text;
            string connectionStr = $"SERVER={host};PORT={port};DATABASE={db};USER={username};PASSWORD={passwd}";
            using (MySqlConnection conn = new MySqlConnection(connectionStr))
            {
                try
                {
                    conn.Open();
                    MessageBox.Show("La conexión se ha ejecutado con éxito :)");
                }
                catch (Exception ex)
                {
                    if (conn.State.ToString() == "Open")
                    {
                        conn.Close();
                    }
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
