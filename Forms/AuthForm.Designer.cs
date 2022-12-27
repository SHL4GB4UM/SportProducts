namespace SportProducts
{
    partial class AuthForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AuthForm));
            this.authPanel = new System.Windows.Forms.Panel();
            this.Authlabel = new System.Windows.Forms.Label();
            this.passwordBox = new System.Windows.Forms.TextBox();
            this.loginBox = new System.Windows.Forms.TextBox();
            this.authButton = new System.Windows.Forms.Button();
            this.closeLabel = new System.Windows.Forms.LinkLabel();
            this.guestLabel = new System.Windows.Forms.LinkLabel();
            this.passLabel = new System.Windows.Forms.Label();
            this.loginLabel = new System.Windows.Forms.Label();
            this.topPanel = new System.Windows.Forms.Panel();
            this.topNameLabel = new System.Windows.Forms.Label();
            this.logoPictureBox = new System.Windows.Forms.PictureBox();
            this.authPanel.SuspendLayout();
            this.topPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // authPanel
            // 
            this.authPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(227)))), ((int)(((byte)(131)))));
            this.authPanel.Controls.Add(this.Authlabel);
            this.authPanel.Controls.Add(this.passwordBox);
            this.authPanel.Controls.Add(this.loginBox);
            this.authPanel.Controls.Add(this.authButton);
            this.authPanel.Controls.Add(this.closeLabel);
            this.authPanel.Controls.Add(this.guestLabel);
            this.authPanel.Controls.Add(this.passLabel);
            this.authPanel.Controls.Add(this.loginLabel);
            this.authPanel.Location = new System.Drawing.Point(95, 135);
            this.authPanel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.authPanel.Name = "authPanel";
            this.authPanel.Size = new System.Drawing.Size(420, 300);
            this.authPanel.TabIndex = 0;
            // 
            // Authlabel
            // 
            this.Authlabel.Font = new System.Drawing.Font("Comic Sans MS", 18F);
            this.Authlabel.Location = new System.Drawing.Point(155, 28);
            this.Authlabel.Name = "Authlabel";
            this.Authlabel.Size = new System.Drawing.Size(165, 31);
            this.Authlabel.TabIndex = 1;
            this.Authlabel.Text = "Авторизация";
            // 
            // passwordBox
            // 
            this.passwordBox.Location = new System.Drawing.Point(161, 144);
            this.passwordBox.Multiline = true;
            this.passwordBox.Name = "passwordBox";
            this.passwordBox.Size = new System.Drawing.Size(150, 30);
            this.passwordBox.TabIndex = 3;
            // 
            // loginBox
            // 
            this.loginBox.Location = new System.Drawing.Point(161, 82);
            this.loginBox.Multiline = true;
            this.loginBox.Name = "loginBox";
            this.loginBox.Size = new System.Drawing.Size(150, 30);
            this.loginBox.TabIndex = 2;
            // 
            // authButton
            // 
            this.authButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(140)))), ((int)(((byte)(81)))));
            this.authButton.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.authButton.Location = new System.Drawing.Point(161, 189);
            this.authButton.Name = "authButton";
            this.authButton.Size = new System.Drawing.Size(150, 50);
            this.authButton.TabIndex = 4;
            this.authButton.Text = "Авторизоваться";
            this.authButton.UseVisualStyleBackColor = false;
            this.authButton.Click += new System.EventHandler(this.authButton_Click);
            // 
            // closeLabel
            // 
            this.closeLabel.ActiveLinkColor = System.Drawing.Color.Blue;
            this.closeLabel.AutoSize = true;
            this.closeLabel.LinkColor = System.Drawing.Color.Red;
            this.closeLabel.Location = new System.Drawing.Point(357, 18);
            this.closeLabel.Name = "closeLabel";
            this.closeLabel.Size = new System.Drawing.Size(50, 15);
            this.closeLabel.TabIndex = 1;
            this.closeLabel.TabStop = true;
            this.closeLabel.Text = "Закрыть";
            this.closeLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.closeLabel_LinkClicked);
            // 
            // guestLabel
            // 
            this.guestLabel.AutoSize = true;
            this.guestLabel.Location = new System.Drawing.Point(172, 252);
            this.guestLabel.Name = "guestLabel";
            this.guestLabel.Size = new System.Drawing.Size(90, 15);
            this.guestLabel.TabIndex = 5;
            this.guestLabel.TabStop = true;
            this.guestLabel.Text = "Войти как гость";
            this.guestLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.guestLabel_LinkClicked);
            // 
            // passLabel
            // 
            this.passLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(140)))), ((int)(((byte)(81)))));
            this.passLabel.Font = new System.Drawing.Font("Comic Sans MS", 13F);
            this.passLabel.Location = new System.Drawing.Point(7, 144);
            this.passLabel.Name = "passLabel";
            this.passLabel.Size = new System.Drawing.Size(160, 30);
            this.passLabel.TabIndex = 1;
            this.passLabel.Text = "Введите пароль:";
            // 
            // loginLabel
            // 
            this.loginLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(140)))), ((int)(((byte)(81)))));
            this.loginLabel.Font = new System.Drawing.Font("Comic Sans MS", 13F);
            this.loginLabel.Location = new System.Drawing.Point(7, 82);
            this.loginLabel.Name = "loginLabel";
            this.loginLabel.Size = new System.Drawing.Size(160, 30);
            this.loginLabel.TabIndex = 0;
            this.loginLabel.Text = "Введите логин:";
            // 
            // topPanel
            // 
            this.topPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(227)))), ((int)(((byte)(131)))));
            this.topPanel.Controls.Add(this.topNameLabel);
            this.topPanel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.topPanel.Location = new System.Drawing.Point(95, 0);
            this.topPanel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(540, 95);
            this.topPanel.TabIndex = 1;
            // 
            // topNameLabel
            // 
            this.topNameLabel.AutoSize = true;
            this.topNameLabel.Font = new System.Drawing.Font("Comic Sans MS", 20F);
            this.topNameLabel.Location = new System.Drawing.Point(78, 24);
            this.topNameLabel.Name = "topNameLabel";
            this.topNameLabel.Size = new System.Drawing.Size(371, 38);
            this.topNameLabel.TabIndex = 0;
            this.topNameLabel.Text = "ООО \"Спортивные товары\"";
            // 
            // logoPictureBox
            // 
            this.logoPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("logoPictureBox.Image")));
            this.logoPictureBox.Location = new System.Drawing.Point(0, 0);
            this.logoPictureBox.Name = "logoPictureBox";
            this.logoPictureBox.Size = new System.Drawing.Size(95, 95);
            this.logoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logoPictureBox.TabIndex = 2;
            this.logoPictureBox.TabStop = false;
            // 
            // AuthForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 461);
            this.Controls.Add(this.logoPictureBox);
            this.Controls.Add(this.topPanel);
            this.Controls.Add(this.authPanel);
            this.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximumSize = new System.Drawing.Size(650, 500);
            this.MinimumSize = new System.Drawing.Size(600, 450);
            this.Name = "AuthForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ООО \"Спортивные товары\"";
            this.authPanel.ResumeLayout(false);
            this.authPanel.PerformLayout();
            this.topPanel.ResumeLayout(false);
            this.topPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel authPanel;
        private System.Windows.Forms.TextBox passwordBox;
        private System.Windows.Forms.TextBox loginBox;
        private System.Windows.Forms.Button authButton;
        private System.Windows.Forms.LinkLabel closeLabel;
        private System.Windows.Forms.LinkLabel guestLabel;
        private System.Windows.Forms.Label passLabel;
        private System.Windows.Forms.Label loginLabel;
        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.Label Authlabel;
        private System.Windows.Forms.Label topNameLabel;
        private System.Windows.Forms.PictureBox logoPictureBox;
    }
}

