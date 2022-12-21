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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // close_button
            // 
            this.close_button.Location = new System.Drawing.Point(272, 161);
            this.close_button.Name = "close_button";
            this.close_button.Size = new System.Drawing.Size(73, 23);
            this.close_button.TabIndex = 0;
            this.close_button.Text = "Close";
            this.close_button.UseVisualStyleBackColor = true;
            this.close_button.Click += new System.EventHandler(this.close_info_button_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 139);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 45);
            this.label1.TabIndex = 1;
            this.label1.Text = "Version: 1.0.0\r\nBuild: 2022\r\nAuthor: Belltower";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(333, 50);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // github_button
            // 
            this.github_button.Location = new System.Drawing.Point(193, 161);
            this.github_button.Name = "github_button";
            this.github_button.Size = new System.Drawing.Size(73, 23);
            this.github_button.TabIndex = 3;
            this.github_button.Text = "My GitHub";
            this.github_button.UseVisualStyleBackColor = true;
            this.github_button.Click += new System.EventHandler(this.github_button_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(159, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Link copied to clipboard";
            this.label3.Visible = false;
            // 
            // email_button
            // 
            this.email_button.Location = new System.Drawing.Point(114, 161);
            this.email_button.Name = "email_button";
            this.email_button.Size = new System.Drawing.Size(73, 23);
            this.email_button.TabIndex = 6;
            this.email_button.Text = "E-Mail";
            this.email_button.UseVisualStyleBackColor = true;
            this.email_button.Click += new System.EventHandler(this.email_button_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(333, 45);
            this.label2.TabIndex = 7;
            this.label2.Text = "If you found a bug or you have suggestions, you can write me\r\nan email. Latest ve" +
    "rsion of this program may be found on my \r\nGitHub repository.";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(357, 195);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.email_button);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.github_button);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.close_button);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(373, 234);
            this.MinimumSize = new System.Drawing.Size(373, 234);
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
    }
}