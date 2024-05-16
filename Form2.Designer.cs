namespace pryMolina
{
    partial class frmJuego
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
            components = new System.ComponentModel.Container();
            timer1 = new System.Windows.Forms.Timer(components);
            progressBar = new ProgressBar();
            lblNombreJugador = new Label();
            SuspendLayout();
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Tick += timer1_Tick;
            // 
            // progressBar
            // 
            progressBar.Location = new Point(767, 34);
            progressBar.Maximum = 50;
            progressBar.Name = "progressBar";
            progressBar.Size = new Size(163, 29);
            progressBar.Style = ProgressBarStyle.Continuous;
            progressBar.TabIndex = 0;
            progressBar.Value = 50;
            // 
            // lblNombreJugador
            // 
            lblNombreJugador.AutoSize = true;
            lblNombreJugador.Font = new Font("Bodoni MT", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            lblNombreJugador.ForeColor = SystemColors.ButtonHighlight;
            lblNombreJugador.Location = new Point(827, 75);
            lblNombreJugador.Name = "lblNombreJugador";
            lblNombreJugador.Size = new Size(0, 27);
            lblNombreJugador.TabIndex = 1;
            // 
            // frmJuego
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(1038, 774);
            Controls.Add(lblNombreJugador);
            Controls.Add(progressBar);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmJuego";
            StartPosition = FormStartPosition.CenterScreen;
            TopMost = true;
            Load += frmJuego_Load;
            KeyDown += frmJuego_KeyDown;
            KeyPress += frmJuego_KeyPress;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private ProgressBar progressBar;
        private Label lblNombreJugador;
    }
}