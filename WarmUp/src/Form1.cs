using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace HolaMundo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string password_1 = txtPasswd1.Text, password_2 = txtPasswd2.Text;
            // Revisar que la contrase�a no est� vac�a
            if(String.IsNullOrEmpty(password_1) || String.IsNullOrEmpty(password_2))
                MessageBox.Show("Los campos no deben estar vac�os.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            // Revisar que sean iguales
            else if(!String.Equals(password_1, password_2))
                MessageBox.Show("La contrase�a no coincide.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //Al menos una letra may�scula
            else if(!Regex.IsMatch(password_1, ".*[A-Z].*"))
                MessageBox.Show("La contrase�a debe contener al menos una may�scula.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //Al menos una letra min�scula
            else if(!Regex.IsMatch(password_1, ".*[a-z].*"))
                MessageBox.Show("La contrase�a debe contener al menos una min�scula.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //Al menos un s�mbolo
            else if(!Regex.IsMatch(password_1, ".*[^A-Za-z\\d].*"))
                MessageBox.Show("La contrase�a debe contener al menos un s�mbolo.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //Al menos un n�mero
            else if(!Regex.IsMatch(password_1, ".*[0-9].*"))
                MessageBox.Show("La contrase�a debe contener al menos un n�mero.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
                MessageBox.Show("La contrase�a ha sido validada", ":)", MessageBoxButtons.OK, MessageBoxIcon.None);
        }
    }
}