namespace Estacionamento.Geral.Controles
{
    partial class MenuControle
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tlpMenusBotoes = new TableLayoutPanel();
            txtTitulo = new TextBox();
            btnUsuario = new Button();
            tlpMenusBotoes.SuspendLayout();
            SuspendLayout();
            // 
            // tlpMenusBotoes
            // 
            tlpMenusBotoes.ColumnCount = 1;
            tlpMenusBotoes.ColumnStyles.Add(new ColumnStyle());
            tlpMenusBotoes.Controls.Add(txtTitulo, 0, 0);
            tlpMenusBotoes.Controls.Add(btnUsuario, 0, 1);
            tlpMenusBotoes.Dock = DockStyle.Fill;
            tlpMenusBotoes.Location = new Point(0, 0);
            tlpMenusBotoes.Name = "tlpMenusBotoes";
            tlpMenusBotoes.RowCount = 2;
            tlpMenusBotoes.RowStyles.Add(new RowStyle());
            tlpMenusBotoes.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tlpMenusBotoes.Size = new Size(353, 660);
            tlpMenusBotoes.TabIndex = 0;
            // 
            // txtTitulo
            // 
            txtTitulo.BackColor = Color.White;
            txtTitulo.BorderStyle = BorderStyle.None;
            txtTitulo.Dock = DockStyle.Top;
            txtTitulo.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTitulo.Location = new Point(3, 3);
            txtTitulo.Name = "txtTitulo";
            txtTitulo.Size = new Size(347, 21);
            txtTitulo.TabIndex = 0;
            txtTitulo.Text = "Estacionamento";
            txtTitulo.TextAlign = HorizontalAlignment.Center;
            // 
            // btnUsuario
            // 
            btnUsuario.Dock = DockStyle.Fill;
            btnUsuario.Location = new Point(3, 30);
            btnUsuario.Name = "btnUsuario";
            btnUsuario.Size = new Size(347, 627);
            btnUsuario.TabIndex = 1;
            btnUsuario.Text = "Usuario";
            btnUsuario.UseVisualStyleBackColor = true;
            // 
            // MenuControle
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tlpMenusBotoes);
            Name = "MenuControle";
            Size = new Size(353, 660);
            Load += MenuControle_Load;
            tlpMenusBotoes.ResumeLayout(false);
            tlpMenusBotoes.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tlpMenusBotoes;
        private TextBox txtTitulo;
        private Button btnUsuario;
    }
}
