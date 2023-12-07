namespace Recuperacao_PO2.Telas
{
    partial class InformacoesTecnicas
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
            tb_numeroDoChassi = new TextBox();
            tb_numeroDoMotor = new TextBox();
            tb_capacidadeDoTanque = new TextBox();
            groupBox1 = new GroupBox();
            rb_gasolina = new RadioButton();
            rb_diesel = new RadioButton();
            rb_etanol = new RadioButton();
            rb_biodiesel = new RadioButton();
            rb_gnv = new RadioButton();
            rb_eletricidade = new RadioButton();
            rb_hidrogenio = new RadioButton();
            rb_glp = new RadioButton();
            groupBox4 = new GroupBox();
            rb_dianteira = new RadioButton();
            rb_traseira = new RadioButton();
            rb_integral = new RadioButton();
            rb_4x4 = new RadioButton();
            groupBox2 = new GroupBox();
            rb_1_0 = new RadioButton();
            rb_1_3 = new RadioButton();
            rb_1_4 = new RadioButton();
            rb_2_0 = new RadioButton();
            rb_2_2 = new RadioButton();
            rb_2_8 = new RadioButton();
            rb_3_2 = new RadioButton();
            groupBox3 = new GroupBox();
            rb_automatica = new RadioButton();
            rb_manual = new RadioButton();
            groupBox1.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // btn_fechar
            // 
            btn_fechar.Cursor = Cursors.Hand;
            btn_fechar.Location = new Point(650, 12);
            btn_fechar.Name = "btn_fechar";
            btn_fechar.Size = new Size(37, 29);
            btn_fechar.TabIndex = 2;
            btn_fechar.UseVisualStyleBackColor = true;
            btn_fechar.Click += btn_fechar_Click;
            // 
            // btn_limpar
            // 
            btn_limpar.Cursor = Cursors.Hand;
            btn_limpar.Location = new Point(542, 451);
            btn_limpar.Name = "btn_limpar";
            btn_limpar.Size = new Size(132, 43);
            btn_limpar.TabIndex = 3;
            btn_limpar.UseVisualStyleBackColor = true;
            btn_limpar.Click += btn_limpar_Click;
            // 
            // btn_proximo
            // 
            btn_proximo.Cursor = Cursors.Hand;
            btn_proximo.Location = new Point(542, 515);
            btn_proximo.Name = "btn_proximo";
            btn_proximo.Size = new Size(132, 43);
            btn_proximo.TabIndex = 4;
            btn_proximo.UseVisualStyleBackColor = true;
            btn_proximo.Click += btn_proximo_Click;
            // 
            // tb_numeroDoChassi
            // 
            tb_numeroDoChassi.BorderStyle = BorderStyle.None;
            tb_numeroDoChassi.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tb_numeroDoChassi.Location = new Point(17, 95);
            tb_numeroDoChassi.Name = "tb_numeroDoChassi";
            tb_numeroDoChassi.Size = new Size(272, 23);
            tb_numeroDoChassi.TabIndex = 6;
            tb_numeroDoChassi.TextChanged += tb_numeroDoChassi_TextChanged;
            tb_numeroDoChassi.KeyPress += tb_numeroDoChassi_KeyPress;
            // 
            // tb_numeroDoMotor
            // 
            tb_numeroDoMotor.BorderStyle = BorderStyle.None;
            tb_numeroDoMotor.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tb_numeroDoMotor.Location = new Point(17, 161);
            tb_numeroDoMotor.Name = "tb_numeroDoMotor";
            tb_numeroDoMotor.Size = new Size(272, 23);
            tb_numeroDoMotor.TabIndex = 7;
            tb_numeroDoMotor.TextChanged += tb_numeroDoMotor_TextChanged;
            tb_numeroDoMotor.KeyPress += tb_numeroDoMotor_KeyPress;
            // 
            // tb_capacidadeDoTanque
            // 
            tb_capacidadeDoTanque.BorderStyle = BorderStyle.None;
            tb_capacidadeDoTanque.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tb_capacidadeDoTanque.Location = new Point(17, 228);
            tb_capacidadeDoTanque.Name = "tb_capacidadeDoTanque";
            tb_capacidadeDoTanque.Size = new Size(272, 23);
            tb_capacidadeDoTanque.TabIndex = 8;
            tb_capacidadeDoTanque.KeyPress += tb_capacidadeDoTanque_KeyPress;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Transparent;
            groupBox1.Controls.Add(rb_gasolina);
            groupBox1.Controls.Add(rb_diesel);
            groupBox1.Controls.Add(rb_etanol);
            groupBox1.Controls.Add(rb_biodiesel);
            groupBox1.Controls.Add(rb_gnv);
            groupBox1.Controls.Add(rb_eletricidade);
            groupBox1.Controls.Add(rb_hidrogenio);
            groupBox1.Controls.Add(rb_glp);
            groupBox1.ForeColor = Color.Transparent;
            groupBox1.Location = new Point(12, 306);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(348, 72);
            groupBox1.TabIndex = 32;
            groupBox1.TabStop = false;
            // 
            // rb_gasolina
            // 
            rb_gasolina.AutoSize = true;
            rb_gasolina.BackColor = Color.Transparent;
            rb_gasolina.ForeColor = SystemColors.WindowText;
            rb_gasolina.Location = new Point(6, 13);
            rb_gasolina.Name = "rb_gasolina";
            rb_gasolina.Size = new Size(87, 24);
            rb_gasolina.TabIndex = 10;
            rb_gasolina.TabStop = true;
            rb_gasolina.Text = "Gasolina";
            rb_gasolina.UseVisualStyleBackColor = false;
            // 
            // rb_diesel
            // 
            rb_diesel.AutoSize = true;
            rb_diesel.BackColor = Color.Transparent;
            rb_diesel.ForeColor = SystemColors.WindowText;
            rb_diesel.Location = new Point(99, 13);
            rb_diesel.Name = "rb_diesel";
            rb_diesel.Size = new Size(71, 24);
            rb_diesel.TabIndex = 11;
            rb_diesel.TabStop = true;
            rb_diesel.Text = "Diesel";
            rb_diesel.UseVisualStyleBackColor = false;
            // 
            // rb_etanol
            // 
            rb_etanol.AutoSize = true;
            rb_etanol.BackColor = Color.Transparent;
            rb_etanol.ForeColor = SystemColors.WindowText;
            rb_etanol.Location = new Point(176, 13);
            rb_etanol.Name = "rb_etanol";
            rb_etanol.Size = new Size(72, 24);
            rb_etanol.TabIndex = 12;
            rb_etanol.TabStop = true;
            rb_etanol.Text = "Etanol";
            rb_etanol.UseVisualStyleBackColor = false;
            // 
            // rb_biodiesel
            // 
            rb_biodiesel.AutoSize = true;
            rb_biodiesel.BackColor = Color.Transparent;
            rb_biodiesel.ForeColor = SystemColors.WindowText;
            rb_biodiesel.Location = new Point(251, 12);
            rb_biodiesel.Name = "rb_biodiesel";
            rb_biodiesel.Size = new Size(91, 24);
            rb_biodiesel.TabIndex = 13;
            rb_biodiesel.TabStop = true;
            rb_biodiesel.Text = "Biodiesel";
            rb_biodiesel.UseVisualStyleBackColor = false;
            // 
            // rb_gnv
            // 
            rb_gnv.AutoSize = true;
            rb_gnv.BackColor = Color.Transparent;
            rb_gnv.ForeColor = SystemColors.WindowText;
            rb_gnv.Location = new Point(6, 43);
            rb_gnv.Name = "rb_gnv";
            rb_gnv.Size = new Size(60, 24);
            rb_gnv.TabIndex = 14;
            rb_gnv.TabStop = true;
            rb_gnv.Text = "GNV";
            rb_gnv.UseVisualStyleBackColor = false;
            // 
            // rb_eletricidade
            // 
            rb_eletricidade.AutoSize = true;
            rb_eletricidade.BackColor = Color.Transparent;
            rb_eletricidade.ForeColor = SystemColors.WindowText;
            rb_eletricidade.Location = new Point(72, 43);
            rb_eletricidade.Name = "rb_eletricidade";
            rb_eletricidade.Size = new Size(109, 24);
            rb_eletricidade.TabIndex = 15;
            rb_eletricidade.TabStop = true;
            rb_eletricidade.Text = "Eletricidade";
            rb_eletricidade.UseVisualStyleBackColor = false;
            // 
            // rb_hidrogenio
            // 
            rb_hidrogenio.AutoSize = true;
            rb_hidrogenio.BackColor = Color.Transparent;
            rb_hidrogenio.ForeColor = SystemColors.WindowText;
            rb_hidrogenio.Location = new Point(187, 42);
            rb_hidrogenio.Name = "rb_hidrogenio";
            rb_hidrogenio.Size = new Size(106, 24);
            rb_hidrogenio.TabIndex = 16;
            rb_hidrogenio.TabStop = true;
            rb_hidrogenio.Text = "Hidrogênio";
            rb_hidrogenio.UseVisualStyleBackColor = false;
            // 
            // rb_glp
            // 
            rb_glp.AutoSize = true;
            rb_glp.BackColor = Color.Transparent;
            rb_glp.ForeColor = SystemColors.WindowText;
            rb_glp.Location = new Point(293, 42);
            rb_glp.Name = "rb_glp";
            rb_glp.Size = new Size(55, 24);
            rb_glp.TabIndex = 17;
            rb_glp.TabStop = true;
            rb_glp.Text = "GLP";
            rb_glp.UseVisualStyleBackColor = false;
            // 
            // groupBox4
            // 
            groupBox4.BackColor = Color.Transparent;
            groupBox4.Controls.Add(rb_dianteira);
            groupBox4.Controls.Add(rb_traseira);
            groupBox4.Controls.Add(rb_integral);
            groupBox4.Controls.Add(rb_4x4);
            groupBox4.ForeColor = Color.Transparent;
            groupBox4.Location = new Point(375, 95);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(250, 72);
            groupBox4.TabIndex = 35;
            groupBox4.TabStop = false;
            // 
            // rb_dianteira
            // 
            rb_dianteira.AutoSize = true;
            rb_dianteira.BackColor = Color.Transparent;
            rb_dianteira.ForeColor = SystemColors.WindowText;
            rb_dianteira.Location = new Point(4, 10);
            rb_dianteira.Name = "rb_dianteira";
            rb_dianteira.Size = new Size(91, 24);
            rb_dianteira.TabIndex = 27;
            rb_dianteira.TabStop = true;
            rb_dianteira.Text = "Dianteira";
            rb_dianteira.UseVisualStyleBackColor = false;
            // 
            // rb_traseira
            // 
            rb_traseira.AutoSize = true;
            rb_traseira.BackColor = Color.Transparent;
            rb_traseira.ForeColor = SystemColors.WindowText;
            rb_traseira.Location = new Point(99, 10);
            rb_traseira.Name = "rb_traseira";
            rb_traseira.Size = new Size(81, 24);
            rb_traseira.TabIndex = 28;
            rb_traseira.TabStop = true;
            rb_traseira.Text = "Traseira";
            rb_traseira.UseVisualStyleBackColor = false;
            // 
            // rb_integral
            // 
            rb_integral.AutoSize = true;
            rb_integral.BackColor = Color.Transparent;
            rb_integral.ForeColor = SystemColors.WindowText;
            rb_integral.Location = new Point(4, 40);
            rb_integral.Name = "rb_integral";
            rb_integral.Size = new Size(81, 24);
            rb_integral.TabIndex = 29;
            rb_integral.TabStop = true;
            rb_integral.Text = "Integral";
            rb_integral.UseVisualStyleBackColor = false;
            // 
            // rb_4x4
            // 
            rb_4x4.AutoSize = true;
            rb_4x4.BackColor = Color.Transparent;
            rb_4x4.ForeColor = SystemColors.WindowText;
            rb_4x4.Location = new Point(99, 40);
            rb_4x4.Name = "rb_4x4";
            rb_4x4.Size = new Size(55, 24);
            rb_4x4.TabIndex = 30;
            rb_4x4.TabStop = true;
            rb_4x4.Text = "4X4";
            rb_4x4.UseVisualStyleBackColor = false;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.Transparent;
            groupBox2.Controls.Add(rb_1_0);
            groupBox2.Controls.Add(rb_1_3);
            groupBox2.Controls.Add(rb_1_4);
            groupBox2.Controls.Add(rb_2_0);
            groupBox2.Controls.Add(rb_2_2);
            groupBox2.Controls.Add(rb_2_8);
            groupBox2.Controls.Add(rb_3_2);
            groupBox2.ForeColor = Color.Transparent;
            groupBox2.Location = new Point(17, 401);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(348, 69);
            groupBox2.TabIndex = 36;
            groupBox2.TabStop = false;
            // 
            // rb_1_0
            // 
            rb_1_0.AutoSize = true;
            rb_1_0.BackColor = Color.Transparent;
            rb_1_0.ForeColor = SystemColors.WindowText;
            rb_1_0.Location = new Point(3, 1);
            rb_1_0.Name = "rb_1_0";
            rb_1_0.Size = new Size(49, 24);
            rb_1_0.TabIndex = 18;
            rb_1_0.TabStop = true;
            rb_1_0.Text = "1.0";
            rb_1_0.UseVisualStyleBackColor = false;
            // 
            // rb_1_3
            // 
            rb_1_3.AutoSize = true;
            rb_1_3.BackColor = Color.Transparent;
            rb_1_3.ForeColor = SystemColors.WindowText;
            rb_1_3.Location = new Point(58, 1);
            rb_1_3.Name = "rb_1_3";
            rb_1_3.Size = new Size(49, 24);
            rb_1_3.TabIndex = 19;
            rb_1_3.TabStop = true;
            rb_1_3.Text = "1.3";
            rb_1_3.UseVisualStyleBackColor = false;
            // 
            // rb_1_4
            // 
            rb_1_4.AutoSize = true;
            rb_1_4.BackColor = Color.Transparent;
            rb_1_4.ForeColor = SystemColors.WindowText;
            rb_1_4.Location = new Point(113, 1);
            rb_1_4.Name = "rb_1_4";
            rb_1_4.Size = new Size(49, 24);
            rb_1_4.TabIndex = 20;
            rb_1_4.TabStop = true;
            rb_1_4.Text = "1.4";
            rb_1_4.UseVisualStyleBackColor = false;
            // 
            // rb_2_0
            // 
            rb_2_0.AutoSize = true;
            rb_2_0.BackColor = Color.Transparent;
            rb_2_0.ForeColor = SystemColors.WindowText;
            rb_2_0.Location = new Point(168, 1);
            rb_2_0.Name = "rb_2_0";
            rb_2_0.Size = new Size(49, 24);
            rb_2_0.TabIndex = 21;
            rb_2_0.TabStop = true;
            rb_2_0.Text = "2.0";
            rb_2_0.UseVisualStyleBackColor = false;
            // 
            // rb_2_2
            // 
            rb_2_2.AutoSize = true;
            rb_2_2.BackColor = Color.Transparent;
            rb_2_2.ForeColor = SystemColors.WindowText;
            rb_2_2.Location = new Point(113, 31);
            rb_2_2.Name = "rb_2_2";
            rb_2_2.Size = new Size(49, 24);
            rb_2_2.TabIndex = 22;
            rb_2_2.TabStop = true;
            rb_2_2.Text = "2.2";
            rb_2_2.UseVisualStyleBackColor = false;
            // 
            // rb_2_8
            // 
            rb_2_8.AutoSize = true;
            rb_2_8.BackColor = Color.Transparent;
            rb_2_8.ForeColor = SystemColors.WindowText;
            rb_2_8.Location = new Point(3, 31);
            rb_2_8.Name = "rb_2_8";
            rb_2_8.Size = new Size(49, 24);
            rb_2_8.TabIndex = 23;
            rb_2_8.TabStop = true;
            rb_2_8.Text = "2.8";
            rb_2_8.UseVisualStyleBackColor = false;
            // 
            // rb_3_2
            // 
            rb_3_2.AutoSize = true;
            rb_3_2.BackColor = Color.Transparent;
            rb_3_2.ForeColor = SystemColors.WindowText;
            rb_3_2.Location = new Point(58, 31);
            rb_3_2.Name = "rb_3_2";
            rb_3_2.Size = new Size(49, 24);
            rb_3_2.TabIndex = 24;
            rb_3_2.TabStop = true;
            rb_3_2.Text = "3.2";
            rb_3_2.UseVisualStyleBackColor = false;
            // 
            // groupBox3
            // 
            groupBox3.BackColor = Color.Transparent;
            groupBox3.Controls.Add(rb_automatica);
            groupBox3.Controls.Add(rb_manual);
            groupBox3.ForeColor = Color.Transparent;
            groupBox3.Location = new Point(379, 228);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(250, 69);
            groupBox3.TabIndex = 37;
            groupBox3.TabStop = false;
            // 
            // rb_automatica
            // 
            rb_automatica.AutoSize = true;
            rb_automatica.BackColor = Color.Transparent;
            rb_automatica.ForeColor = SystemColors.WindowText;
            rb_automatica.Location = new Point(4, 11);
            rb_automatica.Name = "rb_automatica";
            rb_automatica.Size = new Size(107, 24);
            rb_automatica.TabIndex = 25;
            rb_automatica.TabStop = true;
            rb_automatica.Text = "Automática";
            rb_automatica.UseVisualStyleBackColor = false;
            // 
            // rb_manual
            // 
            rb_manual.AutoSize = true;
            rb_manual.BackColor = Color.Transparent;
            rb_manual.ForeColor = SystemColors.WindowText;
            rb_manual.Location = new Point(4, 41);
            rb_manual.Name = "rb_manual";
            rb_manual.Size = new Size(79, 24);
            rb_manual.TabIndex = 26;
            rb_manual.TabStop = true;
            rb_manual.Text = "Manual";
            rb_manual.UseVisualStyleBackColor = false;
            // 
            // InformacoesTecnicas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.InfoTecnicas;
            ClientSize = new Size(690, 580);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox4);
            Controls.Add(groupBox1);
            Controls.Add(tb_capacidadeDoTanque);
            Controls.Add(tb_numeroDoMotor);
            Controls.Add(tb_numeroDoChassi);
            Controls.Add(btn_proximo);
            Controls.Add(btn_limpar);
            Controls.Add(btn_fechar);
            FormBorderStyle = FormBorderStyle.None;
            Name = "InformacoesTecnicas";
            Text = "InformacoesTecnicas";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_fechar;
        private Button btn_limpar;
        private Button btn_proximo;
        private TextBox tb_numeroDoChassi;
        private TextBox tb_numeroDoMotor;
        private TextBox tb_capacidadeDoTanque;
        private GroupBox groupBox1;
        private RadioButton rb_gasolina;
        private RadioButton rb_diesel;
        private RadioButton rb_etanol;
        private RadioButton rb_biodiesel;
        private RadioButton rb_gnv;
        private RadioButton rb_eletricidade;
        private RadioButton rb_hidrogenio;
        private RadioButton rb_glp;
        private GroupBox groupBox4;
        private RadioButton rb_dianteira;
        private RadioButton rb_traseira;
        private RadioButton rb_integral;
        private RadioButton rb_4x4;
        private GroupBox groupBox2;
        private RadioButton rb_1_0;
        private RadioButton rb_1_3;
        private RadioButton rb_1_4;
        private RadioButton rb_2_0;
        private RadioButton rb_2_2;
        private RadioButton rb_2_8;
        private RadioButton rb_3_2;
        private GroupBox groupBox3;
        private RadioButton rb_automatica;
        private RadioButton rb_manual;
    }
}