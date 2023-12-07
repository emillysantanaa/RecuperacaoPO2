namespace Recuperacao_PO2.Telas
{
    partial class InformacoesGerais
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btn_fechar = new Button();
            btn_limpar = new Button();
            btn_proximo = new Button();
            tb_marVeiculo = new TextBox();
            tb_modVeiculo = new TextBox();
            tb_anoFabVeiculo = new TextBox();
            tb_anoModVeiculo = new TextBox();
            tb_numPortas = new TextBox();
            groupBox2 = new GroupBox();
            rb_branco = new RadioButton();
            rb_preto = new RadioButton();
            rb_verde = new RadioButton();
            rb_cinza = new RadioButton();
            rb_amarelo = new RadioButton();
            rb_prata = new RadioButton();
            rb_azul = new RadioButton();
            rb_vermelho = new RadioButton();
            groupBox1 = new GroupBox();
            rb_sedan = new RadioButton();
            rb_hatch = new RadioButton();
            rb_cupe = new RadioButton();
            rb_perua = new RadioButton();
            rb_suv = new RadioButton();
            rb_fastback = new RadioButton();
            rb_targa = new RadioButton();
            rb_roadster = new RadioButton();
            rb_minivan = new RadioButton();
            rb_van = new RadioButton();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // btn_fechar
            // 
            btn_fechar.Cursor = Cursors.Hand;
            btn_fechar.Location = new Point(650, 12);
            btn_fechar.Name = "btn_fechar";
            btn_fechar.Size = new Size(37, 29);
            btn_fechar.TabIndex = 1;
            btn_fechar.UseVisualStyleBackColor = true;
            btn_fechar.Click += btn_fechar_Click;
            // 
            // btn_limpar
            // 
            btn_limpar.Cursor = Cursors.Hand;
            btn_limpar.Location = new Point(534, 452);
            btn_limpar.Name = "btn_limpar";
            btn_limpar.Size = new Size(132, 43);
            btn_limpar.TabIndex = 2;
            btn_limpar.UseVisualStyleBackColor = true;
            btn_limpar.Click += btn_limpar_Click;
            // 
            // btn_proximo
            // 
            btn_proximo.Cursor = Cursors.Hand;
            btn_proximo.Location = new Point(534, 510);
            btn_proximo.Name = "btn_proximo";
            btn_proximo.Size = new Size(132, 43);
            btn_proximo.TabIndex = 3;
            btn_proximo.UseVisualStyleBackColor = true;
            btn_proximo.Click += btn_proximo_Click;
            // 
            // tb_marVeiculo
            // 
            tb_marVeiculo.BorderStyle = BorderStyle.None;
            tb_marVeiculo.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tb_marVeiculo.Location = new Point(21, 133);
            tb_marVeiculo.Name = "tb_marVeiculo";
            tb_marVeiculo.Size = new Size(272, 23);
            tb_marVeiculo.TabIndex = 5;
            // 
            // tb_modVeiculo
            // 
            tb_modVeiculo.BorderStyle = BorderStyle.None;
            tb_modVeiculo.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tb_modVeiculo.Location = new Point(21, 189);
            tb_modVeiculo.Name = "tb_modVeiculo";
            tb_modVeiculo.Size = new Size(272, 23);
            tb_modVeiculo.TabIndex = 6;
            // 
            // tb_anoFabVeiculo
            // 
            tb_anoFabVeiculo.BorderStyle = BorderStyle.None;
            tb_anoFabVeiculo.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tb_anoFabVeiculo.Location = new Point(373, 133);
            tb_anoFabVeiculo.Name = "tb_anoFabVeiculo";
            tb_anoFabVeiculo.Size = new Size(125, 23);
            tb_anoFabVeiculo.TabIndex = 7;
            tb_anoFabVeiculo.TextChanged += tb_anoFabVeiculo_TextChanged;
            tb_anoFabVeiculo.KeyPress += tb_anoFabVeiculo_KeyPress;
            // 
            // tb_anoModVeiculo
            // 
            tb_anoModVeiculo.BorderStyle = BorderStyle.None;
            tb_anoModVeiculo.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tb_anoModVeiculo.Location = new Point(373, 189);
            tb_anoModVeiculo.Name = "tb_anoModVeiculo";
            tb_anoModVeiculo.Size = new Size(125, 23);
            tb_anoModVeiculo.TabIndex = 8;
            tb_anoModVeiculo.TextChanged += tb_anoModVeiculo_TextChanged;
            tb_anoModVeiculo.KeyPress += tb_anoModVeiculo_KeyPress;
            // 
            // tb_numPortas
            // 
            tb_numPortas.BorderStyle = BorderStyle.None;
            tb_numPortas.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tb_numPortas.Location = new Point(21, 244);
            tb_numPortas.Name = "tb_numPortas";
            tb_numPortas.Size = new Size(272, 23);
            tb_numPortas.TabIndex = 9;
            tb_numPortas.KeyPress += tb_numPortas_KeyPress;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.Transparent;
            groupBox2.Controls.Add(rb_branco);
            groupBox2.Controls.Add(rb_preto);
            groupBox2.Controls.Add(rb_verde);
            groupBox2.Controls.Add(rb_cinza);
            groupBox2.Controls.Add(rb_amarelo);
            groupBox2.Controls.Add(rb_prata);
            groupBox2.Controls.Add(rb_azul);
            groupBox2.Controls.Add(rb_vermelho);
            groupBox2.ForeColor = Color.Black;
            groupBox2.Location = new Point(351, 259);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(315, 58);
            groupBox2.TabIndex = 29;
            groupBox2.TabStop = false;
            // 
            // rb_branco
            // 
            rb_branco.AutoSize = true;
            rb_branco.BackColor = Color.Transparent;
            rb_branco.ForeColor = SystemColors.WindowText;
            rb_branco.Location = new Point(6, 11);
            rb_branco.Name = "rb_branco";
            rb_branco.Size = new Size(76, 24);
            rb_branco.TabIndex = 19;
            rb_branco.TabStop = true;
            rb_branco.Text = "Branco";
            rb_branco.UseVisualStyleBackColor = false;
            // 
            // rb_preto
            // 
            rb_preto.AutoSize = true;
            rb_preto.BackColor = Color.Transparent;
            rb_preto.ForeColor = SystemColors.WindowText;
            rb_preto.Location = new Point(88, 11);
            rb_preto.Name = "rb_preto";
            rb_preto.Size = new Size(65, 24);
            rb_preto.TabIndex = 20;
            rb_preto.TabStop = true;
            rb_preto.Text = "Preto";
            rb_preto.UseVisualStyleBackColor = false;
            // 
            // rb_verde
            // 
            rb_verde.AutoSize = true;
            rb_verde.BackColor = Color.Transparent;
            rb_verde.ForeColor = SystemColors.WindowText;
            rb_verde.Location = new Point(241, 32);
            rb_verde.Name = "rb_verde";
            rb_verde.Size = new Size(68, 24);
            rb_verde.TabIndex = 26;
            rb_verde.TabStop = true;
            rb_verde.Text = "Verde";
            rb_verde.UseVisualStyleBackColor = false;
            // 
            // rb_cinza
            // 
            rb_cinza.AutoSize = true;
            rb_cinza.BackColor = Color.Transparent;
            rb_cinza.ForeColor = SystemColors.WindowText;
            rb_cinza.Location = new Point(159, 11);
            rb_cinza.Name = "rb_cinza";
            rb_cinza.Size = new Size(66, 24);
            rb_cinza.TabIndex = 21;
            rb_cinza.TabStop = true;
            rb_cinza.Text = "Cinza";
            rb_cinza.UseVisualStyleBackColor = false;
            // 
            // rb_amarelo
            // 
            rb_amarelo.AutoSize = true;
            rb_amarelo.BackColor = Color.Transparent;
            rb_amarelo.Location = new Point(159, 32);
            rb_amarelo.Name = "rb_amarelo";
            rb_amarelo.Size = new Size(87, 24);
            rb_amarelo.TabIndex = 25;
            rb_amarelo.TabStop = true;
            rb_amarelo.Text = "Amarelo";
            rb_amarelo.UseVisualStyleBackColor = false;
            // 
            // rb_prata
            // 
            rb_prata.AutoSize = true;
            rb_prata.BackColor = Color.Transparent;
            rb_prata.ForeColor = SystemColors.WindowText;
            rb_prata.Location = new Point(231, 11);
            rb_prata.Name = "rb_prata";
            rb_prata.Size = new Size(64, 24);
            rb_prata.TabIndex = 22;
            rb_prata.TabStop = true;
            rb_prata.Text = "Prata";
            rb_prata.UseVisualStyleBackColor = false;
            // 
            // rb_azul
            // 
            rb_azul.AutoSize = true;
            rb_azul.BackColor = Color.Transparent;
            rb_azul.ForeColor = SystemColors.WindowText;
            rb_azul.Location = new Point(94, 32);
            rb_azul.Name = "rb_azul";
            rb_azul.Size = new Size(59, 24);
            rb_azul.TabIndex = 24;
            rb_azul.TabStop = true;
            rb_azul.Text = "Azul";
            rb_azul.UseVisualStyleBackColor = false;
            // 
            // rb_vermelho
            // 
            rb_vermelho.AutoSize = true;
            rb_vermelho.BackColor = Color.Transparent;
            rb_vermelho.ForeColor = SystemColors.WindowText;
            rb_vermelho.Location = new Point(6, 32);
            rb_vermelho.Name = "rb_vermelho";
            rb_vermelho.Size = new Size(93, 24);
            rb_vermelho.TabIndex = 23;
            rb_vermelho.TabStop = true;
            rb_vermelho.Text = "Vermelho";
            rb_vermelho.UseVisualStyleBackColor = false;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Transparent;
            groupBox1.Controls.Add(rb_sedan);
            groupBox1.Controls.Add(rb_hatch);
            groupBox1.Controls.Add(rb_cupe);
            groupBox1.Controls.Add(rb_perua);
            groupBox1.Controls.Add(rb_suv);
            groupBox1.Controls.Add(rb_fastback);
            groupBox1.Controls.Add(rb_targa);
            groupBox1.Controls.Add(rb_roadster);
            groupBox1.Controls.Add(rb_minivan);
            groupBox1.Controls.Add(rb_van);
            groupBox1.ForeColor = Color.Transparent;
            groupBox1.Location = new Point(14, 299);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(315, 77);
            groupBox1.TabIndex = 30;
            groupBox1.TabStop = false;
            groupBox1.Text = "s";
            // 
            // rb_sedan
            // 
            rb_sedan.AutoSize = true;
            rb_sedan.BackColor = Color.Transparent;
            rb_sedan.ForeColor = SystemColors.WindowText;
            rb_sedan.Location = new Point(3, 11);
            rb_sedan.Name = "rb_sedan";
            rb_sedan.Size = new Size(71, 24);
            rb_sedan.TabIndex = 9;
            rb_sedan.TabStop = true;
            rb_sedan.Text = "Sedan";
            rb_sedan.UseVisualStyleBackColor = false;
            // 
            // rb_hatch
            // 
            rb_hatch.AutoSize = true;
            rb_hatch.BackColor = Color.Transparent;
            rb_hatch.ForeColor = SystemColors.WindowText;
            rb_hatch.Location = new Point(80, 11);
            rb_hatch.Name = "rb_hatch";
            rb_hatch.Size = new Size(69, 24);
            rb_hatch.TabIndex = 10;
            rb_hatch.TabStop = true;
            rb_hatch.Text = "Hatch";
            rb_hatch.UseVisualStyleBackColor = false;
            // 
            // rb_cupe
            // 
            rb_cupe.AutoSize = true;
            rb_cupe.BackColor = Color.Transparent;
            rb_cupe.ForeColor = SystemColors.WindowText;
            rb_cupe.Location = new Point(3, 31);
            rb_cupe.Name = "rb_cupe";
            rb_cupe.Size = new Size(64, 24);
            rb_cupe.TabIndex = 13;
            rb_cupe.TabStop = true;
            rb_cupe.Text = "Cupê";
            rb_cupe.UseVisualStyleBackColor = false;
            // 
            // rb_perua
            // 
            rb_perua.AutoSize = true;
            rb_perua.BackColor = Color.Transparent;
            rb_perua.ForeColor = SystemColors.WindowText;
            rb_perua.Location = new Point(155, 11);
            rb_perua.Name = "rb_perua";
            rb_perua.Size = new Size(66, 24);
            rb_perua.TabIndex = 11;
            rb_perua.TabStop = true;
            rb_perua.Text = "Perua";
            rb_perua.UseVisualStyleBackColor = false;
            // 
            // rb_suv
            // 
            rb_suv.AutoSize = true;
            rb_suv.BackColor = Color.Transparent;
            rb_suv.ForeColor = SystemColors.WindowText;
            rb_suv.Location = new Point(227, 11);
            rb_suv.Name = "rb_suv";
            rb_suv.Size = new Size(57, 24);
            rb_suv.TabIndex = 12;
            rb_suv.TabStop = true;
            rb_suv.Text = "SUV";
            rb_suv.UseVisualStyleBackColor = false;
            // 
            // rb_fastback
            // 
            rb_fastback.AutoSize = true;
            rb_fastback.BackColor = Color.Transparent;
            rb_fastback.ForeColor = SystemColors.WindowText;
            rb_fastback.Location = new Point(80, 31);
            rb_fastback.Name = "rb_fastback";
            rb_fastback.Size = new Size(86, 24);
            rb_fastback.TabIndex = 14;
            rb_fastback.TabStop = true;
            rb_fastback.Text = "Fastback";
            rb_fastback.UseVisualStyleBackColor = false;
            // 
            // rb_targa
            // 
            rb_targa.AutoSize = true;
            rb_targa.BackColor = Color.Transparent;
            rb_targa.ForeColor = SystemColors.WindowText;
            rb_targa.Location = new Point(172, 31);
            rb_targa.Name = "rb_targa";
            rb_targa.Size = new Size(66, 24);
            rb_targa.TabIndex = 15;
            rb_targa.TabStop = true;
            rb_targa.Text = "Targa";
            rb_targa.UseVisualStyleBackColor = false;
            // 
            // rb_roadster
            // 
            rb_roadster.AutoSize = true;
            rb_roadster.BackColor = Color.Transparent;
            rb_roadster.ForeColor = SystemColors.WindowText;
            rb_roadster.Location = new Point(3, 51);
            rb_roadster.Name = "rb_roadster";
            rb_roadster.Size = new Size(89, 24);
            rb_roadster.TabIndex = 16;
            rb_roadster.TabStop = true;
            rb_roadster.Text = "Roadster";
            rb_roadster.UseVisualStyleBackColor = false;
            // 
            // rb_minivan
            // 
            rb_minivan.AutoSize = true;
            rb_minivan.BackColor = Color.Transparent;
            rb_minivan.ForeColor = SystemColors.WindowText;
            rb_minivan.Location = new Point(98, 51);
            rb_minivan.Name = "rb_minivan";
            rb_minivan.Size = new Size(82, 24);
            rb_minivan.TabIndex = 17;
            rb_minivan.TabStop = true;
            rb_minivan.Text = "Minivan";
            rb_minivan.UseVisualStyleBackColor = false;
            // 
            // rb_van
            // 
            rb_van.AutoSize = true;
            rb_van.BackColor = Color.Transparent;
            rb_van.ForeColor = SystemColors.WindowText;
            rb_van.Location = new Point(186, 51);
            rb_van.Name = "rb_van";
            rb_van.Size = new Size(54, 24);
            rb_van.TabIndex = 18;
            rb_van.TabStop = true;
            rb_van.Text = "Van";
            rb_van.UseVisualStyleBackColor = false;
            // 
            // InformacoesGerais
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.InfoGerais;
            ClientSize = new Size(690, 580);
            Controls.Add(groupBox1);
            Controls.Add(groupBox2);
            Controls.Add(tb_numPortas);
            Controls.Add(tb_anoModVeiculo);
            Controls.Add(tb_anoFabVeiculo);
            Controls.Add(tb_modVeiculo);
            Controls.Add(tb_marVeiculo);
            Controls.Add(btn_proximo);
            Controls.Add(btn_limpar);
            Controls.Add(btn_fechar);
            FormBorderStyle = FormBorderStyle.None;
            Name = "InformacoesGerais";
            Text = "InformacoesGerais";
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_fechar;
        private Button btn_limpar;
        private Button btn_proximo;
        private TextBox tb_marVeiculo;
        private TextBox tb_modVeiculo;
        private TextBox tb_anoFabVeiculo;
        private TextBox tb_anoModVeiculo;
        private TextBox tb_numPortas;
        private GroupBox groupBox2;
        private RadioButton rb_branco;
        private RadioButton rb_preto;
        private RadioButton rb_verde;
        private RadioButton rb_cinza;
        private RadioButton rb_amarelo;
        private RadioButton rb_prata;
        private RadioButton rb_azul;
        private RadioButton rb_vermelho;
        private GroupBox groupBox1;
        private RadioButton rb_sedan;
        private RadioButton rb_hatch;
        private RadioButton rb_cupe;
        private RadioButton rb_perua;
        private RadioButton rb_suv;
        private RadioButton rb_fastback;
        private RadioButton rb_targa;
        private RadioButton rb_roadster;
        private RadioButton rb_minivan;
        private RadioButton rb_van;
    }
}