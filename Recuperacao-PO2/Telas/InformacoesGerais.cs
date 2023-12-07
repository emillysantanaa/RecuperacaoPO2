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
    public partial class InformacoesGerais : Form
    {
        public Carro CarroNovo { get; set; } = new Carro();
        public InformacoesGerais()
        {
            InitializeComponent();
            btn_fechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btn_fechar.FlatAppearance.BorderSize = 0;
            btn_fechar.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btn_fechar.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btn_fechar.BackColor = Color.Transparent;
            btn_proximo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btn_proximo.FlatAppearance.BorderSize = 0;
            btn_proximo.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btn_proximo.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btn_proximo.BackColor = Color.Transparent;
            btn_limpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btn_limpar.FlatAppearance.BorderSize = 0;
            btn_limpar.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btn_limpar.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btn_limpar.BackColor = Color.Transparent;
        }

        private void btn_fechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_proximo_Click(object sender, EventArgs e)
        {
            InformacoesGerais informacoesGerais = Application.OpenForms.OfType<InformacoesGerais>().FirstOrDefault();

            informacoesGerais.CarroNovo.Marca = tb_marVeiculo.Text;
            informacoesGerais.CarroNovo.Modelo = tb_modVeiculo.Text;
            informacoesGerais.CarroNovo.AnoDeFabricacao = Convert.ToInt32(tb_anoFabVeiculo.Text);
            informacoesGerais.CarroNovo.AnoDoModelo = Convert.ToInt32(tb_anoModVeiculo.Text);
            switch (true)
            {
                case true when rb_sedan.Checked:
                    informacoesGerais.CarroNovo.TipoDeCarroceria = "Sedan";
                    break;
                case true when rb_hatch.Checked:
                    informacoesGerais.CarroNovo.TipoDeCarroceria = "Hatch";
                    break;
                case true when rb_perua.Checked:
                    informacoesGerais.CarroNovo.TipoDeCarroceria = "Perua";
                    break;
                case true when rb_suv.Checked:
                    informacoesGerais.CarroNovo.TipoDeCarroceria = "SUV";
                    break;
                case true when rb_cupe.Checked:
                    informacoesGerais.CarroNovo.TipoDeCarroceria = "Cupê";
                    break;
                case true when rb_fastback.Checked:
                    informacoesGerais.CarroNovo.TipoDeCarroceria = "Fastback";
                    break;
                case true when rb_targa.Checked:
                    informacoesGerais.CarroNovo.TipoDeCarroceria = "Targa";
                    break;
                case true when rb_roadster.Checked:
                    informacoesGerais.CarroNovo.TipoDeCarroceria = "Roadster";
                    break;
                case true when rb_minivan.Checked:
                    informacoesGerais.CarroNovo.TipoDeCarroceria = "Minivan";
                    break;
                case true when rb_van.Checked:
                    informacoesGerais.CarroNovo.TipoDeCarroceria = "Van";
                    break;
                default:
                    MessageBox.Show("Selecione algum tipo de carroceria!");
                    break;
            }
            informacoesGerais.CarroNovo.NumeroDePortas = Convert.ToInt32(tb_numPortas.Text);
            switch (true)
            {
                case true when rb_branco.Checked:
                    informacoesGerais.CarroNovo.Cor = "Branco";
                    break;
                case true when rb_preto.Checked:
                    informacoesGerais.CarroNovo.Cor = "Preto";
                    break;
                case true when rb_cinza.Checked:
                    informacoesGerais.CarroNovo.Cor = "Cinza";
                    break;
                case true when rb_vermelho.Checked:
                    informacoesGerais.CarroNovo.Cor = "Vermelho";
                    break;
                case true when rb_azul.Checked:
                    informacoesGerais.CarroNovo.Cor = "Azul";
                    break;
                case true when rb_verde.Checked:
                    informacoesGerais.CarroNovo.Cor = "Verde";
                    break;
                case true when rb_amarelo.Checked:
                    informacoesGerais.CarroNovo.Cor = "Amarelo";
                    break;
                case true when rb_prata.Checked:
                    informacoesGerais.CarroNovo.Cor = "Prata";
                    break;
                default:
                    MessageBox.Show("Selecione a cor do veículo!!");
                    break;
            }

            InformacoesTecnicas infTecnicas = new InformacoesTecnicas();
            this.Hide();
            infTecnicas.Show();
        }

        private void tb_anoFabVeiculo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void tb_anoModVeiculo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void tb_numPortas_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void tb_anoFabVeiculo_TextChanged(object sender, EventArgs e)
        {
            if (tb_anoFabVeiculo.Text.Length > 4)
            {
                tb_anoFabVeiculo.Text = tb_anoFabVeiculo.Text.Substring(0, 4);
                tb_anoFabVeiculo.SelectionStart = 4;
                tb_anoFabVeiculo.SelectionLength = 0;
            }
        }
        private void tb_anoModVeiculo_TextChanged(object sender, EventArgs e)
        {
            if (tb_anoModVeiculo.Text.Length > 4)
            {
                tb_anoModVeiculo.Text = tb_anoModVeiculo.Text.Substring(0, 4);
                tb_anoModVeiculo.SelectionStart = 4;
                tb_anoModVeiculo.SelectionLength = 0;
            }
        }
        private void LimparTextBoxs()
        {
            foreach (Control ctr in this.Controls)
            {
                if (ctr is System.Windows.Forms.TextBox)
                {
                    (ctr as System.Windows.Forms.TextBox).Text = string.Empty;
                }
            }
        }

        private void btn_limpar_Click(object sender, EventArgs e)
        {
            LimparTextBoxs();
        }

    }
}
