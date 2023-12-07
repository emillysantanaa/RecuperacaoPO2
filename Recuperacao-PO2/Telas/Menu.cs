using Recuperacao_PO2.Telas;
using System;

namespace Recuperacao_PO2
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
            btn_fechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btn_fechar.FlatAppearance.BorderSize = 0;
            btn_fechar.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btn_fechar.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btn_fechar.BackColor = Color.Transparent;
            btn_consultar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btn_consultar.FlatAppearance.BorderSize = 0;
            btn_consultar.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btn_consultar.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btn_consultar.BackColor = Color.Transparent;
            btn_cadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btn_cadastrar.FlatAppearance.BorderSize = 0;
            btn_cadastrar.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btn_cadastrar.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btn_cadastrar.BackColor = Color.Transparent;
        }
        private void btn_fechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btn_cadastrar_Click_1(object sender, EventArgs e)
        {
            InformacoesGerais cadastrar = new InformacoesGerais();
            this.Hide();
            cadastrar.Show();
        }

        private void btn_consultar_Click_1(object sender, EventArgs e)
        {
            ConsultarCarro consultar = new ConsultarCarro();
            this.Hide();
            consultar.Show();
        }
    }
}
