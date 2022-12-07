using System.Transactions;

namespace SE_Fight_Gravity
{
    public partial class Form1 : Form
    {
        #region Variables
        public const decimal newton = 9807;
        public decimal g_amount = 1;
        public decimal total_newton_value = 0;
        public decimal user_value_kg = 0;
        public decimal large_container_parsed = 0;
        public decimal medium_container_parsed = 0;
        public decimal small_container_parsed = 0;
        public decimal cargo_multiplier_set = 1;
        public decimal mass_summary_set = 0;

        // Engine Specs
        public const decimal large_hydrogen_largegrid = 7200000; // Водородные ускорители
        public const decimal small_hydrogen_largegrid = 1080000;
        public const decimal large_hydrogen_smallgrid = 4800000;
        public const decimal small_hydrogen_smallgrid = 98400;
        public const decimal large_hydrogen_largegrid_fuel = 4822; // Литров в секунду
        public const decimal small_hydrogen_largegrid_fuel = 804; // Литра в секунду
        public const decimal large_hydrogen_smallgrid_fuel = 386; // Литров в секунду
        public const decimal small_hydrogen_smallgrid_fuel = 81; // Литр в секунду

        public const decimal large_atmospheric_largegrid = 4500000; // Атмосферные ускорители
        public const decimal small_atmospheric_largegrid = 350000;
        public const decimal large_atmospheric_smallgrid = 340000;
        public const decimal small_atmospheric_smallgrid = 65000;
        public const decimal large_atmospheric_largegrid_fuel = 16360000; // MW
        public const decimal small_atmospheric_largegrid_fuel = 2360000; // MW
        public const decimal large_atmospheric_smallgrid_fuel = 2400000; // MW
        public const decimal small_atmospheric_smallgrid_fuel = 700000; // MW

        public const decimal large_ion_largegrid = 4320000; // Ионные ускорители
        public const decimal small_ion_largegrid = 345600;
        public const decimal large_ion_smallgrid = 172800;
        public const decimal small_ion_smallgrid = 14400;
        public const decimal large_ion_largegrid_fuel = 33600000; // MW
        public const decimal small_ion_largegrid_fuel = 3360000; // MW
        public const decimal large_ion_smallgrid_fuel = 2400000; // MW
        public const decimal small_ion_smallgrid_fuel = 200000; // MW

        // Large cargo Container
        public const decimal largecargocontainer_mass_largegrid = 2500; // KG
        public const decimal largecargocontainer_mass_smallgrid = 260; // KG
        public const decimal largecargocontainer_with_uranium_largegrid = 1140203; // KG Контейнеры полные урана
        public const decimal largecargocontainer_with_uranium_smallgrid = 42234; //KG
        // Medium Cargo Container NOTE: Availiable only for small blocks.
        public const decimal mediumcargocontainer_mass_smallgrid = 151; // KG
        public const decimal mediumcontainer_with_uranium_smallgrid = 9123; // KG
        // Small Cargo Container
        public const int smallcargocontainer_mass_largegrid = 576; // KG
        public const int smallcargocontainer_mass_smallgrid = 73; // KG
        public decimal smallcargocontainer_with_uranium_largegrid = 42234; //KG
        public decimal smallcargocontainer_with_uranium_smallgrid = 337; //KG // Recalculate


        #endregion

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cargo_multiplier.SelectedIndex = 0;
            large_container_quantity.Text = "0";
            medium_container_quantity.Text = "0";
            small_container_quantity.Text = "0";
            gravity_location.Text = "...";
            height_of_gravity.Text = "...";
            summary_mass.Text = "...";
            newton_result.Text = "...";
            large_atmospheric_thrusters_quantity.Text = "...";
            small_atmospheric_thrusters_quantity.Text= "...";
            large_hydrogen_thrusters_quantity.Text = "...";
            small_hydrogen_thrusters_quantity.Text = "...";
            large_ion_thrusters_quantity.Text = "...";
            small_ion_thrusters_quantity.Text = "...";
            energy_consumption_large.Text = "...";
            energy_consumption_small.Text = "...";
            fuel_consumption_large.Text= "...";
            fuel_consumption_small.Text= "...";
            ion_consumption_large.Text = "...";
            ion_consumption_small.Text = "...";
        }

        private void type_of_blocks_SelectedIndexChanged(object sender, EventArgs e)
        {
            user_entered_value.Enabled = true;
            user_entered_value.BackColor = Color.Bisque;
        }

        private void user_entered_value_TextChanged(object sender, EventArgs e)
        {
            user_location_choice.Enabled = true;
            user_location_choice.BackColor = Color.Bisque;
            this.user_value_kg = decimal.Parse(user_entered_value.Text);
        }

        private void location_selector_SelectedIndexChanged(object sender, EventArgs e)
        {
            button_calculation.Enabled = true;
            activate_containers.Enabled = true;
            gravity_location.Enabled = true;
            height_of_gravity.Enabled = true;

            if (user_location_choice.SelectedIndex == 0) // Earthlike
            {
                this.g_amount = 9807; // 1g
                gravity_location.Text = "1g";
                height_of_gravity.Text = "42.860м";
                pictureBox1.Image = Image.FromFile("C:\\Users\\Greg\\Desktop\\img\\earthlike_planet.png");
            }
            if (user_location_choice.SelectedIndex == 1) // Moon
            {
                this.g_amount = 2451; // 0.25g in Newtons
                gravity_location.Text = "0.25g";
                height_of_gravity.Text = "2.678м";
                pictureBox1.Image = Image.FromFile("C:\\Users\\Greg\\Desktop\\img\\moon_planet.png");
            }
            if (user_location_choice.SelectedIndex == 2) // Mars
            {
                this.g_amount = 8826; // 0.90g in Newtons
                gravity_location.Text = "0.90g";
                height_of_gravity.Text = "39.311м";
                pictureBox1.Image = Image.FromFile("C:\\Users\\Greg\\Desktop\\img\\mars_planet.png");
            }
            if (user_location_choice.SelectedIndex == 3) // Europa
            {
                this.g_amount = 2451; // 0.25g in Newtons
                gravity_location.Text = "0.25g";
                height_of_gravity.Text = "3.150м";
                pictureBox1.Image = Image.FromFile("C:\\Users\\Greg\\Desktop\\img\\europa_planet.png");
            }
            if (user_location_choice.SelectedIndex == 4) // Triton
            {
                this.g_amount = 9807; // 1g
                gravity_location.Text = "1g";
                height_of_gravity.Text = "36000м";
                pictureBox1.Image = Image.FromFile("C:\\Users\\Greg\\Desktop\\img\\triton_planet.png");
            }
            if (user_location_choice.SelectedIndex == 5) // Pertam
            {
                this.g_amount = 11768; // 1.20g in Newtons
                gravity_location.Text = "1.20g";
                height_of_gravity.Text = "18.510м";
                pictureBox1.Image = Image.FromFile("C:\\Users\\Greg\\Desktop\\img\\pertam_planet.png");
            }
            if (user_location_choice.SelectedIndex == 6) // Alien planet
            {
                this.g_amount = 10787; // 1.10g in Newtons
                gravity_location.Text = "1.10g";
                height_of_gravity.Text = "39.870м";
                pictureBox1.Image = Image.FromFile("C:\\Users\\Greg\\Desktop\\img\\alien_planet.png");
            }
            if (user_location_choice.SelectedIndex == 7) // Titan
            {
                this.g_amount = 2451; // 0.25g in Newtons
                gravity_location.Text = "0.25g";
                height_of_gravity.Text = "Уточнить";
                pictureBox1.Image = Image.FromFile("C:\\Users\\Greg\\Desktop\\img\\titan_planet.png");
            }
        }

        private void button_calculation_Click(object sender, EventArgs e)
        {
            if (cargo_multiplier.SelectedIndex == 0)
            {
                this.cargo_multiplier_set = 1;
            }
            if (cargo_multiplier.SelectedIndex == 1)
            {
                this.cargo_multiplier_set = 3;
            }
            if (cargo_multiplier.SelectedIndex == 2)
            {
                this.cargo_multiplier_set = 5;
            }
            if (cargo_multiplier.SelectedIndex == 3)
            {
                this.cargo_multiplier_set = 10;
            }

            summary_mass.Enabled = true;
            newton_result.Enabled= true;
            large_atmospheric_thrusters_quantity.Enabled = true;
            small_atmospheric_thrusters_quantity.Enabled = true;
            large_hydrogen_thrusters_quantity.Enabled = true;
            small_hydrogen_thrusters_quantity.Enabled = true;
            large_ion_thrusters_quantity.Enabled = true;
            small_ion_thrusters_quantity.Enabled = true;
            energy_consumption_large.Enabled = true;
            energy_consumption_small.Enabled = true;
            fuel_consumption_large.Enabled = true;
            fuel_consumption_small.Enabled = true;
            ion_consumption_large.Enabled = true;
            ion_consumption_small.Enabled = true;

            #region Рассчет для больших блоков
            // LG
            if (type_of_blocks.SelectedIndex == 0)
            {
                this.mass_summary_set = user_value_kg;
                this.total_newton_value = g_amount * user_value_kg / 1000;
                calc_for_largegrid(total_newton_value);
            }
            // LG + weight included + large container
            if (type_of_blocks.SelectedIndex == 0 & activate_containers.Checked == true & full_of_ore.Checked == true & activate_large_container.Checked == true)
            {
                this.mass_summary_set = ((largecargocontainer_mass_largegrid * large_container_parsed) + (largecargocontainer_with_uranium_largegrid * large_container_parsed)) * cargo_multiplier_set + user_value_kg;
                this.total_newton_value = mass_summary_set * g_amount / 1000;
                calc_for_largegrid(total_newton_value);
            }
            //LG + weight not included + large container
            if (type_of_blocks.SelectedIndex == 0 & activate_containers.Checked == true & without_ore.Checked == true & activate_large_container.Checked == true)
            {
                this.mass_summary_set = (largecargocontainer_with_uranium_largegrid * large_container_parsed) * cargo_multiplier_set + user_value_kg;
                this.total_newton_value = mass_summary_set * g_amount / 1000;
                calc_for_largegrid(total_newton_value);
            }
            // LG + weight included + small container
            if (type_of_blocks.SelectedIndex == 0 & activate_containers.Checked == true & full_of_ore.Checked == true & activate_small_container.Checked == true)
            {
                this.mass_summary_set = ((smallcargocontainer_mass_largegrid * small_container_parsed) + (smallcargocontainer_with_uranium_largegrid * small_container_parsed)) * cargo_multiplier_set + user_value_kg;
                this.total_newton_value = mass_summary_set * g_amount / 1000;
                calc_for_largegrid(total_newton_value);
            }
            // LG + weight not included + small conteiner
            if (type_of_blocks.SelectedIndex == 0 & activate_containers.Checked == true & without_ore.Checked == true & activate_small_container.Checked == true)
            {
                this.mass_summary_set = (smallcargocontainer_with_uranium_largegrid * small_container_parsed) * cargo_multiplier_set + user_value_kg;
                this.total_newton_value = mass_summary_set * g_amount / 1000;
                calc_for_largegrid(total_newton_value);
            }
            // LG + weight included + large and small conteiners
            if (type_of_blocks.SelectedIndex == 0 & activate_containers.Checked == true & full_of_ore.Checked == true & activate_large_container.Checked == true & activate_small_container.Checked == true)
            {
                this.mass_summary_set = ((largecargocontainer_mass_largegrid * large_container_parsed) + (largecargocontainer_with_uranium_largegrid * large_container_parsed) + (smallcargocontainer_mass_largegrid * small_container_parsed) + (smallcargocontainer_with_uranium_largegrid * small_container_parsed)) * cargo_multiplier_set + user_value_kg;
                this.total_newton_value = mass_summary_set * g_amount / 1000;
                calc_for_largegrid(total_newton_value);
            }
            // LG + weight not included + large and small conteiners
            if (type_of_blocks.SelectedIndex == 0 & activate_containers.Checked == true & without_ore.Checked == true & activate_large_container.Checked == true & activate_small_container.Checked == true)
            {
                this.total_newton_value = ((largecargocontainer_with_uranium_largegrid * large_container_parsed) + (smallcargocontainer_with_uranium_largegrid * small_container_parsed)) * cargo_multiplier_set + user_value_kg;
                calc_for_largegrid(total_newton_value);
            }
            #endregion
            #region Рассчет для маленьких блоков
            // SG
            if (type_of_blocks.SelectedIndex == 1)
            {
                this.mass_summary_set = user_value_kg;
                this.total_newton_value = g_amount * user_value_kg / 1000;
                calc_for_smallgrid(total_newton_value);
            }
            // SG + weight include + large container
            if (type_of_blocks.SelectedIndex == 1 & activate_containers.Checked == true & full_of_ore.Checked == true & activate_large_container.Checked == true)
            {
                this.mass_summary_set = ((largecargocontainer_mass_smallgrid * large_container_parsed) + (largecargocontainer_with_uranium_smallgrid * large_container_parsed)) * cargo_multiplier_set + user_value_kg;
                this.total_newton_value = mass_summary_set * g_amount / 1000;
                calc_for_smallgrid(total_newton_value);
            }
            // SG + weight not include + large container
            if (type_of_blocks.SelectedIndex == 1 & activate_containers.Checked == true & without_ore.Checked == true & activate_large_container.Checked == true)
            {
                this.mass_summary_set = (largecargocontainer_with_uranium_smallgrid * large_container_parsed) * cargo_multiplier_set + user_value_kg;
                this.total_newton_value = mass_summary_set * g_amount / 1000;
                calc_for_smallgrid(total_newton_value);
            }
            // SG + weight include + medium container
            if (type_of_blocks.SelectedIndex == 1 & activate_containers.Checked == true & full_of_ore.Checked == true & activate_medium_container.Checked == true)
            {
                this.mass_summary_set = ((mediumcargocontainer_mass_smallgrid * medium_container_parsed) + (mediumcontainer_with_uranium_smallgrid * medium_container_parsed)) * cargo_multiplier_set + user_value_kg;
                this.total_newton_value = mass_summary_set * g_amount / 1000;
                calc_for_smallgrid(total_newton_value);
            }
            // SG + weight not included + medium container
            if (type_of_blocks.SelectedIndex == 1 & activate_containers.Checked == true & without_ore.Checked == true & activate_medium_container.Checked == true)
            {
                this.mass_summary_set = (mediumcontainer_with_uranium_smallgrid * medium_container_parsed) * cargo_multiplier_set + user_value_kg;
                this. total_newton_value = mass_summary_set * g_amount / 1000;
                calc_for_smallgrid(total_newton_value);
            }
            // SG + weight included + small container
            if (type_of_blocks.SelectedIndex == 1 & activate_containers.Checked == true & full_of_ore.Checked == true & activate_small_container.Checked == true)
            {
                this.mass_summary_set = ((smallcargocontainer_mass_smallgrid * small_container_parsed) + (smallcargocontainer_with_uranium_smallgrid * small_container_parsed)) * cargo_multiplier_set + user_value_kg;
                this.total_newton_value = mass_summary_set * g_amount / 1000;
                calc_for_smallgrid(total_newton_value);
            }
            // SG + weight not included + small container
            if (type_of_blocks.SelectedIndex == 1 & activate_containers.Checked == true & without_ore.Checked == true & activate_small_container.Checked == true)
            {
                this.mass_summary_set = (smallcargocontainer_with_uranium_smallgrid * small_container_parsed) * cargo_multiplier_set + user_value_kg;
                this.total_newton_value = mass_summary_set * g_amount / 1000;
                calc_for_smallgrid(total_newton_value);
            }
            // SG + weight include + large and medium containers
            if (type_of_blocks.SelectedIndex == 1 & activate_containers.Checked == true & full_of_ore.Checked == true & activate_large_container.Checked == true & activate_medium_container.Checked == true)
            {
                calc_for_smallgrid(total_newton_value);
                this.mass_summary_set = ((largecargocontainer_mass_smallgrid * large_container_parsed + largecargocontainer_with_uranium_smallgrid * large_container_parsed) + (mediumcargocontainer_mass_smallgrid * medium_container_parsed + mediumcontainer_with_uranium_smallgrid * medium_container_parsed)) * cargo_multiplier_set + user_value_kg;
                this.total_newton_value = mass_summary_set * g_amount / 1000;
            }
            // SG + weight not included + large and medium containers
            if (type_of_blocks.SelectedIndex == 1 & activate_containers.Checked == true & without_ore.Checked == true & activate_large_container.Checked == true & activate_medium_container.Checked == true)
            {
                this.mass_summary_set = ((largecargocontainer_with_uranium_smallgrid * large_container_parsed) + (mediumcontainer_with_uranium_smallgrid * medium_container_parsed)) * cargo_multiplier_set + user_value_kg;
                this.total_newton_value = mass_summary_set * g_amount / 1000;
                calc_for_smallgrid(total_newton_value);
            }
            //SG + weight included + large small containers
            if (type_of_blocks.SelectedIndex == 1 & activate_containers.Checked == true & full_of_ore.Checked == true & activate_large_container.Checked == true & activate_small_container.Checked == true)
            {
                this.mass_summary_set = ((largecargocontainer_mass_smallgrid * large_container_parsed + largecargocontainer_with_uranium_smallgrid * large_container_parsed) + (smallcargocontainer_mass_smallgrid * small_container_parsed + smallcargocontainer_with_uranium_smallgrid * small_container_parsed)) * cargo_multiplier_set + user_value_kg;
                this.total_newton_value = mass_summary_set * g_amount / 1000;
                calc_for_smallgrid(total_newton_value);
            }
            //SG + weight not included + large small containers
            if (type_of_blocks.SelectedIndex == 1 & activate_containers.Checked == true & without_ore.Checked == true & activate_large_container.Checked == true & activate_small_container.Checked == true)
            {
                calc_for_smallgrid(total_newton_value);
                this.mass_summary_set = ((largecargocontainer_with_uranium_smallgrid * large_container_parsed + smallcargocontainer_with_uranium_smallgrid * small_container_parsed)) * cargo_multiplier_set + user_value_kg;
                this.total_newton_value = mass_summary_set * g_amount / 1000;
            }
            //SG + weight included + large medium small containers
            if (type_of_blocks.SelectedIndex == 1 & activate_containers.Checked == true & full_of_ore.Checked == true & activate_large_container.Checked == true & activate_medium_container.Checked == true & activate_small_container.Checked == true)
            {
                calc_for_smallgrid(total_newton_value);
                this.mass_summary_set = ((largecargocontainer_mass_smallgrid * large_container_parsed + largecargocontainer_with_uranium_smallgrid * large_container_parsed) + (mediumcargocontainer_mass_smallgrid * medium_container_parsed + mediumcontainer_with_uranium_smallgrid * medium_container_parsed) + (smallcargocontainer_mass_smallgrid * small_container_parsed + smallcargocontainer_with_uranium_smallgrid * small_container_parsed)) * cargo_multiplier_set + user_value_kg;
                this.total_newton_value = mass_summary_set * g_amount / 1000;
            }
            //SG + weight not included + large medium small containers
            if (type_of_blocks.SelectedIndex == 1 & activate_containers.Checked == true & without_ore.Checked == true & activate_large_container.Checked == true & activate_medium_container.Checked == true & activate_small_container.Checked == true)
            {
                calc_for_smallgrid(total_newton_value);
                this.mass_summary_set = (largecargocontainer_with_uranium_smallgrid * large_container_parsed + mediumcontainer_with_uranium_smallgrid * medium_container_parsed + smallcargocontainer_with_uranium_smallgrid * small_container_parsed) * cargo_multiplier_set + user_value_kg;
                this.total_newton_value = mass_summary_set * g_amount / 1000;
            }
            //SG + weight include + medium small containers
            if (type_of_blocks.SelectedIndex == 1 & activate_containers.Checked == true & full_of_ore.Checked == true & activate_medium_container.Checked == true & activate_small_container.Checked == true)
            {
                this.mass_summary_set = (mediumcargocontainer_mass_smallgrid * medium_container_parsed + mediumcontainer_with_uranium_smallgrid * medium_container_parsed + smallcargocontainer_mass_smallgrid * small_container_parsed + smallcargocontainer_with_uranium_smallgrid * small_container_parsed) * cargo_multiplier_set + user_value_kg;
                this.total_newton_value = mass_summary_set * g_amount / 1000;
                calc_for_smallgrid(total_newton_value);
            }
            //SG + weight not include + medium small containers
            if (type_of_blocks.SelectedIndex == 1 & activate_containers.Checked == true & without_ore.Checked == true & activate_medium_container.Checked == true & activate_small_container.Checked == true)
            {
                this.mass_summary_set = (mediumcargocontainer_mass_smallgrid * medium_container_parsed + mediumcontainer_with_uranium_smallgrid * medium_container_parsed + smallcargocontainer_mass_smallgrid * small_container_parsed + smallcargocontainer_with_uranium_smallgrid * small_container_parsed) * cargo_multiplier_set + user_value_kg;
                this.total_newton_value = mass_summary_set * g_amount / 1000;
                calc_for_smallgrid(total_newton_value);
            }

            summary_mass.Text = mass_summary_set.ToString();
            #endregion
        }

        #region Calculation Power Methods
        private void calc_for_largegrid(decimal newtons)
        {
            decimal large_atmospheric_largegrid_quantity = newtons / large_atmospheric_largegrid; // Атмосферные ускорители
            large_atmospheric_thrusters_quantity.Text = Math.Ceiling(large_atmospheric_largegrid_quantity).ToString();

            decimal small_atmospheric_largegrid_quantity = newtons / small_atmospheric_largegrid;
            small_atmospheric_thrusters_quantity.Text = Math.Ceiling(small_atmospheric_largegrid_quantity).ToString();

            decimal large_hydrogen_largegrid_quantity = newtons / large_hydrogen_largegrid; // Водородные ускорители
            large_hydrogen_thrusters_quantity.Text = Math.Ceiling(large_hydrogen_largegrid_quantity).ToString();

            decimal small_hydrogen_largegrid_quantity = newtons / small_hydrogen_largegrid;
            small_hydrogen_thrusters_quantity.Text = Math.Ceiling(small_hydrogen_largegrid_quantity).ToString();

            decimal large_ion_largegrid_quantity = newtons / large_ion_largegrid; // Ионные ускорители
            large_ion_thrusters_quantity.Text = Math.Ceiling(large_ion_largegrid_quantity).ToString();

            decimal small_ion_largegrid_quantity = newtons / small_ion_largegrid;
            small_ion_thrusters_quantity.Text = Math.Ceiling(small_ion_largegrid_quantity).ToString();

            hydrogen_consumption(large_hydrogen_largegrid_quantity, small_hydrogen_largegrid_quantity, large_hydrogen_largegrid_fuel, small_hydrogen_largegrid_fuel);
            atmospheric_consumption(large_atmospheric_largegrid_quantity, small_atmospheric_largegrid_quantity, large_atmospheric_largegrid_fuel, small_atmospheric_largegrid_fuel);
            ion_consumption(large_ion_largegrid_quantity, small_ion_largegrid_quantity, large_ion_largegrid_fuel, small_ion_largegrid_fuel);
            newton_result.Text = Math.Ceiling(total_newton_value).ToString() + " N";
        }
        private void calc_for_smallgrid(decimal newtons)
        {
            decimal large_atmospheric_smallgrid_quantity = newtons / large_atmospheric_smallgrid; // Атмосферные ускорители
            large_atmospheric_thrusters_quantity.Text = Math.Ceiling(large_atmospheric_smallgrid_quantity).ToString();

            decimal small_atmospheric_smallgrid_quantity = newtons / small_atmospheric_smallgrid;
            small_atmospheric_thrusters_quantity.Text = Math.Ceiling(small_atmospheric_smallgrid_quantity).ToString();

            decimal large_hydrogen_smallgrid_quantity = newtons / large_hydrogen_smallgrid; // Водородные ускорители
            large_hydrogen_thrusters_quantity.Text = Math.Ceiling(large_hydrogen_smallgrid_quantity).ToString();

            decimal small_hydrogen_smallgrid_quantity = newtons / small_hydrogen_smallgrid;
            small_hydrogen_thrusters_quantity.Text = Math.Ceiling(small_hydrogen_smallgrid_quantity).ToString();

            decimal large_ion_smallgrid_quantity = newtons / large_ion_smallgrid; // Ионные ускорители
            large_ion_thrusters_quantity.Text = Math.Ceiling(large_ion_smallgrid_quantity).ToString();

            decimal small_ion_smallgrid_quantity = newtons / small_ion_smallgrid;
            small_ion_thrusters_quantity.Text = Math.Ceiling(small_ion_smallgrid_quantity).ToString();

            hydrogen_consumption(large_hydrogen_smallgrid_quantity, small_hydrogen_smallgrid_quantity, large_hydrogen_smallgrid_fuel, small_hydrogen_smallgrid_fuel);
            atmospheric_consumption(large_atmospheric_smallgrid_quantity, small_atmospheric_smallgrid_quantity, large_atmospheric_smallgrid_fuel, small_atmospheric_smallgrid_fuel);
            ion_consumption(large_ion_smallgrid_quantity, small_ion_smallgrid_quantity, large_ion_smallgrid_fuel, small_ion_smallgrid_fuel);
            newton_result.Text = Math.Ceiling(total_newton_value).ToString() + " N";
        }

        private void hydrogen_consumption(decimal largehydrogen, decimal smallhydrogen, decimal largefuel, decimal smallfuel)
        {
            decimal fuel_consume_large = Math.Ceiling(largehydrogen) * largefuel;
            fuel_consumption_large.Text = Math.Ceiling(fuel_consume_large).ToString() + " Л/С";

            decimal fuel_consume_small = Math.Ceiling(smallhydrogen * smallfuel);
            fuel_consumption_small.Text = Math.Ceiling(fuel_consume_small).ToString() + " Л/С";
        }

        private void atmospheric_consumption(decimal largeatm, decimal smallatm, decimal largeatmfuel, decimal smallatmfuel)
        {
            decimal atm_consume_large = Math.Ceiling(largeatm) * largeatmfuel / 1000000;
            energy_consumption_large.Text = Math.Ceiling(atm_consume_large).ToString() + " MW";

            decimal atm_consume_small = Math.Ceiling(smallatm) * smallatmfuel / 1000000;
            energy_consumption_small.Text = Math.Ceiling(atm_consume_small).ToString() + " MW";
        }

        private void ion_consumption(decimal largeion, decimal smallion, decimal largeionfuel, decimal smallionfuel)
        {
            decimal ion_consume_large = Math.Ceiling(largeion) * largeionfuel / 1000000;
            ion_consumption_large.Text = Math.Ceiling(ion_consume_large).ToString() + " MW";

            decimal ion_consume_small = Math.Ceiling(smallion) * smallionfuel / 1000000;
            ion_consumption_small.Text = Math.Ceiling(ion_consume_small).ToString() + " MW";
        }
        #endregion
        private void activate_containers_CheckedChanged(object sender, EventArgs e)
        {
            if (type_of_blocks.SelectedIndex == 0 & activate_containers.Checked == true)
            {
                cargo_multiplier.Enabled = true;
                full_of_ore.Checked = true;
                full_of_ore.Enabled = true;
                without_ore.Enabled = true;
                activate_large_container.Enabled = true;
                large_container_quantity.Enabled = true;
                activate_medium_container.Enabled = false;
                medium_container_quantity.Enabled = false;
                activate_small_container.Enabled = true;
                small_container_quantity.Enabled = true;
            }
            if (type_of_blocks.SelectedIndex == 0 & activate_containers.Checked == false)
            {
                cargo_multiplier.Enabled = false;
                full_of_ore.Enabled = false;
                without_ore.Enabled = false;
                full_of_ore.Checked = false;
                without_ore.Checked = false;
                activate_large_container.Enabled = false;
                large_container_quantity.Enabled = false;
                activate_medium_container.Enabled = false;
                medium_container_quantity.Enabled = false;
                activate_small_container.Enabled = false;
                small_container_quantity.Enabled = false;
            }
            if (type_of_blocks.SelectedIndex == 1 & activate_containers.Checked == true)
            {
                cargo_multiplier.Enabled = true;
                full_of_ore.Enabled = true;
                full_of_ore.Checked = true;
                without_ore.Enabled = true;
                activate_large_container.Enabled = true;
                large_container_quantity.Enabled = true;
                activate_medium_container.Enabled = true;
                medium_container_quantity.Enabled = true;
                activate_small_container.Enabled = true;
                small_container_quantity.Enabled = true;
            }
            if (type_of_blocks.SelectedIndex == 1 & activate_containers.Checked == false)
            {
                cargo_multiplier.Enabled = false;
                large_container_quantity.BackColor = Color.White;
                full_of_ore.Enabled = false;
                without_ore.Enabled = false;
                full_of_ore.Checked = false;
                without_ore.Checked = false;
                activate_large_container.Enabled = false;
                large_container_quantity.Enabled = false;
                activate_medium_container.Enabled = false;
                medium_container_quantity.Enabled = false;
                activate_small_container.Enabled = false;
                small_container_quantity.Enabled = false;
            }
        }

        private void cargo_no_weight_CheckedChanged(object sender, EventArgs e)
        {
            if (without_ore.Checked== true)
            {
                full_of_ore.Checked = false;
            }
        }

        private void cargo_weight_CheckedChanged(object sender, EventArgs e)
        {
            if (full_of_ore.Checked == true)
            {
                without_ore.Checked= false;
            }
        }

        private void large_container_quantity_TextChanged(object sender, EventArgs e)
        {
            this.large_container_parsed = decimal.Parse(large_container_quantity.Text);
        }

        private void small_container_quantity_TextChanged(object sender, EventArgs e)
        {
            this.small_container_parsed = decimal.Parse(small_container_quantity.Text);
        }

        private void medium_container_quantity_TextChanged(object sender, EventArgs e)
        {
            this.medium_container_parsed = decimal.Parse(medium_container_quantity.Text);
        }
        private void activate_by_pressing(object sender, EventArgs e)
        {
            summary_mass.Enabled = true;
            newton_result.Enabled = true;
            large_atmospheric_thrusters_quantity.Enabled = true;
            small_atmospheric_thrusters_quantity.Enabled = true;
            large_hydrogen_thrusters_quantity.Enabled = true;
            small_hydrogen_thrusters_quantity.Enabled = true;
            large_ion_thrusters_quantity.Enabled = true;
            small_ion_thrusters_quantity.Enabled = true;
            energy_consumption_large.Enabled = true;
            energy_consumption_small.Enabled = true;
            fuel_consumption_large.Enabled = true;
            fuel_consumption_small.Enabled = true;
            ion_consumption_large.Enabled = true;
            ion_consumption_small.Enabled = true;
        }
    }
}