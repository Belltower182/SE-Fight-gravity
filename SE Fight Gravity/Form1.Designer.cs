namespace SE_Fight_Gravity
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.type_of_blocks = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cargo_no_weight = new System.Windows.Forms.RadioButton();
            this.cargo_weight = new System.Windows.Forms.RadioButton();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.activate_small_container = new System.Windows.Forms.CheckBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.activate_medium_container = new System.Windows.Forms.CheckBox();
            this.small_container_quantity = new System.Windows.Forms.TextBox();
            this.activate_large_container = new System.Windows.Forms.CheckBox();
            this.medium_container_quantity = new System.Windows.Forms.TextBox();
            this.large_container_quantity = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.user_location_choice = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.user_entered_value = new System.Windows.Forms.TextBox();
            this.activate_containers = new System.Windows.Forms.CheckBox();
            this.gravityhight_text = new System.Windows.Forms.Label();
            this.gforce_text = new System.Windows.Forms.Label();
            this.button_calculation = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.newton_result = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.label14 = new System.Windows.Forms.Label();
            this.energy_consumption_small = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.energy_consumption_large = new System.Windows.Forms.TextBox();
            this.small_atmospheric_thrusters_quantity = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.large_atmospheric_thrusters_quantity = new System.Windows.Forms.TextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.label15 = new System.Windows.Forms.Label();
            this.fuel_consumption_small = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.small_hydrogen_thrusters_quantity = new System.Windows.Forms.TextBox();
            this.fuel_consumption_large = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.large_hydrogen_thrusters_quantity = new System.Windows.Forms.TextBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.label16 = new System.Windows.Forms.Label();
            this.ion_consumption_small = new System.Windows.Forms.TextBox();
            this.ion_consumption_large = new System.Windows.Forms.TextBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.label11 = new System.Windows.Forms.Label();
            this.small_ion_thrusters_quantity = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.large_ion_thrusters_quantity = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.height_of_gravity = new System.Windows.Forms.TextBox();
            this.gravity_location = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            this.groupBox7.SuspendLayout();
            this.SuspendLayout();
            // 
            // type_of_blocks
            // 
            this.type_of_blocks.BackColor = System.Drawing.SystemColors.Window;
            this.type_of_blocks.FormattingEnabled = true;
            this.type_of_blocks.Items.AddRange(new object[] {
            "Большие",
            "Малые"});
            this.type_of_blocks.Location = new System.Drawing.Point(65, 35);
            this.type_of_blocks.Name = "type_of_blocks";
            this.type_of_blocks.Size = new System.Drawing.Size(121, 23);
            this.type_of_blocks.TabIndex = 0;
            this.toolTip1.SetToolTip(this.type_of_blocks, "Choose type of grid");
            this.type_of_blocks.SelectedIndexChanged += new System.EventHandler(this.type_of_blocks_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "1. Выберите тип блоков";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.user_location_choice);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.user_entered_value);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.type_of_blocks);
            this.groupBox1.Controls.Add(this.activate_containers);
            this.groupBox1.Location = new System.Drawing.Point(10, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(260, 349);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cargo_no_weight);
            this.groupBox2.Controls.Add(this.cargo_weight);
            this.groupBox2.Controls.Add(this.pictureBox4);
            this.groupBox2.Controls.Add(this.pictureBox3);
            this.groupBox2.Controls.Add(this.activate_small_container);
            this.groupBox2.Controls.Add(this.pictureBox2);
            this.groupBox2.Controls.Add(this.activate_medium_container);
            this.groupBox2.Controls.Add(this.small_container_quantity);
            this.groupBox2.Controls.Add(this.activate_large_container);
            this.groupBox2.Controls.Add(this.medium_container_quantity);
            this.groupBox2.Controls.Add(this.large_container_quantity);
            this.groupBox2.Location = new System.Drawing.Point(10, 183);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(244, 160);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            // 
            // cargo_no_weight
            // 
            this.cargo_no_weight.AutoSize = true;
            this.cargo_no_weight.Enabled = false;
            this.cargo_no_weight.Location = new System.Drawing.Point(12, 30);
            this.cargo_no_weight.Name = "cargo_no_weight";
            this.cargo_no_weight.Size = new System.Drawing.Size(188, 19);
            this.cargo_no_weight.TabIndex = 12;
            this.cargo_no_weight.Text = "Не учитывать вес контейнера";
            this.cargo_no_weight.UseVisualStyleBackColor = true;
            this.cargo_no_weight.CheckedChanged += new System.EventHandler(this.cargo_no_weight_CheckedChanged);
            // 
            // cargo_weight
            // 
            this.cargo_weight.AutoSize = true;
            this.cargo_weight.Enabled = false;
            this.cargo_weight.Location = new System.Drawing.Point(12, 11);
            this.cargo_weight.Name = "cargo_weight";
            this.cargo_weight.Size = new System.Drawing.Size(214, 19);
            this.cargo_weight.TabIndex = 11;
            this.cargo_weight.Text = "Учитывать вес самого контейнера";
            this.cargo_weight.UseVisualStyleBackColor = true;
            this.cargo_weight.CheckedChanged += new System.EventHandler(this.cargo_weight_CheckedChanged);
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox4.BackgroundImage")));
            this.pictureBox4.Location = new System.Drawing.Point(6, 120);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(23, 23);
            this.pictureBox4.TabIndex = 10;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox3.BackgroundImage")));
            this.pictureBox3.Location = new System.Drawing.Point(6, 91);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(23, 23);
            this.pictureBox3.TabIndex = 9;
            this.pictureBox3.TabStop = false;
            // 
            // activate_small_container
            // 
            this.activate_small_container.AutoSize = true;
            this.activate_small_container.Enabled = false;
            this.activate_small_container.Location = new System.Drawing.Point(39, 125);
            this.activate_small_container.Name = "activate_small_container";
            this.activate_small_container.Size = new System.Drawing.Size(127, 19);
            this.activate_small_container.TabIndex = 4;
            this.activate_small_container.Text = "Малый контейнер";
            this.activate_small_container.UseVisualStyleBackColor = true;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.Location = new System.Drawing.Point(6, 59);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(23, 23);
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            // 
            // activate_medium_container
            // 
            this.activate_medium_container.AutoSize = true;
            this.activate_medium_container.Enabled = false;
            this.activate_medium_container.Location = new System.Drawing.Point(39, 93);
            this.activate_medium_container.Name = "activate_medium_container";
            this.activate_medium_container.Size = new System.Drawing.Size(135, 19);
            this.activate_medium_container.TabIndex = 3;
            this.activate_medium_container.Text = "Средний контейнер";
            this.activate_medium_container.UseVisualStyleBackColor = true;
            // 
            // small_container_quantity
            // 
            this.small_container_quantity.Enabled = false;
            this.small_container_quantity.Location = new System.Drawing.Point(190, 121);
            this.small_container_quantity.Name = "small_container_quantity";
            this.small_container_quantity.Size = new System.Drawing.Size(49, 23);
            this.small_container_quantity.TabIndex = 7;
            this.small_container_quantity.TextChanged += new System.EventHandler(this.small_container_quantity_TextChanged);
            // 
            // activate_large_container
            // 
            this.activate_large_container.AutoSize = true;
            this.activate_large_container.Enabled = false;
            this.activate_large_container.Location = new System.Drawing.Point(39, 61);
            this.activate_large_container.Name = "activate_large_container";
            this.activate_large_container.Size = new System.Drawing.Size(139, 19);
            this.activate_large_container.TabIndex = 2;
            this.activate_large_container.Text = "Большой контейнер";
            this.activate_large_container.UseVisualStyleBackColor = true;
            // 
            // medium_container_quantity
            // 
            this.medium_container_quantity.Enabled = false;
            this.medium_container_quantity.Location = new System.Drawing.Point(190, 91);
            this.medium_container_quantity.Name = "medium_container_quantity";
            this.medium_container_quantity.Size = new System.Drawing.Size(49, 23);
            this.medium_container_quantity.TabIndex = 6;
            this.medium_container_quantity.TextChanged += new System.EventHandler(this.medium_container_quantity_TextChanged);
            // 
            // large_container_quantity
            // 
            this.large_container_quantity.Enabled = false;
            this.large_container_quantity.Location = new System.Drawing.Point(190, 59);
            this.large_container_quantity.Name = "large_container_quantity";
            this.large_container_quantity.Size = new System.Drawing.Size(49, 23);
            this.large_container_quantity.TabIndex = 5;
            this.large_container_quantity.TextChanged += new System.EventHandler(this.large_container_quantity_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(63, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "3. Выберите локацию";
            // 
            // user_location_choice
            // 
            this.user_location_choice.BackColor = System.Drawing.SystemColors.Window;
            this.user_location_choice.Enabled = false;
            this.user_location_choice.FormattingEnabled = true;
            this.user_location_choice.Items.AddRange(new object[] {
            "Земля",
            "Луна",
            "Марс",
            "Европа",
            "Тритон",
            "Пертам",
            "Чужая",
            "Титан"});
            this.user_location_choice.Location = new System.Drawing.Point(65, 139);
            this.user_location_choice.Name = "user_location_choice";
            this.user_location_choice.Size = new System.Drawing.Size(121, 23);
            this.user_location_choice.TabIndex = 4;
            this.user_location_choice.SelectedIndexChanged += new System.EventHandler(this.location_selector_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(59, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "2. Введите вес корабля";
            // 
            // user_entered_value
            // 
            this.user_entered_value.BackColor = System.Drawing.SystemColors.Window;
            this.user_entered_value.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.user_entered_value.Enabled = false;
            this.user_entered_value.Location = new System.Drawing.Point(65, 86);
            this.user_entered_value.Name = "user_entered_value";
            this.user_entered_value.Size = new System.Drawing.Size(121, 23);
            this.user_entered_value.TabIndex = 2;
            this.toolTip1.SetToolTip(this.user_entered_value, "Enter mass of your ship");
            this.user_entered_value.TextChanged += new System.EventHandler(this.user_entered_value_TextChanged);
            // 
            // activate_containers
            // 
            this.activate_containers.AutoSize = true;
            this.activate_containers.Enabled = false;
            this.activate_containers.Location = new System.Drawing.Point(57, 168);
            this.activate_containers.Name = "activate_containers";
            this.activate_containers.Size = new System.Drawing.Size(139, 19);
            this.activate_containers.TabIndex = 0;
            this.activate_containers.Text = "Контейнеры с рудой";
            this.activate_containers.UseVisualStyleBackColor = true;
            this.activate_containers.CheckedChanged += new System.EventHandler(this.activate_containers_CheckedChanged);
            // 
            // gravityhight_text
            // 
            this.gravityhight_text.AutoSize = true;
            this.gravityhight_text.Location = new System.Drawing.Point(28, 218);
            this.gravityhight_text.Name = "gravityhight_text";
            this.gravityhight_text.Size = new System.Drawing.Size(117, 15);
            this.gravityhight_text.TabIndex = 11;
            this.gravityhight_text.Text = "Предел гравитации:";
            // 
            // gforce_text
            // 
            this.gforce_text.AutoSize = true;
            this.gforce_text.Location = new System.Drawing.Point(49, 175);
            this.gforce_text.Name = "gforce_text";
            this.gforce_text.Size = new System.Drawing.Size(73, 15);
            this.gforce_text.TabIndex = 10;
            this.gforce_text.Text = "Гравитация:";
            // 
            // button_calculation
            // 
            this.button_calculation.Enabled = false;
            this.button_calculation.Location = new System.Drawing.Point(277, 323);
            this.button_calculation.Name = "button_calculation";
            this.button_calculation.Size = new System.Drawing.Size(112, 28);
            this.button_calculation.TabIndex = 9;
            this.button_calculation.Text = "Рассчитать";
            this.button_calculation.UseVisualStyleBackColor = true;
            this.button_calculation.Click += new System.EventHandler(this.button_calculation_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Location = new System.Drawing.Point(11, 20);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(145, 145);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // newton_result
            // 
            this.newton_result.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.newton_result.Enabled = false;
            this.newton_result.Location = new System.Drawing.Point(11, 282);
            this.newton_result.Name = "newton_result";
            this.newton_result.Size = new System.Drawing.Size(145, 23);
            this.newton_result.TabIndex = 7;
            this.newton_result.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.groupBox4);
            this.groupBox3.Controls.Add(this.groupBox5);
            this.groupBox3.Controls.Add(this.groupBox6);
            this.groupBox3.Location = new System.Drawing.Point(456, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(430, 349);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Требуемое количество ускорителей";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.pictureBox5);
            this.groupBox4.Controls.Add(this.label14);
            this.groupBox4.Controls.Add(this.energy_consumption_small);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.energy_consumption_large);
            this.groupBox4.Controls.Add(this.small_atmospheric_thrusters_quantity);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.large_atmospheric_thrusters_quantity);
            this.groupBox4.Location = new System.Drawing.Point(6, 20);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(417, 93);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Атмосферные";
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox5.BackgroundImage")));
            this.pictureBox5.Location = new System.Drawing.Point(6, 17);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(70, 70);
            this.pictureBox5.TabIndex = 8;
            this.pictureBox5.TabStop = false;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(290, 10);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(81, 15);
            this.label14.TabIndex = 5;
            this.label14.Text = "Потребление";
            // 
            // energy_consumption_small
            // 
            this.energy_consumption_small.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.energy_consumption_small.Enabled = false;
            this.energy_consumption_small.Location = new System.Drawing.Point(290, 62);
            this.energy_consumption_small.Name = "energy_consumption_small";
            this.energy_consumption_small.Size = new System.Drawing.Size(83, 23);
            this.energy_consumption_small.TabIndex = 3;
            this.energy_consumption_small.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(81, 67);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(116, 15);
            this.label7.TabIndex = 4;
            this.label7.Text = "Малые ускорители:";
            // 
            // energy_consumption_large
            // 
            this.energy_consumption_large.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.energy_consumption_large.Enabled = false;
            this.energy_consumption_large.Location = new System.Drawing.Point(290, 28);
            this.energy_consumption_large.Name = "energy_consumption_large";
            this.energy_consumption_large.Size = new System.Drawing.Size(83, 23);
            this.energy_consumption_large.TabIndex = 2;
            this.energy_consumption_large.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // small_atmospheric_thrusters_quantity
            // 
            this.small_atmospheric_thrusters_quantity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.small_atmospheric_thrusters_quantity.Enabled = false;
            this.small_atmospheric_thrusters_quantity.Location = new System.Drawing.Point(212, 62);
            this.small_atmospheric_thrusters_quantity.Name = "small_atmospheric_thrusters_quantity";
            this.small_atmospheric_thrusters_quantity.Size = new System.Drawing.Size(55, 23);
            this.small_atmospheric_thrusters_quantity.TabIndex = 3;
            this.small_atmospheric_thrusters_quantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(81, 30);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(128, 15);
            this.label6.TabIndex = 2;
            this.label6.Text = "Большие ускорители:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(216, 10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 15);
            this.label5.TabIndex = 1;
            this.label5.Text = "Кол-во";
            // 
            // large_atmospheric_thrusters_quantity
            // 
            this.large_atmospheric_thrusters_quantity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.large_atmospheric_thrusters_quantity.Enabled = false;
            this.large_atmospheric_thrusters_quantity.Location = new System.Drawing.Point(212, 27);
            this.large_atmospheric_thrusters_quantity.Name = "large_atmospheric_thrusters_quantity";
            this.large_atmospheric_thrusters_quantity.Size = new System.Drawing.Size(55, 23);
            this.large_atmospheric_thrusters_quantity.TabIndex = 0;
            this.large_atmospheric_thrusters_quantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.pictureBox6);
            this.groupBox5.Controls.Add(this.label15);
            this.groupBox5.Controls.Add(this.fuel_consumption_small);
            this.groupBox5.Controls.Add(this.label8);
            this.groupBox5.Controls.Add(this.small_hydrogen_thrusters_quantity);
            this.groupBox5.Controls.Add(this.fuel_consumption_large);
            this.groupBox5.Controls.Add(this.label9);
            this.groupBox5.Controls.Add(this.label10);
            this.groupBox5.Controls.Add(this.large_hydrogen_thrusters_quantity);
            this.groupBox5.Location = new System.Drawing.Point(6, 133);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(417, 93);
            this.groupBox5.TabIndex = 5;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Водородные";
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox6.BackgroundImage")));
            this.pictureBox6.Location = new System.Drawing.Point(6, 17);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(70, 70);
            this.pictureBox6.TabIndex = 7;
            this.pictureBox6.TabStop = false;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(290, 10);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(81, 15);
            this.label15.TabIndex = 6;
            this.label15.Text = "Потребление";
            // 
            // fuel_consumption_small
            // 
            this.fuel_consumption_small.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.fuel_consumption_small.Enabled = false;
            this.fuel_consumption_small.Location = new System.Drawing.Point(290, 63);
            this.fuel_consumption_small.Name = "fuel_consumption_small";
            this.fuel_consumption_small.Size = new System.Drawing.Size(83, 23);
            this.fuel_consumption_small.TabIndex = 1;
            this.fuel_consumption_small.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(81, 68);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(116, 15);
            this.label8.TabIndex = 4;
            this.label8.Text = "Малые ускорители:";
            // 
            // small_hydrogen_thrusters_quantity
            // 
            this.small_hydrogen_thrusters_quantity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.small_hydrogen_thrusters_quantity.Enabled = false;
            this.small_hydrogen_thrusters_quantity.Location = new System.Drawing.Point(212, 63);
            this.small_hydrogen_thrusters_quantity.Name = "small_hydrogen_thrusters_quantity";
            this.small_hydrogen_thrusters_quantity.Size = new System.Drawing.Size(55, 23);
            this.small_hydrogen_thrusters_quantity.TabIndex = 3;
            this.small_hydrogen_thrusters_quantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // fuel_consumption_large
            // 
            this.fuel_consumption_large.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.fuel_consumption_large.Enabled = false;
            this.fuel_consumption_large.Location = new System.Drawing.Point(290, 27);
            this.fuel_consumption_large.Name = "fuel_consumption_large";
            this.fuel_consumption_large.Size = new System.Drawing.Size(83, 23);
            this.fuel_consumption_large.TabIndex = 0;
            this.fuel_consumption_large.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(81, 30);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(128, 15);
            this.label9.TabIndex = 2;
            this.label9.Text = "Большие ускорители:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(216, 10);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(46, 15);
            this.label10.TabIndex = 1;
            this.label10.Text = "Кол-во";
            // 
            // large_hydrogen_thrusters_quantity
            // 
            this.large_hydrogen_thrusters_quantity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.large_hydrogen_thrusters_quantity.Enabled = false;
            this.large_hydrogen_thrusters_quantity.Location = new System.Drawing.Point(212, 27);
            this.large_hydrogen_thrusters_quantity.Name = "large_hydrogen_thrusters_quantity";
            this.large_hydrogen_thrusters_quantity.Size = new System.Drawing.Size(55, 23);
            this.large_hydrogen_thrusters_quantity.TabIndex = 0;
            this.large_hydrogen_thrusters_quantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.label16);
            this.groupBox6.Controls.Add(this.ion_consumption_small);
            this.groupBox6.Controls.Add(this.ion_consumption_large);
            this.groupBox6.Controls.Add(this.pictureBox7);
            this.groupBox6.Controls.Add(this.label11);
            this.groupBox6.Controls.Add(this.small_ion_thrusters_quantity);
            this.groupBox6.Controls.Add(this.label12);
            this.groupBox6.Controls.Add(this.label13);
            this.groupBox6.Controls.Add(this.large_ion_thrusters_quantity);
            this.groupBox6.Location = new System.Drawing.Point(6, 247);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(417, 93);
            this.groupBox6.TabIndex = 6;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Ионные";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(290, 9);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(81, 15);
            this.label16.TabIndex = 8;
            this.label16.Text = "Потребление";
            // 
            // ion_consumption_small
            // 
            this.ion_consumption_small.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ion_consumption_small.Enabled = false;
            this.ion_consumption_small.Location = new System.Drawing.Point(290, 61);
            this.ion_consumption_small.Name = "ion_consumption_small";
            this.ion_consumption_small.Size = new System.Drawing.Size(83, 23);
            this.ion_consumption_small.TabIndex = 7;
            this.ion_consumption_small.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ion_consumption_large
            // 
            this.ion_consumption_large.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ion_consumption_large.Enabled = false;
            this.ion_consumption_large.Location = new System.Drawing.Point(290, 26);
            this.ion_consumption_large.Name = "ion_consumption_large";
            this.ion_consumption_large.Size = new System.Drawing.Size(83, 23);
            this.ion_consumption_large.TabIndex = 6;
            this.ion_consumption_large.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pictureBox7
            // 
            this.pictureBox7.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox7.BackgroundImage")));
            this.pictureBox7.Location = new System.Drawing.Point(6, 17);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(70, 70);
            this.pictureBox7.TabIndex = 5;
            this.pictureBox7.TabStop = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(81, 66);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(116, 15);
            this.label11.TabIndex = 4;
            this.label11.Text = "Малые ускорители:";
            // 
            // small_ion_thrusters_quantity
            // 
            this.small_ion_thrusters_quantity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.small_ion_thrusters_quantity.Enabled = false;
            this.small_ion_thrusters_quantity.Location = new System.Drawing.Point(212, 61);
            this.small_ion_thrusters_quantity.Name = "small_ion_thrusters_quantity";
            this.small_ion_thrusters_quantity.Size = new System.Drawing.Size(55, 23);
            this.small_ion_thrusters_quantity.TabIndex = 3;
            this.small_ion_thrusters_quantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(81, 29);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(128, 15);
            this.label12.TabIndex = 2;
            this.label12.Text = "Большие ускорители:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(216, 9);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(46, 15);
            this.label13.TabIndex = 1;
            this.label13.Text = "Кол-во";
            // 
            // large_ion_thrusters_quantity
            // 
            this.large_ion_thrusters_quantity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.large_ion_thrusters_quantity.Enabled = false;
            this.large_ion_thrusters_quantity.Location = new System.Drawing.Point(212, 26);
            this.large_ion_thrusters_quantity.Name = "large_ion_thrusters_quantity";
            this.large_ion_thrusters_quantity.Size = new System.Drawing.Size(55, 23);
            this.large_ion_thrusters_quantity.TabIndex = 0;
            this.large_ion_thrusters_quantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 264);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(162, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "Требуемая сила двигателей:";
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.label4);
            this.groupBox7.Controls.Add(this.newton_result);
            this.groupBox7.Controls.Add(this.height_of_gravity);
            this.groupBox7.Controls.Add(this.gravity_location);
            this.groupBox7.Controls.Add(this.pictureBox1);
            this.groupBox7.Controls.Add(this.gravityhight_text);
            this.groupBox7.Controls.Add(this.gforce_text);
            this.groupBox7.Location = new System.Drawing.Point(277, 2);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(169, 315);
            this.groupBox7.TabIndex = 12;
            this.groupBox7.TabStop = false;
            // 
            // height_of_gravity
            // 
            this.height_of_gravity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.height_of_gravity.Enabled = false;
            this.height_of_gravity.Location = new System.Drawing.Point(59, 237);
            this.height_of_gravity.Name = "height_of_gravity";
            this.height_of_gravity.Size = new System.Drawing.Size(55, 23);
            this.height_of_gravity.TabIndex = 13;
            this.height_of_gravity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // gravity_location
            // 
            this.gravity_location.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gravity_location.Enabled = false;
            this.gravity_location.Location = new System.Drawing.Point(59, 193);
            this.gravity_location.Name = "gravity_location";
            this.gravity_location.Size = new System.Drawing.Size(55, 23);
            this.gravity_location.TabIndex = 12;
            this.gravity_location.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button1.Location = new System.Drawing.Point(388, 323);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(30, 28);
            this.button1.TabIndex = 13;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button2.Location = new System.Drawing.Point(417, 323);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(30, 28);
            this.button2.TabIndex = 14;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(896, 359);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.button_calculation);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private ComboBox type_of_blocks;
        private Label label1;
        private GroupBox groupBox1;
        private Label label2;
        private TextBox user_entered_value;
        private Label label3;
        private ComboBox user_location_choice;
        private PictureBox pictureBox1;
        private TextBox newton_result;
        private GroupBox groupBox2;
        private CheckBox activate_containers;
        private TextBox small_container_quantity;
        private TextBox medium_container_quantity;
        private TextBox large_container_quantity;
        private CheckBox activate_small_container;
        private CheckBox activate_medium_container;
        private CheckBox activate_large_container;
        private GroupBox groupBox3;
        private PictureBox pictureBox4;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private Button button_calculation;
        private Label label4;
        private GroupBox groupBox4;
        private Label label7;
        private TextBox small_atmospheric_thrusters_quantity;
        private Label label6;
        private Label label5;
        private TextBox large_atmospheric_thrusters_quantity;
        private Label gravityhight_text;
        private Label gforce_text;
        private GroupBox groupBox5;
        private Label label8;
        private TextBox small_hydrogen_thrusters_quantity;
        private Label label9;
        private Label label10;
        private TextBox large_hydrogen_thrusters_quantity;
        private GroupBox groupBox6;
        private Label label11;
        private TextBox small_ion_thrusters_quantity;
        private Label label12;
        private Label label13;
        private TextBox large_ion_thrusters_quantity;
        private GroupBox groupBox7;
        private TextBox gravity_location;
        private TextBox height_of_gravity;
        private Button button1;
        private Button button2;
        private TextBox fuel_consumption_small;
        private TextBox fuel_consumption_large;
        private TextBox energy_consumption_large;
        private TextBox energy_consumption_small;
        private Label label14;
        private Label label15;
        private PictureBox pictureBox6;
        private PictureBox pictureBox7;
        private PictureBox pictureBox5;
        private TextBox ion_consumption_small;
        private TextBox ion_consumption_large;
        private Label label16;
        private ToolTip toolTip1;
        private RadioButton cargo_no_weight;
        private RadioButton cargo_weight;
    }
}