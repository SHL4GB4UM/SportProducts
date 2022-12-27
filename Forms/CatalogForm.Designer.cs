namespace SportProducts.Forms
{
    partial class CatalogForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CatalogForm));
            this.backButton = new System.Windows.Forms.Button();
            this.topPanelCatalog = new System.Windows.Forms.Panel();
            this.topCataloglabel = new System.Windows.Forms.Label();
            this.logoBox2 = new System.Windows.Forms.PictureBox();
            this.closeLabel2 = new System.Windows.Forms.LinkLabel();
            this.topPanelCatalog.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // backButton
            // 
            this.backButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(140)))), ((int)(((byte)(81)))));
            this.backButton.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.backButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.backButton.Location = new System.Drawing.Point(376, 24);
            this.backButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(160, 57);
            this.backButton.TabIndex = 0;
            this.backButton.Text = "Вернуться в окно авторизации";
            this.backButton.UseVisualStyleBackColor = false;
            this.backButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // topPanelCatalog
            // 
            this.topPanelCatalog.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(227)))), ((int)(((byte)(131)))));
            this.topPanelCatalog.Controls.Add(this.topCataloglabel);
            this.topPanelCatalog.Controls.Add(this.backButton);
            this.topPanelCatalog.Location = new System.Drawing.Point(95, 0);
            this.topPanelCatalog.Name = "topPanelCatalog";
            this.topPanelCatalog.Size = new System.Drawing.Size(540, 95);
            this.topPanelCatalog.TabIndex = 1;
            // 
            // topCataloglabel
            // 
            this.topCataloglabel.Font = new System.Drawing.Font("Comic Sans MS", 20F);
            this.topCataloglabel.Location = new System.Drawing.Point(119, 29);
            this.topCataloglabel.Name = "topCataloglabel";
            this.topCataloglabel.Size = new System.Drawing.Size(233, 40);
            this.topCataloglabel.TabIndex = 0;
            this.topCataloglabel.Text = "Список товаров";
            // 
            // logoBox2
            // 
            this.logoBox2.Image = ((System.Drawing.Image)(resources.GetObject("logoBox2.Image")));
            this.logoBox2.Location = new System.Drawing.Point(0, 0);
            this.logoBox2.Name = "logoBox2";
            this.logoBox2.Size = new System.Drawing.Size(95, 95);
            this.logoBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logoBox2.TabIndex = 2;
            this.logoBox2.TabStop = false;
            // 
            // closeLabel2
            // 
            this.closeLabel2.ActiveLinkColor = System.Drawing.Color.Blue;
            this.closeLabel2.AutoSize = true;
            this.closeLabel2.LinkColor = System.Drawing.Color.Red;
            this.closeLabel2.Location = new System.Drawing.Point(581, 114);
            this.closeLabel2.Name = "closeLabel2";
            this.closeLabel2.Size = new System.Drawing.Size(50, 15);
            this.closeLabel2.TabIndex = 3;
            this.closeLabel2.TabStop = true;
            this.closeLabel2.Text = "Закрыть";
            this.closeLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.closeLabel2_LinkClicked);
            // 
            // CatalogForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 461);
            this.Controls.Add(this.closeLabel2);
            this.Controls.Add(this.logoBox2);
            this.Controls.Add(this.topPanelCatalog);
            this.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximumSize = new System.Drawing.Size(650, 500);
            this.MinimumSize = new System.Drawing.Size(600, 450);
            this.Name = "CatalogForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Каталог \"Спортивные товары\"";
            this.topPanelCatalog.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.logoBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Panel topPanelCatalog;
        private System.Windows.Forms.PictureBox logoBox2;
        private System.Windows.Forms.Label topCataloglabel;
        private System.Windows.Forms.LinkLabel closeLabel2;
    }
}