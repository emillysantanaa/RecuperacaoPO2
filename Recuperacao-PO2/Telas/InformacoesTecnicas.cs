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
    public partial class InformacoesTecnicas : Form
    {
        public InformacoesTecnicas()
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
            InformacoesGerais informacoesTecnicas = Application.OpenForms.OfType<InformacoesGerais>().FirstOrDefault();

            informacoesTecnicas.CarroNovo.NumeroDoChassi = tb_numeroDoChassi.Text;
            informacoesTecnicas.CarroNovo.NumeroDoMotor = tb_numeroDoMotor.Text;

            switch (true)
            {
                case true when rb_gasolina.Checked:
                    informacoesTecnicas.CarroNovo.TipoDeCombustivel = "Gasolina";
                    break;
                case true when rb_diesel.Checked:
                    informacoesTecnicas.CarroNovo.TipoDeCombustivel = "Diesel";
                    break;
                case true when rb_etanol.Checked:
                    informacoesTecnicas.CarroNovo.TipoDeCombustivel = "Etanol";
                    break;
                case true when rb_biodiesel.Checked:
                    informacoesTecnicas.CarroNovo.TipoDeCombustivel = "Biodiesel";
                    break;
                case true when rb_gnv.Checked:
                    informacoesTecnicas.CarroNovo.TipoDeCombustivel = "GNV";
                    break;
                case true when rb_eletricidade.Checked:
                    informacoesTecnicas.CarroNovo.TipoDeCombustivel = "Elétrico";
                    break;
                case true when rb_hidrogenio.Checked:
                    informacoesTecnicas.CarroNovo.TipoDeCombustivel = "Hidrogênio";
                    break;
                case true when rb_glp.Checked:
                    informacoesTecnicas.CarroNovo.TipoDeCombustivel = "GLP";
                    break;
                default:
                    MessageBox.Show("Selecione algum tipo de combustível!!");
                    break;
            }

            informacoesTecnicas.CarroNovo.CapacidadeDoTanque = Convert.ToDouble(tb_capacidadeDoTanque.Text);

            switch (true)
            {
                case true when rb_1_0.Checked:
                    informacoesTecnicas.CarroNovo.PotenciaDoMotor = 1;
                    break;
                case true when rb_1_3.Checked:
                    informacoesTecnicas.CarroNovo.PotenciaDoMotor = 1.3;
                    break;
                case true when rb_1_4.Checked:
                    informacoesTecnicas.CarroNovo.PotenciaDoMotor = 1.4;
                    break;
                case true when rb_2_0.Checked:
                    informacoesTecnicas.CarroNovo.PotenciaDoMotor = 2.0;
                    break;
                case true when rb_2_2.Checked:
                    informacoesTecnicas.CarroNovo.PotenciaDoMotor = 2.2;
                    break;
                case true when rb_2_8.Checked:
                    informacoesTecnicas.CarroNovo.PotenciaDoMotor = 2.8;
                    break;
                case true when rb_3_2.Checked:
                    informacoesTecnicas.CarroNovo.PotenciaDoMotor = 3.2;
                    break;
                default:
                    MessageBox.Show("Selecione a potência do motor!!");
                    break;
            }

            switch (true)
            {
                case true when rb_manual.Checked:
                    informacoesTecnicas.CarroNovo.TipoDeTransmissao = "Manual";
                    break;
                case true when rb_automatica.Checked:
                    informacoesTecnicas.CarroNovo.TipoDeTransmissao = "Automática";
                    break;
                default:
                    MessageBox.Show("Selecione algum tipo de transmissão!!");
                    break;
            }

            switch (true)
            {
                case true when rb_dianteira.Checked:
                    informacoesTecnicas.CarroNovo.TipoDeTracao = "Dianteira";
                    break;
                case true when rb_traseira.Checked:
                    informacoesTecnicas.CarroNovo.TipoDeTracao = "Traseira";
                    break;
                case true when rb_integral.Checked:
                    informacoesTecnicas.CarroNovo.TipoDeTracao = "Integral";
                    break;
                case true when rb_4x4.Checked:
                    informacoesTecnicas.CarroNovo.TipoDeTracao = "4x4";
                    break;
                default:
                    MessageBox.Show("Selecione o tipo de tração!!");
                    break;
            }

            Documentacao documentacao = new Documentacao();
            this.Hide();
            documentacao.Show();
        }

        private void tb_numeroDoChassi_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetterOrDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void tb_numeroDoMotor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetterOrDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void tb_capacidadeDoTanque_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void tb_numeroDoChassi_TextChanged(object sender, EventArgs e)
        {
            if (tb_numeroDoChassi.Text.Length == 17)
            {
                tb_numeroDoChassi.BackColor = Color.LightGreen;
            }
            else
            {
                tb_numeroDoChassi.BackColor = Color.LightSalmon;
            }
        }

        private void tb_numeroDoMotor_TextChanged(object sender, EventArgs e)
        {
            if (tb_numeroDoMotor.Text.Length >= 6 && tb_numeroDoMotor.Text.Length <= 10)
            {
                tb_numeroDoMotor.BackColor = Color.LightGreen;
            }
            else
            {
                tb_numeroDoMotor.BackColor = Color.LightSalmon;
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
