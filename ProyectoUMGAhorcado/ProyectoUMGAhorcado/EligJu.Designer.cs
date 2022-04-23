namespace ProyectoUMGAhorcado
{
    partial class EligJu
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
            this.Jugadores_1 = new System.Windows.Forms.Button();
            this.Jugadores_2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Jugadores_1
            // 
            this.Jugadores_1.Location = new System.Drawing.Point(196, 139);
            this.Jugadores_1.Name = "Jugadores_1";
            this.Jugadores_1.Size = new System.Drawing.Size(111, 23);
            this.Jugadores_1.TabIndex = 0;
            this.Jugadores_1.Text = "Jugadores: 1";
            this.Jugadores_1.UseVisualStyleBackColor = true;
            this.Jugadores_1.Click += new System.EventHandler(this.Jugadores_1_Click);
            // 
            // Jugadores_2
            // 
            this.Jugadores_2.Location = new System.Drawing.Point(395, 139);
            this.Jugadores_2.Name = "Jugadores_2";
            this.Jugadores_2.Size = new System.Drawing.Size(108, 23);
            this.Jugadores_2.TabIndex = 1;
            this.Jugadores_2.Text = "Jugadores: 2";
            this.Jugadores_2.UseVisualStyleBackColor = true;
            this.Jugadores_2.Click += new System.EventHandler(this.Jugadores_2_Click);
            // 
            // EligJu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Jugadores_2);
            this.Controls.Add(this.Jugadores_1);
            this.Name = "EligJu";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Jugadores_1;
        private System.Windows.Forms.Button Jugadores_2;
    }
}