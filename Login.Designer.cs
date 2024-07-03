namespace TimeLog.DataImporter
{
    partial class Login
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            panel_login = new System.Windows.Forms.Panel();
            button_pat_login = new System.Windows.Forms.Button();
            textbox_PAT = new System.Windows.Forms.TextBox();
            label_PAT = new System.Windows.Forms.Label();
            label_siteUrl = new System.Windows.Forms.Label();
            textBox_siteUrl = new System.Windows.Forms.TextBox();
            label_loginText = new System.Windows.Forms.Label();
            label_login = new System.Windows.Forms.Label();
            button_login = new System.Windows.Forms.Button();
            panel_login.SuspendLayout();
            SuspendLayout();
            // 
            // panel_login
            // 
            panel_login.Controls.Add(button_pat_login);
            panel_login.Controls.Add(textbox_PAT);
            panel_login.Controls.Add(label_PAT);
            panel_login.Controls.Add(label_siteUrl);
            panel_login.Controls.Add(textBox_siteUrl);
            panel_login.Controls.Add(label_loginText);
            panel_login.Controls.Add(label_login);
            panel_login.Controls.Add(button_login);
            panel_login.Dock = System.Windows.Forms.DockStyle.Fill;
            panel_login.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            panel_login.Location = new System.Drawing.Point(0, 0);
            panel_login.Name = "panel_login";
            panel_login.Size = new System.Drawing.Size(990, 903);
            panel_login.TabIndex = 0;
            // 
            // button_pat_login
            // 
            button_pat_login.BackColor = System.Drawing.Color.FromArgb(226, 43, 141);
            button_pat_login.Cursor = System.Windows.Forms.Cursors.Hand;
            button_pat_login.FlatAppearance.BorderSize = 0;
            button_pat_login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            button_pat_login.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            button_pat_login.ForeColor = System.Drawing.Color.White;
            button_pat_login.Location = new System.Drawing.Point(338, 519);
            button_pat_login.Margin = new System.Windows.Forms.Padding(10);
            button_pat_login.Name = "button_pat_login";
            button_pat_login.Size = new System.Drawing.Size(334, 39);
            button_pat_login.TabIndex = 7;
            button_pat_login.Text = "Login using PAT";
            button_pat_login.UseVisualStyleBackColor = false;
            button_pat_login.Click += button_pat_login_Click;
            // 
            // textbox_PAT
            // 
            textbox_PAT.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            textbox_PAT.Location = new System.Drawing.Point(338, 477);
            textbox_PAT.Name = "textbox_PAT";
            textbox_PAT.PlaceholderText = "Personal Access Token";
            textbox_PAT.Size = new System.Drawing.Size(334, 29);
            textbox_PAT.TabIndex = 6;
            // 
            // label_PAT
            // 
            label_PAT.AutoSize = true;
            label_PAT.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label_PAT.Location = new System.Drawing.Point(294, 480);
            label_PAT.Name = "label_PAT";
            label_PAT.Size = new System.Drawing.Size(38, 21);
            label_PAT.TabIndex = 5;
            label_PAT.Text = "PAT:";
            // 
            // label_siteUrl
            // 
            label_siteUrl.AutoSize = true;
            label_siteUrl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label_siteUrl.Location = new System.Drawing.Point(270, 373);
            label_siteUrl.Name = "label_siteUrl";
            label_siteUrl.Size = new System.Drawing.Size(62, 21);
            label_siteUrl.TabIndex = 4;
            label_siteUrl.Text = "Site url:";
            // 
            // textBox_siteUrl
            // 
            textBox_siteUrl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            textBox_siteUrl.Location = new System.Drawing.Point(338, 370);
            textBox_siteUrl.Name = "textBox_siteUrl";
            textBox_siteUrl.PlaceholderText = "E.g: https://app4.timelog.com/coldemo";
            textBox_siteUrl.Size = new System.Drawing.Size(334, 29);
            textBox_siteUrl.TabIndex = 3;
            // 
            // label_loginText
            // 
            label_loginText.AutoSize = true;
            label_loginText.BackColor = System.Drawing.Color.Transparent;
            label_loginText.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label_loginText.ForeColor = System.Drawing.Color.FromArgb(64, 64, 64);
            label_loginText.Location = new System.Drawing.Point(217, 329);
            label_loginText.Name = "label_loginText";
            label_loginText.Size = new System.Drawing.Size(573, 25);
            label_loginText.TabIndex = 2;
            label_loginText.Text = "Please press the Login button to be redirected to the Login Portal.";
            // 
            // label_login
            // 
            label_login.AutoSize = true;
            label_login.BackColor = System.Drawing.Color.Transparent;
            label_login.Font = new System.Drawing.Font("Segoe UI Semibold", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label_login.ForeColor = System.Drawing.Color.FromArgb(64, 64, 64);
            label_login.Location = new System.Drawing.Point(183, 182);
            label_login.Name = "label_login";
            label_login.Size = new System.Drawing.Size(648, 50);
            label_login.TabIndex = 1;
            label_login.Text = "Welcome to TimeLog Data Importer !";
            // 
            // button_login
            // 
            button_login.BackColor = System.Drawing.Color.FromArgb(226, 43, 141);
            button_login.Cursor = System.Windows.Forms.Cursors.Hand;
            button_login.FlatAppearance.BorderSize = 0;
            button_login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            button_login.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            button_login.ForeColor = System.Drawing.Color.White;
            button_login.Location = new System.Drawing.Point(338, 412);
            button_login.Margin = new System.Windows.Forms.Padding(10);
            button_login.Name = "button_login";
            button_login.Size = new System.Drawing.Size(334, 39);
            button_login.TabIndex = 0;
            button_login.Text = "Login using Login Portal";
            button_login.UseVisualStyleBackColor = false;
            button_login.Click += LoginButton_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(990, 903);
            Controls.Add(panel_login);
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            Name = "Login";
            Text = "TimeLog Data Importer";
            panel_login.ResumeLayout(false);
            panel_login.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panel_login;
        private System.Windows.Forms.Button button_login;
        private System.Windows.Forms.Label label_login;
        private System.Windows.Forms.Label label_loginText;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label_siteUrl;
        private System.Windows.Forms.TextBox textBox_siteUrl;
        private System.Windows.Forms.Button button_pat_login;
        private System.Windows.Forms.TextBox textbox_PAT;
        private System.Windows.Forms.Label label_PAT;
    }
}
