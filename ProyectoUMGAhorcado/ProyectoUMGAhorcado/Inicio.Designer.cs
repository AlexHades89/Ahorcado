namespace ProyectoUMGAhorcado
{
    partial class Inicio
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
            this.Jugar = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Jugar
            // 
            this.Jugar.Location = new System.Drawing.Point(369, 121);
            this.Jugar.Name = "Jugar";
            this.Jugar.Size = new System.Drawing.Size(75, 23);
            this.Jugar.TabIndex = 0;
            this.Jugar.Text = "Jugar";
            this.Jugar.UseVisualStyleBackColor = true;
            this.Jugar.Click += new System.EventHandler(this.Jugar_Click);
            // 
            // exit
            // 
            this.exit.Location = new System.Drawing.Point(369, 197);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(75, 23);
            this.exit.TabIndex = 1;
            this.exit.Text = "salir";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.Jugar);
            this.Name = "Inicio";
            this.Text = "Form2";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Jugar;
        private System.Windows.Forms.Button exit;
    }
}