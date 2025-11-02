namespace TP13
{
    partial class INICIAR_SESION
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnVOLVER = new System.Windows.Forms.Button();
            this.Username = new System.Windows.Forms.TextBox();
            this.Contraseña = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MV Boli", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(361, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(194, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "INICIE SESION";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(225, 193);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "NOMBRE";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(225, 255);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "CONTRASEÑA";
            // 
            // btnVOLVER
            // 
            this.btnVOLVER.BackColor = System.Drawing.SystemColors.Info;
            this.btnVOLVER.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVOLVER.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnVOLVER.Location = new System.Drawing.Point(771, 432);
            this.btnVOLVER.Name = "btnVOLVER";
            this.btnVOLVER.Size = new System.Drawing.Size(157, 81);
            this.btnVOLVER.TabIndex = 3;
            this.btnVOLVER.Text = "VOLVER";
            this.btnVOLVER.UseVisualStyleBackColor = false;
            this.btnVOLVER.Click += new System.EventHandler(this.btnVOLVER_Click);
            // 
            // Username
            // 
            this.Username.Location = new System.Drawing.Point(356, 186);
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(209, 20);
            this.Username.TabIndex = 4;
            // 
            // Contraseña
            // 
            this.Contraseña.Location = new System.Drawing.Point(356, 252);
            this.Contraseña.Name = "Contraseña";
            this.Contraseña.Size = new System.Drawing.Size(209, 20);
            this.Contraseña.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Info;
            this.button1.Font = new System.Drawing.Font("MV Boli", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.button1.Location = new System.Drawing.Point(397, 305);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 57);
            this.button1.TabIndex = 6;
            this.button1.Text = "INICIAR SESION";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // INICIAR_SESION
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(940, 525);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Contraseña);
            this.Controls.Add(this.Username);
            this.Controls.Add(this.btnVOLVER);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "INICIAR_SESION";
            this.Text = "INICIAR_SESION";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.INICIAR_SESION_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnVOLVER;
        private System.Windows.Forms.TextBox Username;
        private System.Windows.Forms.TextBox Contraseña;
        private System.Windows.Forms.Button button1;
    }
}