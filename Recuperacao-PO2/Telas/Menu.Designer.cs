namespace Recuperacao_PO2
{
    partial class Menu
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btn_fechar = new Button();
            btn_consultar = new Button();
            btn_cadastrar = new Button();
            SuspendLayout();
            // 
            // btn_fechar
            // 
            btn_fechar.Cursor = Cursors.Hand;
            btn_fechar.Location = new Point(650, 12);
            btn_fechar.Name = "btn_fechar";
            btn_fechar.Size = new Size(37, 29);
            btn_fechar.TabIndex = 0;
            btn_fechar.UseVisualStyleBackColor = true;
            btn_fechar.Click += btn_fechar_Click;
            // 
            // btn_consultar
            // 
            btn_consultar.Cursor = Cursors.Hand;
            btn_consultar.Location = new Point(129, 268);
            btn_consultar.Name = "btn_consultar";
            btn_consultar.Size = new Size(187, 43);
            btn_consultar.TabIndex = 1;
            btn_consultar.UseVisualStyleBackColor = true;
            btn_consultar.Click += btn_consultar_Click_1;
            // 
            // btn_cadastrar
            // 
            btn_cadastrar.Cursor = Cursors.Hand;
            btn_cadastrar.Location = new Point(373, 268);
            btn_cadastrar.Name = "btn_cadastrar";
            btn_cadastrar.Size = new Size(191, 43);
            btn_cadastrar.TabIndex = 2;
            btn_cadastrar.UseVisualStyleBackColor = true;
            btn_cadastrar.Click += btn_cadastrar_Click_1;
            // 
            // Menu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Menu;
            ClientSize = new Size(690, 580);
            Controls.Add(btn_cadastrar);
            Controls.Add(btn_consultar);
            Controls.Add(btn_fechar);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Menu";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button btn_fechar;
        private Button btn_consultar;
        private Button btn_cadastrar;
    }
}
