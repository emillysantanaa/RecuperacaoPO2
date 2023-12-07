namespace Recuperacao_PO2.Telas
{
    partial class ConsultarCarro
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
            btn_cadastrar = new Button();
            btn_voltar = new Button();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // btn_cadastrar
            // 
            btn_cadastrar.Cursor = Cursors.Hand;
            btn_cadastrar.Location = new Point(354, 514);
            btn_cadastrar.Name = "btn_cadastrar";
            btn_cadastrar.Size = new Size(134, 54);
            btn_cadastrar.TabIndex = 4;
            btn_cadastrar.UseVisualStyleBackColor = true;
            btn_cadastrar.Click += btn_cadastrar_Click;
            // 
            // btn_voltar
            // 
            btn_voltar.Cursor = Cursors.Hand;
            btn_voltar.Location = new Point(184, 514);
            btn_voltar.Name = "btn_voltar";
            btn_voltar.Size = new Size(150, 54);
            btn_voltar.TabIndex = 5;
            btn_voltar.UseVisualStyleBackColor = true;
            btn_voltar.Click += botao_voltar_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 59);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(666, 449);
            dataGridView1.TabIndex = 6;
            // 
            // ConsultarCarro
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Consultar;
            ClientSize = new Size(690, 580);
            Controls.Add(dataGridView1);
            Controls.Add(btn_voltar);
            Controls.Add(btn_cadastrar);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ConsultarCarro";
            Text = "ConsultarCarro";
            Load += ConsultarCarro_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btn_cadastrar;
        private Button btn_voltar;
        private DataGridView dataGridView1;
    }
}