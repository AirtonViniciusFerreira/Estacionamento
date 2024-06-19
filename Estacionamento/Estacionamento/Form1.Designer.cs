namespace Estacionamento
{
    partial class Form1
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
            tlpPainelFundo = new TableLayoutPanel();
            SuspendLayout();
            // 
            // tlpPainelFundo
            // 
            tlpPainelFundo.ColumnCount = 2;
            tlpPainelFundo.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tlpPainelFundo.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 80F));
            tlpPainelFundo.Dock = DockStyle.Fill;
            tlpPainelFundo.Location = new Point(0, 0);
            tlpPainelFundo.Name = "tlpPainelFundo";
            tlpPainelFundo.RowCount = 1;
            tlpPainelFundo.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpPainelFundo.Size = new Size(900, 551);
            tlpPainelFundo.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(900, 551);
            Controls.Add(tlpPainelFundo);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tlpPainelFundo;
    }
}
