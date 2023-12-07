namespace Recuperacao_PO2.Telas
{
    partial class Documentacao
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
            tb_renavam = new TextBox();
            tb_numeroDaPlaca = new TextBox();
            dtp_dataDeLicenciamento = new DateTimePicker();
            dtp_dataDaUltimaInspecaoVeicular = new DateTimePicker();
            SuspendLayout();
            // 
            // btn_fechar
            // 
            btn_fechar.Cursor = Cursors.Hand;
            btn_fechar.Location = new Point(650, 11);
            btn_fechar.Name = "btn_fechar";
            btn_fechar.Size = new Size(37, 29);
            btn_fechar.TabIndex = 3;
            btn_fechar.UseVisualStyleBackColor = true;
            btn_fechar.Click += btn_fechar_Click;
            // 
            // btn_limpar
            // 
            btn_limpar.Cursor = Cursors.Hand;
            btn_limpar.Location = new Point(546, 452);
            btn_limpar.Name = "btn_limpar";
            btn_limpar.Size = new Size(132, 43);
            btn_limpar.TabIndex = 4;
            btn_limpar.UseVisualStyleBackColor = true;
            // 
            // btn_proximo
            // 
            btn_proximo.Cursor = Cursors.Hand;
            btn_proximo.Location = new Point(546, 510);
            btn_proximo.Name = "btn_proximo";
            btn_proximo.Size = new Size(132, 43);
            btn_proximo.TabIndex = 5;
            btn_proximo.UseVisualStyleBackColor = true;
            btn_proximo.Click += btn_proximo_Click;
            // 
            // tb_renavam
            // 
            tb_renavam.BorderStyle = BorderStyle.None;
            tb_renavam.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tb_renavam.Location = new Point(37, 117);
            tb_renavam.Name = "tb_renavam";
            tb_renavam.Size = new Size(278, 23);
            tb_renavam.TabIndex = 6;
            tb_renavam.TextChanged += tb_renavam_TextChanged;
            tb_renavam.KeyPress += tb_renavam_KeyPress;
            // 
            // tb_numeroDaPlaca
            // 
            tb_numeroDaPlaca.BorderStyle = BorderStyle.None;
            tb_numeroDaPlaca.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tb_numeroDaPlaca.Location = new Point(37, 332);
            tb_numeroDaPlaca.Name = "tb_numeroDaPlaca";
            tb_numeroDaPlaca.Size = new Size(278, 23);
            tb_numeroDaPlaca.TabIndex = 7;
            // 
            // dtp_dataDeLicenciamento
            // 
            dtp_dataDeLicenciamento.CalendarMonthBackground = Color.Transparent;
            dtp_dataDeLicenciamento.Location = new Point(37, 191);
            dtp_dataDeLicenciamento.Name = "dtp_dataDeLicenciamento";
            dtp_dataDeLicenciamento.Size = new Size(278, 27);
            dtp_dataDeLicenciamento.TabIndex = 8;
            // 
            // dtp_dataDaUltimaInspecaoVeicular
            // 
            dtp_dataDaUltimaInspecaoVeicular.CalendarMonthBackground = Color.Transparent;
            dtp_dataDaUltimaInspecaoVeicular.Location = new Point(37, 261);
            dtp_dataDaUltimaInspecaoVeicular.Name = "dtp_dataDaUltimaInspecaoVeicular";
            dtp_dataDaUltimaInspecaoVeicular.Size = new Size(278, 27);
            dtp_dataDaUltimaInspecaoVeicular.TabIndex = 9;
            // 
            // Documentacao
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Documentacao;
            ClientSize = new Size(690, 580);
            Controls.Add(dtp_dataDaUltimaInspecaoVeicular);
            Controls.Add(dtp_dataDeLicenciamento);
            Controls.Add(tb_numeroDaPlaca);
            Controls.Add(tb_renavam);
            Controls.Add(btn_proximo);
            Controls.Add(btn_limpar);
            Controls.Add(btn_fechar);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Documentacao";
            Text = "Documentacao";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_fechar;
        private Button btn_limpar;
        private Button btn_proximo;
        private TextBox tb_renavam;
        private TextBox tb_numeroDaPlaca;
        private DateTimePicker dtp_dataDeLicenciamento;
        private DateTimePicker dtp_dataDaUltimaInspecaoVeicular;
    }
}