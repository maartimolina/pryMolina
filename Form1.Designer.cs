namespace pryMolina
{
    partial class frmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            btnFirma = new Button();
            btnJuego = new Button();
            SuspendLayout();
            // 
            // btnFirma
            // 
            btnFirma.BackgroundImage = (Image)resources.GetObject("btnFirma.BackgroundImage");
            btnFirma.Location = new Point(12, 41);
            btnFirma.Name = "btnFirma";
            btnFirma.Size = new Size(292, 170);
            btnFirma.TabIndex = 0;
            btnFirma.Text = "Firma";
            btnFirma.UseVisualStyleBackColor = true;
            btnFirma.Click += btnFirma_Click;
            // 
            // btnJuego
            // 
            btnJuego.BackgroundImage = (Image)resources.GetObject("btnJuego.BackgroundImage");
            btnJuego.Location = new Point(321, 41);
            btnJuego.Name = "btnJuego";
            btnJuego.Size = new Size(292, 170);
            btnJuego.TabIndex = 1;
            btnJuego.UseVisualStyleBackColor = true;
            // 
            // frmPrincipal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(621, 244);
            Controls.Add(btnJuego);
            Controls.Add(btnFirma);
            Name = "frmPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Principal";
            ResumeLayout(false);
        }

        #endregion

        private Button btnFirma;
        private Button btnJuego;
    }
}