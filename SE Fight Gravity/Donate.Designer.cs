namespace SE_Fight_Gravity
{
    partial class Donate
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Donate));
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label_donate = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(168, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(206, 75);
            this.label1.TabIndex = 0;
            this.label1.Text = "But if you like this app and want \r\nto support me you can donate via \r\n\"donationa" +
    "lerts.com\" use QR code or \r\npress a button to copy a link to a \r\ndonate page. Th" +
    "ank you! ٩(ˊᗜˋ*)و";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SE_Fight_Gravity.Resource1.dnqrcode;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(150, 150);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(168, 126);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(197, 36);
            this.button1.TabIndex = 2;
            this.button1.Text = "Copy link to donate page";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.ButtonDonateLinkClick);
            // 
            // label_donate
            // 
            this.label_donate.AutoSize = true;
            this.label_donate.Location = new System.Drawing.Point(200, 111);
            this.label_donate.Name = "label_donate";
            this.label_donate.Size = new System.Drawing.Size(135, 15);
            this.label_donate.TabIndex = 3;
            this.label_donate.Text = "Link copied to clipboard";
            this.label_donate.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label2.Location = new System.Drawing.Point(180, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(172, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "This application is totally free!!! ";
            // 
            // Donate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(371, 172);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label_donate);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(387, 211);
            this.MinimumSize = new System.Drawing.Size(387, 211);
            this.Name = "Donate";
            this.Text = "Donate";
            this.Load += new System.EventHandler(this.DonateLoad);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private PictureBox pictureBox1;
        private Button button1;
        private Label label_donate;
        private Label label2;
    }
}