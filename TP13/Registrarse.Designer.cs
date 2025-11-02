namespace TP13
{
    partial class Registrarse
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
            this.label4 = new System.Windows.Forms.Label();
            this.txtConfirmar = new System.Windows.Forms.TextBox();
            this.txtCrear = new System.Windows.Forms.TextBox();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(244, 161);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "USUARIO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MV Boli", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(377, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(168, 31);
            this.label2.TabIndex = 1;
            this.label2.Text = "REGISTRESE";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(194, 210);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(139, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "CREA UNA CONTRASEÑA";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(194, 263);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(156, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "CONFIRME LA CONTRASEÑA";
            // 
            // txtConfirmar
            // 
            this.txtConfirmar.Location = new System.Drawing.Point(361, 260);
            this.txtConfirmar.Name = "txtConfirmar";
            this.txtConfirmar.Size = new System.Drawing.Size(197, 20);
            this.txtConfirmar.TabIndex = 4;
            // 
            // txtCrear
            // 
            this.txtCrear.Location = new System.Drawing.Point(361, 207);
            this.txtCrear.Name = "txtCrear";
            this.txtCrear.Size = new System.Drawing.Size(197, 20);
            this.txtCrear.TabIndex = 5;
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(361, 158);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(197, 20);
            this.txtUsuario.TabIndex = 6;
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.SystemColors.Info;
            this.btnLogin.Font = new System.Drawing.Font("MV Boli", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnLogin.Location = new System.Drawing.Point(400, 369);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(121, 57);
            this.btnLogin.TabIndex = 7;
            this.btnLogin.Text = "INICIAR SESION";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.BackColor = System.Drawing.SystemColors.Info;
            this.btnConfirmar.Font = new System.Drawing.Font("MV Boli", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmar.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnConfirmar.Location = new System.Drawing.Point(400, 306);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(121, 57);
            this.btnConfirmar.TabIndex = 8;
            this.btnConfirmar.Text = "REGISTRARSE";
            this.btnConfirmar.UseVisualStyleBackColor = false;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.Info;
            this.button3.Font = new System.Drawing.Font("MV Boli", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.button3.Location = new System.Drawing.Point(742, 402);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(192, 106);
            this.button3.TabIndex = 9;
            this.button3.Text = "VOLVER";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Registrarse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(946, 520);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.txtCrear);
            this.Controls.Add(this.txtConfirmar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Registrarse";
            this.Text = "Registrarse";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Registrarse_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtConfirmar;
        private System.Windows.Forms.TextBox txtCrear;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.Button button3;
    }
}