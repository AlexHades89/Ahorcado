namespace ProyectoUMGAhorcado
{
    partial class Jugador2
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
            this.BTNiniciar = new System.Windows.Forms.PictureBox();
            this.flFichas = new System.Windows.Forms.FlowLayoutPanel();
            this.picAhorcado = new System.Windows.Forms.PictureBox();
            this.flPalabra = new System.Windows.Forms.FlowLayoutPanel();
            this.lblMensaje = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.BTNiniciar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAhorcado)).BeginInit();
            this.SuspendLayout();
            // 
            // BTNiniciar
            // 
            this.BTNiniciar.Image = global::ProyectoUMGAhorcado.Properties.Resources.inicio;
            this.BTNiniciar.Location = new System.Drawing.Point(19, 1);
            this.BTNiniciar.Name = "BTNiniciar";
            this.BTNiniciar.Size = new System.Drawing.Size(202, 46);
            this.BTNiniciar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BTNiniciar.TabIndex = 0;
            this.BTNiniciar.TabStop = false;
            this.BTNiniciar.Click += new System.EventHandler(this.BTNiniciar_Click);
            // 
            // flFichas
            // 
            this.flFichas.Location = new System.Drawing.Point(12, 98);
            this.flFichas.Name = "flFichas";
            this.flFichas.Size = new System.Drawing.Size(445, 300);
            this.flFichas.TabIndex = 2;
            // 
            // picAhorcado
            // 
            this.picAhorcado.Location = new System.Drawing.Point(521, 98);
            this.picAhorcado.Name = "picAhorcado";
            this.picAhorcado.Size = new System.Drawing.Size(250, 300);
            this.picAhorcado.TabIndex = 3;
            this.picAhorcado.TabStop = false;
            // 
            // flPalabra
            // 
            this.flPalabra.Location = new System.Drawing.Point(121, 404);
            this.flPalabra.Name = "flPalabra";
            this.flPalabra.Size = new System.Drawing.Size(608, 88);
            this.flPalabra.TabIndex = 4;
            // 
            // lblMensaje
            // 
            this.lblMensaje.AutoSize = true;
            this.lblMensaje.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMensaje.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblMensaje.Location = new System.Drawing.Point(514, 52);
            this.lblMensaje.Name = "lblMensaje";
            this.lblMensaje.Size = new System.Drawing.Size(251, 37);
            this.lblMensaje.TabIndex = 5;
            this.lblMensaje.Text = "!LO MATASTE¡";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(413, 39);
            this.label1.TabIndex = 6;
            this.label1.Text = "!ADIVINA LA PALABRA¡";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(316, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(123, 35);
            this.button1.TabIndex = 7;
            this.button1.Text = "volver a jugar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Jugador2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(998, 736);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblMensaje);
            this.Controls.Add(this.flPalabra);
            this.Controls.Add(this.picAhorcado);
            this.Controls.Add(this.flFichas);
            this.Controls.Add(this.BTNiniciar);
            this.Location = new System.Drawing.Point(12, 98);
            this.Name = "Jugador2";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.BTNiniciar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAhorcado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox BTNiniciar;
        private System.Windows.Forms.FlowLayoutPanel flFichas;
        private System.Windows.Forms.PictureBox picAhorcado;
        private System.Windows.Forms.FlowLayoutPanel flPalabra;
        private System.Windows.Forms.Label lblMensaje;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}