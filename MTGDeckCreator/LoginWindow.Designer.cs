namespace MTGDeckCreator
{
    partial class LoginWindow
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
            this.loginLabel = new System.Windows.Forms.Label();
            this.passLabel = new System.Windows.Forms.Label();
            this.tBLogin = new System.Windows.Forms.TextBox();
            this.tBPass = new System.Windows.Forms.TextBox();
            this.loginButton = new System.Windows.Forms.Button();
            this.serverLabel = new System.Windows.Forms.Label();
            this.tBServer = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // loginLabel
            // 
            this.loginLabel.AutoSize = true;
            this.loginLabel.Location = new System.Drawing.Point(21, 45);
            this.loginLabel.Name = "loginLabel";
            this.loginLabel.Size = new System.Drawing.Size(33, 13);
            this.loginLabel.TabIndex = 0;
            this.loginLabel.Text = "Login";
            // 
            // passLabel
            // 
            this.passLabel.AutoSize = true;
            this.passLabel.Location = new System.Drawing.Point(21, 68);
            this.passLabel.Name = "passLabel";
            this.passLabel.Size = new System.Drawing.Size(53, 13);
            this.passLabel.TabIndex = 1;
            this.passLabel.Text = "Password";
            // 
            // tBLogin
            // 
            this.tBLogin.Location = new System.Drawing.Point(87, 42);
            this.tBLogin.Name = "tBLogin";
            this.tBLogin.Size = new System.Drawing.Size(100, 20);
            this.tBLogin.TabIndex = 2;
            // 
            // tBPass
            // 
            this.tBPass.Location = new System.Drawing.Point(87, 65);
            this.tBPass.Name = "tBPass";
            this.tBPass.Size = new System.Drawing.Size(100, 20);
            this.tBPass.TabIndex = 3;
            this.tBPass.UseSystemPasswordChar = true;
            // 
            // loginButton
            // 
            this.loginButton.Location = new System.Drawing.Point(87, 92);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(100, 23);
            this.loginButton.TabIndex = 4;
            this.loginButton.Text = "Login";
            this.loginButton.UseVisualStyleBackColor = true;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // serverLabel
            // 
            this.serverLabel.AutoSize = true;
            this.serverLabel.Location = new System.Drawing.Point(21, 22);
            this.serverLabel.Name = "serverLabel";
            this.serverLabel.Size = new System.Drawing.Size(38, 13);
            this.serverLabel.TabIndex = 5;
            this.serverLabel.Text = "Server";
            // 
            // tBServer
            // 
            this.tBServer.Location = new System.Drawing.Point(87, 19);
            this.tBServer.Name = "tBServer";
            this.tBServer.Size = new System.Drawing.Size(100, 20);
            this.tBServer.TabIndex = 6;
            this.tBServer.Text = "localhost";
            // 
            // LoginWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(221, 137);
            this.Controls.Add(this.tBServer);
            this.Controls.Add(this.serverLabel);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.tBPass);
            this.Controls.Add(this.tBLogin);
            this.Controls.Add(this.passLabel);
            this.Controls.Add(this.loginLabel);
            this.Name = "LoginWindow";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label loginLabel;
        private System.Windows.Forms.Label passLabel;
        private System.Windows.Forms.TextBox tBLogin;
        private System.Windows.Forms.TextBox tBPass;
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.Label serverLabel;
        private System.Windows.Forms.TextBox tBServer;
    }
}