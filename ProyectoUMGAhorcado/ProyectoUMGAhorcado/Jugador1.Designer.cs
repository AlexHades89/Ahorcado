namespace ProyectoUMGAhorcado
{
    partial class Jugador1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.flFichas = new System.Windows.Forms.FlowLayoutPanel();
            this.flPalabra = new System.Windows.Forms.FlowLayoutPanel();
            this.lblMensaje = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.BTNiniciar = new System.Windows.Forms.PictureBox();
            this.picAhorcado = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.BTNiniciar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAhorcado)).BeginInit();
            this.SuspendLayout();
            // 
            // flFichas
            // 
            this.flFichas.Location = new System.Drawing.Point(12, 98);
            this.flFichas.Name = "flFichas";
            this.flFichas.Size = new System.Drawing.Size(445, 300);
            this.flFichas.TabIndex = 0;
            this.flFichas.Paint += new System.Windows.Forms.PaintEventHandler(this.flFichas_Paint);
            // 
            // flPalabra
            // 
            this.flPalabra.Location = new System.Drawing.Point(121, 400);
            this.flPalabra.Name = "flPalabra";
            this.flPalabra.Size = new System.Drawing.Size(608, 88);
            this.flPalabra.TabIndex = 2;
            // 
            // lblMensaje
            // 
            this.lblMensaje.AutoSize = true;
            this.lblMensaje.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMensaje.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblMensaje.Location = new System.Drawing.Point(519, 58);
            this.lblMensaje.Name = "lblMensaje";
            this.lblMensaje.Size = new System.Drawing.Size(251, 37);
            this.lblMensaje.TabIndex = 0;
            this.lblMensaje.Text = "!LO MATASTE¡";
            this.lblMensaje.Click += new System.EventHandler(this.lblMensahe_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(29, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(413, 39);
            this.label1.TabIndex = 3;
            this.label1.Text = "!ADIVINA LA PALABRA¡";
            // 
            // BTNiniciar
            // 
            this.BTNiniciar.Image = global::ProyectoUMGAhorcado.Properties.Resources.inicio;
            this.BTNiniciar.Location = new System.Drawing.Point(14, 13);
            this.BTNiniciar.Name = "BTNiniciar";
            this.BTNiniciar.Size = new System.Drawing.Size(243, 46);
            this.BTNiniciar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BTNiniciar.TabIndex = 4;
            this.BTNiniciar.TabStop = false;
            this.BTNiniciar.Click += new System.EventHandler(this.BTNiniciar_Click);
            // 
            // picAhorcado
            // 
            this.picAhorcado.Location = new System.Drawing.Point(520, 98);
            this.picAhorcado.Name = "picAhorcado";
            this.picAhorcado.Size = new System.Drawing.Size(250, 300);
            this.picAhorcado.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picAhorcado.TabIndex = 1;
            this.picAhorcado.TabStop = false;
            // 
            // Jugador1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(998, 736);
            this.Controls.Add(this.BTNiniciar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblMensaje);
            this.Controls.Add(this.flPalabra);
            this.Controls.Add(this.picAhorcado);
            this.Controls.Add(this.flFichas);
            this.Name = "Jugador1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.BTNiniciar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAhorcado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flFichas;
        private System.Windows.Forms.PictureBox picAhorcado;
        private System.Windows.Forms.FlowLayoutPanel flPalabra;
        private System.Windows.Forms.Label lblMensaje;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox BTNiniciar;
    }
}

