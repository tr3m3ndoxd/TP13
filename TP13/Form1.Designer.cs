namespace TP13
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnINICIAR = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(267, 158);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(651, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bienvenido a mi primer aplicacion de escritorio, porfavor presiona el boton";
            // 
            // btnINICIAR
            // 
            this.btnINICIAR.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnINICIAR.Font = new System.Drawing.Font("MV Boli", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnINICIAR.ForeColor = System.Drawing.SystemColors.Info;
            this.btnINICIAR.Location = new System.Drawing.Point(488, 301);
            this.btnINICIAR.Name = "btnINICIAR";
            this.btnINICIAR.Size = new System.Drawing.Size(200, 103);
            this.btnINICIAR.TabIndex = 1;
            this.btnINICIAR.Text = "INICIAR";
            this.btnINICIAR.UseVisualStyleBackColor = false;
            this.btnINICIAR.Click += new System.EventHandler(this.btnINICIAR_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(1154, 654);
            this.Controls.Add(this.btnINICIAR);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "INICIO";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnINICIAR;
    }
}

