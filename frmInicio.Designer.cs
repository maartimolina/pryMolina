namespace pryMolina
{
    partial class frmInicio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInicio));
            btnInicio = new Button();
            txtJugador = new TextBox();
            label2 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // btnInicio
            // 
            btnInicio.BackColor = SystemColors.ActiveCaptionText;
            btnInicio.Font = new Font("Verdana", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnInicio.ForeColor = SystemColors.ButtonHighlight;
            btnInicio.Location = new Point(1156, 585);
            btnInicio.Name = "btnInicio";
            btnInicio.Size = new Size(199, 99);
            btnInicio.TabIndex = 7;
            btnInicio.Text = "INGRESAR";
            btnInicio.UseVisualStyleBackColor = false;
            btnInicio.Click += btnInicio_Click;
            // 
            // txtJugador
            // 
            txtJugador.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtJugador.Location = new Point(561, 611);
            txtJugador.Multiline = true;
            txtJugador.Name = "txtJugador";
            txtJugador.Size = new Size(298, 39);
            txtJugador.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ActiveCaptionText;
            label2.Font = new Font("Verdana", 22.2F, FontStyle.Italic, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(312, 605);
            label2.Name = "label2";
            label2.Size = new Size(183, 45);
            label2.TabIndex = 5;
            label2.Text = "Jugador:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.WindowText;
            label1.Font = new Font("Stencil", 72F, FontStyle.Italic, GraphicsUnit.Point);
            label1.ForeColor = Color.Cyan;
            label1.Location = new Point(433, 45);
            label1.Name = "label1";
            label1.Size = new Size(494, 142);
            label1.TabIndex = 4;
            label1.Text = "GALAGA";
            label1.Click += label1_Click;
            // 
            // frmInicio
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1427, 722);
            Controls.Add(btnInicio);
            Controls.Add(txtJugador);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmInicio";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmInicio";
            Load += frmInicio_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnInicio;
        private TextBox txtJugador;
        private Label label2;
        private Label label1;
    }
}