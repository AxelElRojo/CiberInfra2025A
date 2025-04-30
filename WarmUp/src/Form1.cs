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
            // Revisar que la contraseña no esté vacía
            if(String.IsNullOrEmpty(password_1) || String.IsNullOrEmpty(password_2))
                MessageBox.Show("Los campos no deben estar vacíos.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            // Revisar que sean iguales
            else if(!String.Equals(password_1, password_2))
                MessageBox.Show("La contraseña no coincide.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //Al menos una letra mayúscula
            else if(!Regex.IsMatch(password_1, ".*[A-Z].*"))
                MessageBox.Show("La contraseña debe contener al menos una mayúscula.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //Al menos una letra minúscula
            else if(!Regex.IsMatch(password_1, ".*[a-z].*"))
                MessageBox.Show("La contraseña debe contener al menos una minúscula.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //Al menos un símbolo
            else if(!Regex.IsMatch(password_1, ".*[^A-Za-z\\d].*"))
                MessageBox.Show("La contraseña debe contener al menos un símbolo.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //Al menos un número
            else if(!Regex.IsMatch(password_1, ".*[0-9].*"))
                MessageBox.Show("La contraseña debe contener al menos un número.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
                MessageBox.Show("La contraseña ha sido validada", ":)", MessageBoxButtons.OK, MessageBoxIcon.None);
        }
    }
}