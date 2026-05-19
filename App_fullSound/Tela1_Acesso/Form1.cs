using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tela1_Acesso
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        private void btnEntrar_Click(object sender, EventArgs e)
        {
            string conexao = "Server=localhost;Database=FullSound;Uid=root;Pwd=;";
            string usuario = txtUsuario.Text.Trim();
            string senha = txtSenha.Text.Trim();

            if (usuario == "" || senha == "")
            {
                MessageBox.Show("Preencha usuário e senha.");
                return;
            }
            using (MySqlConnection conn = new MySqlConnection(conexao))
            {
                conn.Open();
                string sql = "SELECT COUNT(*) FROM usuarios WHERE usuario = @usuario AND senha = @senha";
                using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@usuario", usuario);
                    cmd.Parameters.AddWithValue("@senha", senha);
                    int resultado = Convert.ToInt32(cmd.ExecuteScalar());
                    if (resultado > 0)
                    {
                        MessageBox.Show("Login realizado com sucesso!");

                        Home telaHome = new Home();
                        telaHome.Show();

                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Usuário ou senha incorretos.");
                    }
                }
            }
        }
        private void txtSenha_TextChanged(object sender, EventArgs e)
        {
            txtSenha.PasswordChar = '*';
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
