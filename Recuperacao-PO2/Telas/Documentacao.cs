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
    public partial class Documentacao : Form
    {
        public Documentacao()
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
            InformacoesGerais Documentacao = Application.OpenForms.OfType<InformacoesGerais>().FirstOrDefault();

            Documentacao.CarroNovo.Renavam = tb_renavam.Text;
            Documentacao.CarroNovo.DataDeLicenciamento = Convert.ToDateTime(dtp_dataDeLicenciamento.Text);
            Documentacao.CarroNovo.DataDaUltimaInspecaoVeicular = Convert.ToDateTime(dtp_dataDaUltimaInspecaoVeicular.Text);
            Documentacao.CarroNovo.NumeroDaPlaca = tb_numeroDaPlaca.Text;

            if (VerificarCampos())
            {
                MessageBox.Show("Preencha todos os campos!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                Inserir();
            }
        }
        private void tb_renavam_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetterOrDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void tb_renavam_TextChanged(object sender, EventArgs e)
        {
            if (tb_renavam.Text.Length == 9 || tb_renavam.Text.Length == 11)
            {
                tb_renavam.BackColor = Color.LightGreen;
            }
            else
            {
                tb_renavam.BackColor = Color.LightSalmon;
            }
        }

        void Inserir()
        {
            InformacoesGerais carro = Application.OpenForms.OfType<InformacoesGerais>().FirstOrDefault();

            if (carro != null)
            {
                string marca = carro.CarroNovo.Marca;
                string modelo = carro.CarroNovo.Modelo;
                int anoDeFabricacao = carro.CarroNovo.AnoDeFabricacao;
                int anoDoModelo = carro.CarroNovo.AnoDoModelo;
                string tipoDeCarroceria = carro.CarroNovo.TipoDeCarroceria;
                int numeroPortas = carro.CarroNovo.NumeroDePortas;
                string cor = carro.CarroNovo.Cor;
                string numeroDoChassi = carro.CarroNovo.NumeroDoChassi;
                string numeroDoMotor = carro.CarroNovo.NumeroDoMotor;
                string tipoDeCombustivel = carro.CarroNovo.TipoDeCombustivel;
                double capacidadeDoTanque = carro.CarroNovo.CapacidadeDoTanque;
                double potenciaDoMotor = carro.CarroNovo.PotenciaDoMotor;
                string tipoDeTransmissao = carro.CarroNovo.TipoDeTransmissao;
                string tipoDeTracao = carro.CarroNovo.TipoDeTracao;
                string renavam = carro.CarroNovo.Renavam;
                string numeroDaPlaca = carro.CarroNovo.NumeroDaPlaca;
                DateTime dataDeLicenciamento = carro.CarroNovo.DataDeLicenciamento;
                DateTime dataDaUltimaInspecaoVeicular = carro.CarroNovo.DataDaUltimaInspecaoVeicular;

                try
                {
                    Conexao conexao = new Conexao();

                    var comando = conexao.Comando($"INSERT INTO carro (id_car, marca_car, modelo_car, anoDeFabricacao_car, anoDoModelo_car, numeroDePortas_car, tipoDeCarroceria_car," +
                        $" cor_car, numeroDoChassi_car, numeroDoMotor_car, tipoDeCombustivel_car, capacidadeDoTanque_car, potenciaDoMotor_car, tipoDeTransmissao_car," +
                        $" tipoDeTracao_car, renavam_car, numeroDaPlaca_car, dataDeLicenciamento_car, dataDaUltimaInspecaoVeicular_car)" +
                        $" VALUES (null, @marca, @modelo, @anoFabricacao, @anoModelo, @numeroPortas, @tipoDeCarroceria, @cor, @numeroDochassi, @numeroDoMotor," +
                        $"@tipoDeCombustivel, @capacidadeDoTanque, @potenciaDoMotor, @tipoDeTransmissao, @tipoDeTracao, @renavam, @numeroDaPlaca, " +
                        $"@dataDeLicenciamento, @dataDaUltimaInspecaoVeicular)");

                    comando.Parameters.AddWithValue("@marca", marca);
                    comando.Parameters.AddWithValue("@modelo", modelo);
                    comando.Parameters.AddWithValue("@anoFabricacao", anoDeFabricacao);
                    comando.Parameters.AddWithValue("@anoModelo", anoDoModelo);
                    comando.Parameters.AddWithValue("@numeroPortas", numeroPortas);
                    comando.Parameters.AddWithValue("@tipoDeCarroceria", tipoDeCarroceria);
                    comando.Parameters.AddWithValue("@cor", cor);
                    comando.Parameters.AddWithValue("@numeroDochassi", numeroDoChassi);
                    comando.Parameters.AddWithValue("@numeroDoMotor", numeroDoMotor);
                    comando.Parameters.AddWithValue("@tipoDeCombustivel", tipoDeCombustivel);
                    comando.Parameters.AddWithValue("@capacidadeDoTanque", capacidadeDoTanque);
                    comando.Parameters.AddWithValue("@potenciaDoMotor", potenciaDoMotor);
                    comando.Parameters.AddWithValue("@tipoDeTransmissao", tipoDeTransmissao);
                    comando.Parameters.AddWithValue("@tipoDeTracao", tipoDeTracao);
                    comando.Parameters.AddWithValue("@renavam", renavam);
                    comando.Parameters.AddWithValue("@numeroDaPlaca", numeroDaPlaca);
                    comando.Parameters.AddWithValue("@dataDeLicenciamento", dataDeLicenciamento);
                    comando.Parameters.AddWithValue("@dataDaUltimaInspecaoVeicular", dataDaUltimaInspecaoVeicular);

                    var resultado = comando.ExecuteNonQuery();

                    if (resultado == 1)
                    {
                        MessageBox.Show("Carro cadastrado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LimparTextBoxs();
                    }
                    else
                    {
                        MessageBox.Show("Erro ao cadastrar carro!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    LimparTextBoxs();
                    Menu menu = new Menu();
                    menu.Show();
                    this.Close();
                }
                catch (Exception e)
                {
                    MessageBox.Show("Erro ao cadastrar carro!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    throw e;
                }
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
        private bool VerificarCampos()
        {
            foreach (Control ctr in this.Controls)
            {
                if (ctr is System.Windows.Forms.TextBox || ctr is System.Windows.Forms.MaskedTextBox)
                {
                    var text = ctr.Text.Replace(",", "").Replace("-", "").Trim();

                    if (text == "")
                    {
                        return true;
                    }
                }
            }
            return false;
        }

    }
}
