namespace ProjetoIFSP.Resources
{
    partial class loginPage
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
            this.components = new System.ComponentModel.Container();
            this.txUserLogin = new System.Windows.Forms.TextBox();
            this.lbLogin = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txPssword = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.btLogin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txUserLogin
            // 
            this.txUserLogin.Location = new System.Drawing.Point(282, 230);
            this.txUserLogin.Name = "txUserLogin";
            this.txUserLogin.Size = new System.Drawing.Size(203, 20);
            this.txUserLogin.TabIndex = 0;
            this.txUserLogin.Text = "digite seu e-mail...";
            // 
            // lbLogin
            // 
            this.lbLogin.AutoSize = true;
            this.lbLogin.BackColor = System.Drawing.Color.DarkGreen;
            this.lbLogin.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbLogin.Location = new System.Drawing.Point(229, 233);
            this.lbLogin.Name = "lbLogin";
            this.lbLogin.Size = new System.Drawing.Size(47, 15);
            this.lbLogin.TabIndex = 1;
            this.lbLogin.Text = "E-MAIL:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.DarkGreen;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(229, 276);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "SENHA:";
            // 
            // txPssword
            // 
            this.txPssword.Location = new System.Drawing.Point(282, 273);
            this.txPssword.Name = "txPssword";
            this.txPssword.Size = new System.Drawing.Size(203, 20);
            this.txPssword.TabIndex = 3;
            this.txPssword.Text = "digite sua senha...";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // btLogin
            // 
            this.btLogin.BackColor = System.Drawing.Color.DarkGreen;
            this.btLogin.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btLogin.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btLogin.Location = new System.Drawing.Point(304, 338);
            this.btLogin.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btLogin.Name = "btLogin";
            this.btLogin.Size = new System.Drawing.Size(112, 44);
            this.btLogin.TabIndex = 4;
            this.btLogin.Text = "LOGIN";
            this.btLogin.UseVisualStyleBackColor = false;
            this.btLogin.Click += new System.EventHandler(this.btLogin_Click);
            // 
            // loginPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Green;
            this.BackgroundImage = global::ProjetoIFSP.Properties.Resources.tela1_PhotoRoom_png;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(668, 525);
            this.Controls.Add(this.btLogin);
            this.Controls.Add(this.txPssword);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbLogin);
            this.Controls.Add(this.txUserLogin);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "loginPage";
            this.Text = "loginPage";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txUserLogin;
        private System.Windows.Forms.Label lbLogin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txPssword;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button btLogin;
    }
}