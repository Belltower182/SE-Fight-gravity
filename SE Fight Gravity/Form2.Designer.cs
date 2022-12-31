namespace SE_Fight_Gravity
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.close_button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.github_button = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.email_button = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // close_button
            // 
            this.close_button.Location = new System.Drawing.Point(269, 178);
            this.close_button.Name = "close_button";
            this.close_button.Size = new System.Drawing.Size(73, 23);
            this.close_button.TabIndex = 0;
            this.close_button.Text = "Close";
            this.close_button.UseVisualStyleBackColor = true;
            this.close_button.Click += new System.EventHandler(this.ButtonInfoCloseClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 139);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(257, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Version: 1.0.0 Date: 01.01.2022 Author: Belltower";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::SE_Fight_Gravity.Resource1.about;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(333, 50);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // github_button
            // 
            this.github_button.Location = new System.Drawing.Point(182, 178);
            this.github_button.Name = "github_button";
            this.github_button.Size = new System.Drawing.Size(73, 23);
            this.github_button.TabIndex = 3;
            this.github_button.Text = "My GitHub";
            this.github_button.UseVisualStyleBackColor = true;
            this.github_button.Click += new System.EventHandler(this.LinkToGithubClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(107, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Link copied to clipboard";
            this.label3.Visible = false;
            // 
            // email_button
            // 
            this.email_button.Location = new System.Drawing.Point(97, 178);
            this.email_button.Name = "email_button";
            this.email_button.Size = new System.Drawing.Size(73, 23);
            this.email_button.TabIndex = 6;
            this.email_button.Text = "E-Mail";
            this.email_button.UseVisualStyleBackColor = true;
            this.email_button.Click += new System.EventHandler(this.LinkForEmailButtonClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(333, 45);
            this.label2.TabIndex = 7;
            this.label2.Text = "If you found a bug or you have suggestions, you can write me\r\nan email. Latest ve" +
    "rsion of this app may be found on my \r\nGitHub repository.";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 178);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(73, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Donate";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.LinkToDonateButtonClick);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(357, 206);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.email_button);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.github_button);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.close_button);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(373, 245);
            this.MinimumSize = new System.Drawing.Size(373, 245);
            this.Name = "Form2";
            this.Text = "About";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button close_button;
        private Label label1;
        private PictureBox pictureBox1;
        private Button github_button;
        private Label label3;
        private Button email_button;
        private Label label2;
        private Button button1;
    }
}