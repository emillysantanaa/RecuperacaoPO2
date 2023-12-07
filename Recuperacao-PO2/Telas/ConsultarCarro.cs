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

namespace Recuperacao_PO2.Telas
{
    public partial class ConsultarCarro : Form
    {
        public ConsultarCarro()
        {
            InitializeComponent();
            btn_voltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btn_voltar.FlatAppearance.BorderSize = 0;
            btn_voltar.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btn_voltar.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btn_voltar.BackColor = Color.Transparent;
            btn_cadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btn_cadastrar.FlatAppearance.BorderSize = 0;
            btn_cadastrar.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btn_cadastrar.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btn_cadastrar.BackColor = Color.Transparent;
        }

        private void ConsultarCarro_Load(object sender, EventArgs e)
        {
            using (var conexao = new MySqlConnection("server=localhost;uid=root;pwd=root;database=recuperacao_po2_bd"))
            {
                try
                {
                    conexao.Open();
                    string query = "select * from Carro";
                    using (var comando = new MySqlDataAdapter(query, conexao))
                    {
                        DataTable dt = new DataTable();
                        comando.Fill(dt);
                        dataGridView1.DataSource = dt;
                    }
                }
                catch (Exception)
                {

                    throw;
                }
            }
        }

        private void btn_cadastrar_Click(object sender, EventArgs e)
        {
            InformacoesGerais cadastrar = new InformacoesGerais();
            this.Hide();
            cadastrar.Show();
        }

        private void botao_voltar_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            this.Hide();
            menu.Show();
        }
    }
}
