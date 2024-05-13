namespace pryMolina
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
            btnFirma = new Button();
            btnJuego = new Button();
            SuspendLayout();
            // 
            // btnFirma
            // 
            btnFirma.Location = new Point(114, 132);
            btnFirma.Name = "btnFirma";
            btnFirma.Size = new Size(184, 122);
            btnFirma.TabIndex = 0;
            btnFirma.Text = "Firma";
            btnFirma.UseVisualStyleBackColor = true;
            // 
            // btnJuego
            // 
            btnJuego.Location = new Point(345, 132);
            btnJuego.Name = "btnJuego";
            btnJuego.Size = new Size(184, 122);
            btnJuego.TabIndex = 1;
            btnJuego.Text = "Juego";
            btnJuego.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnJuego);
            Controls.Add(btnFirma);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button btnFirma;
        private Button btnJuego;
    }
}