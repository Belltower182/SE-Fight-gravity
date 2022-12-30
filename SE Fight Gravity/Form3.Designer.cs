namespace SE_Fight_Gravity
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.s_atm_thr = new System.Windows.Forms.TextBox();
            this.l_atm_thr = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.s_hydrogen_thrusters = new System.Windows.Forms.TextBox();
            this.l_hydrogen_thrusters = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.s_ion_thrusters = new System.Windows.Forms.TextBox();
            this.l_ion_thrusters = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label14_enough = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.label10 = new System.Windows.Forms.Label();
            this.label12_not_enough = new System.Windows.Forms.Label();
            this.totall_mass_calc = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.current_power = new System.Windows.Forms.TextBox();
            this.power_selector = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(9, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Atmospheric thrusters";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pictureBox2);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.s_atm_thr);
            this.groupBox1.Controls.Add(this.l_atm_thr);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(151, 148);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::SE_Fight_Gravity.Resource1.satm_thruster;
            this.pictureBox2.Location = new System.Drawing.Point(11, 109);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(23, 23);
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::SE_Fight_Gravity.Resource1.latm_thruster;
            this.pictureBox1.Location = new System.Drawing.Point(11, 61);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(23, 23);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // s_atm_thr
            // 
            this.s_atm_thr.BackColor = System.Drawing.Color.Bisque;
            this.s_atm_thr.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.s_atm_thr.Location = new System.Drawing.Point(39, 109);
            this.s_atm_thr.Name = "s_atm_thr";
            this.s_atm_thr.Size = new System.Drawing.Size(100, 23);
            this.s_atm_thr.TabIndex = 6;
            this.s_atm_thr.TextChanged += new System.EventHandler(this.s_atm_thr_TextChanged);
            // 
            // l_atm_thr
            // 
            this.l_atm_thr.BackColor = System.Drawing.Color.Bisque;
            this.l_atm_thr.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.l_atm_thr.Location = new System.Drawing.Point(39, 61);
            this.l_atm_thr.Name = "l_atm_thr";
            this.l_atm_thr.Size = new System.Drawing.Size(100, 23);
            this.l_atm_thr.TabIndex = 5;
            this.l_atm_thr.TextChanged += new System.EventHandler(this.l_atm_thr_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(48, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Small thrusters";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Large thrusters";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.pictureBox4);
            this.groupBox2.Controls.Add(this.pictureBox3);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.s_hydrogen_thrusters);
            this.groupBox2.Controls.Add(this.l_hydrogen_thrusters);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(174, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(151, 148);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackgroundImage = global::SE_Fight_Gravity.Resource1.shydro_thruster;
            this.pictureBox4.Location = new System.Drawing.Point(10, 109);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(23, 23);
            this.pictureBox4.TabIndex = 10;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImage = global::SE_Fight_Gravity.Resource1.lhydro_thruster;
            this.pictureBox3.Location = new System.Drawing.Point(10, 61);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(23, 23);
            this.pictureBox3.TabIndex = 9;
            this.pictureBox3.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(48, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 15);
            this.label4.TabIndex = 4;
            this.label4.Text = "Small thrusters";
            // 
            // s_hydrogen_thrusters
            // 
            this.s_hydrogen_thrusters.BackColor = System.Drawing.Color.Bisque;
            this.s_hydrogen_thrusters.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.s_hydrogen_thrusters.Location = new System.Drawing.Point(39, 109);
            this.s_hydrogen_thrusters.Name = "s_hydrogen_thrusters";
            this.s_hydrogen_thrusters.Size = new System.Drawing.Size(100, 23);
            this.s_hydrogen_thrusters.TabIndex = 3;
            this.s_hydrogen_thrusters.TextChanged += new System.EventHandler(this.s_hydrogen_thrusters_TextChanged);
            // 
            // l_hydrogen_thrusters
            // 
            this.l_hydrogen_thrusters.BackColor = System.Drawing.Color.Bisque;
            this.l_hydrogen_thrusters.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.l_hydrogen_thrusters.Location = new System.Drawing.Point(39, 61);
            this.l_hydrogen_thrusters.Name = "l_hydrogen_thrusters";
            this.l_hydrogen_thrusters.Size = new System.Drawing.Size(100, 23);
            this.l_hydrogen_thrusters.TabIndex = 2;
            this.l_hydrogen_thrusters.TextChanged += new System.EventHandler(this.l_hydrogen_thrusters_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(46, 43);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 15);
            this.label5.TabIndex = 1;
            this.label5.Text = "Large thrusters";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(16, 19);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(116, 15);
            this.label6.TabIndex = 0;
            this.label6.Text = "Hydrogen thrusters";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.pictureBox6);
            this.groupBox3.Controls.Add(this.pictureBox5);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.s_ion_thrusters);
            this.groupBox3.Controls.Add(this.l_ion_thrusters);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Location = new System.Drawing.Point(336, 4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(151, 148);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackgroundImage = global::SE_Fight_Gravity.Resource1.sion_thruster;
            this.pictureBox6.Location = new System.Drawing.Point(10, 109);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(23, 23);
            this.pictureBox6.TabIndex = 12;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackgroundImage = global::SE_Fight_Gravity.Resource1.lion_thruster;
            this.pictureBox5.Location = new System.Drawing.Point(10, 61);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(23, 23);
            this.pictureBox5.TabIndex = 11;
            this.pictureBox5.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(48, 91);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 15);
            this.label7.TabIndex = 4;
            this.label7.Text = "Small thrusters";
            // 
            // s_ion_thrusters
            // 
            this.s_ion_thrusters.BackColor = System.Drawing.Color.Bisque;
            this.s_ion_thrusters.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.s_ion_thrusters.Location = new System.Drawing.Point(39, 109);
            this.s_ion_thrusters.Name = "s_ion_thrusters";
            this.s_ion_thrusters.Size = new System.Drawing.Size(100, 23);
            this.s_ion_thrusters.TabIndex = 3;
            this.s_ion_thrusters.TextChanged += new System.EventHandler(this.s_ion_thrusters_TextChanged);
            // 
            // l_ion_thrusters
            // 
            this.l_ion_thrusters.BackColor = System.Drawing.Color.Bisque;
            this.l_ion_thrusters.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.l_ion_thrusters.Location = new System.Drawing.Point(39, 61);
            this.l_ion_thrusters.Name = "l_ion_thrusters";
            this.l_ion_thrusters.Size = new System.Drawing.Size(100, 23);
            this.l_ion_thrusters.TabIndex = 2;
            this.l_ion_thrusters.TextChanged += new System.EventHandler(this.l_ion_thrusters_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(46, 43);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(85, 15);
            this.label8.TabIndex = 1;
            this.label8.Text = "Large thrusters";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(33, 19);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(79, 15);
            this.label9.TabIndex = 0;
            this.label9.Text = "Ion thrusters";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label14_enough);
            this.groupBox4.Controls.Add(this.progressBar1);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Controls.Add(this.label12_not_enough);
            this.groupBox4.Controls.Add(this.totall_mass_calc);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Controls.Add(this.current_power);
            this.groupBox4.Location = new System.Drawing.Point(12, 203);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(475, 109);
            this.groupBox4.TabIndex = 7;
            this.groupBox4.TabStop = false;
            // 
            // label14_enough
            // 
            this.label14_enough.AutoSize = true;
            this.label14_enough.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label14_enough.ForeColor = System.Drawing.Color.LimeGreen;
            this.label14_enough.Location = new System.Drawing.Point(125, 32);
            this.label14_enough.Name = "label14_enough";
            this.label14_enough.Size = new System.Drawing.Size(223, 30);
            this.label14_enough.TabIndex = 12;
            this.label14_enough.Text = "ENOUGHT TO HOLD";
            this.label14_enough.Visible = false;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(24, 69);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(424, 23);
            this.progressBar1.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBar1.TabIndex = 11;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(31, 20);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(89, 15);
            this.label10.TabIndex = 0;
            this.label10.Text = "Current power";
            // 
            // label12_not_enough
            // 
            this.label12_not_enough.AutoSize = true;
            this.label12_not_enough.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label12_not_enough.ForeColor = System.Drawing.Color.Tomato;
            this.label12_not_enough.Location = new System.Drawing.Point(153, 31);
            this.label12_not_enough.Name = "label12_not_enough";
            this.label12_not_enough.Size = new System.Drawing.Size(160, 30);
            this.label12_not_enough.TabIndex = 4;
            this.label12_not_enough.Text = "NOT ENOUGH";
            this.label12_not_enough.Visible = false;
            // 
            // totall_mass_calc
            // 
            this.totall_mass_calc.BackColor = System.Drawing.Color.AliceBlue;
            this.totall_mass_calc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.totall_mass_calc.Enabled = false;
            this.totall_mass_calc.Location = new System.Drawing.Point(348, 38);
            this.totall_mass_calc.Name = "totall_mass_calc";
            this.totall_mass_calc.Size = new System.Drawing.Size(100, 23);
            this.totall_mass_calc.TabIndex = 3;
            this.totall_mass_calc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label11.Location = new System.Drawing.Point(365, 20);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(67, 15);
            this.label11.TabIndex = 2;
            this.label11.Text = "Ship MASS";
            // 
            // current_power
            // 
            this.current_power.BackColor = System.Drawing.Color.AliceBlue;
            this.current_power.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.current_power.Enabled = false;
            this.current_power.Location = new System.Drawing.Point(24, 38);
            this.current_power.Name = "current_power";
            this.current_power.Size = new System.Drawing.Size(100, 23);
            this.current_power.TabIndex = 1;
            this.current_power.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // power_selector
            // 
            this.power_selector.BackColor = System.Drawing.Color.Bisque;
            this.power_selector.FormattingEnabled = true;
            this.power_selector.Items.AddRange(new object[] {
            "100%",
            "90%",
            "80%",
            "70%",
            "60%",
            "50%",
            "40%",
            "30%",
            "20%",
            "10%"});
            this.power_selector.Location = new System.Drawing.Point(218, 177);
            this.power_selector.Name = "power_selector";
            this.power_selector.Size = new System.Drawing.Size(55, 23);
            this.power_selector.TabIndex = 8;
            this.power_selector.SelectedIndexChanged += new System.EventHandler(this.power_selector_SelectedIndexChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label13.Location = new System.Drawing.Point(199, 159);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(99, 15);
            this.label13.TabIndex = 9;
            this.label13.Text = "Thrusters Power";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.Color.Crimson;
            this.label12.Location = new System.Drawing.Point(52, 174);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(67, 15);
            this.label12.TabIndex = 10;
            this.label12.Text = "Only digits!";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(499, 325);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.power_selector);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(515, 364);
            this.MinimumSize = new System.Drawing.Size(515, 364);
            this.Name = "Form3";
            this.Text = "Mixed Calculations";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private GroupBox groupBox1;
        private Label label3;
        private Label label2;
        private GroupBox groupBox2;
        private Label label4;
        private TextBox s_hydrogen_thrusters;
        private TextBox l_hydrogen_thrusters;
        private Label label5;
        private Label label6;
        private GroupBox groupBox3;
        private Label label7;
        private TextBox s_ion_thrusters;
        private TextBox l_ion_thrusters;
        private Label label8;
        private Label label9;
        private GroupBox groupBox4;
        private TextBox totall_mass_calc;
        private Label label11;
        private TextBox current_power;
        private Label label10;
        private Label label12_not_enough;
        private ComboBox power_selector;
        private Label label13;
        private ProgressBar progressBar1;
        private Label label14_enough;
        private TextBox s_atm_thr;
        private TextBox l_atm_thr;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private PictureBox pictureBox4;
        private PictureBox pictureBox3;
        private PictureBox pictureBox6;
        private PictureBox pictureBox5;
        private Label label12;
    }
}