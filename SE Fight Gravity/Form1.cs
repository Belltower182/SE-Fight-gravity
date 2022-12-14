namespace SE_Fight_Gravity
{
    public partial class Form1 : Form
    {
        #region Dynamic Variables

        public const double newton = 0;
        public double g_amount = 0;
        public double total_newton_value = 0;
        public double user_value_kg = 0;
        public double large_container_parsed = 0;
        public double medium_container_parsed = 0;
        public double small_container_parsed = 0;
        public double cargo_multiplier_set = 1;
        public double mass_summary_set = 0;
        public double planet_msv = 0.0;
        public string block_type = "";
        public double total_atmo_large_quantity = 0; // Atmospheric
        public double total_atmo_small_quantity = 0;
        public double total_atmo_large_mass = 0;
        public double total_atmo_large_newton = 0;
        public double total_atmo_small_mass = 0;
        public double total_atmo_small_newton = 0;
        public double total_hydro_large_quantity = 0; // Hydrogen
        public double total_hydro_small_quantity = 0;
        public double total_hydro_large_mass = 0;
        public double total_hydro_large_newton = 0;
        public double total_hydro_small_mass = 0;
        public double total_hydro_small_newton = 0;
        public double total_ion_large_quantity = 0; // Ion
        public double total_ion_small_quantity = 0;
        public double total_ion_large_mass = 0;
        public double total_ion_large_newton = 0;
        public double total_ion_small_mass = 0;
        public double total_ion_small_newton = 0;
        public double large_atmospheric_largegrid_quantity = 0;
        public double small_atmospheric_largegrid_quantity = 0;
        public double large_hydrogen_largegrid_quantity = 0;
        public double small_hydrogen_largegrid_quantity = 0;
        public double large_ion_largegrid_quantity = 0;
        public double small_ion_largegrid_quantity = 0;
        public double large_atmospheric_smallgrid_quantity = 0;
        public double small_atmospheric_smallgrid_quantity = 0;
        public double large_hydrogen_smallgrid_quantity = 0;
        public double small_hydrogen_smallgrid_quantity = 0;
        public double large_ion_smallgrid_quantity = 0;
        public double small_ion_smallgrid_quantity = 0;

        #endregion Dynamic Variables

        #region Thruster Specs

        public const double large_hydrogen_largegrid = 7200000; // Hydrogen thrusters
        public const double large_atmospheric_largegrid = 6480000; // Atmospheric thrusters
        public const double small_atmospheric_largegrid = 648000;
        public const double large_atmospheric_smallgrid = 576000;
        public const double small_atmospheric_smallgrid = 96000;
        public const double large_atmospheric_largegrid_fuel = 16800; // KW
        public const double small_atmospheric_largegrid_fuel = 2400;
        public const double large_atmospheric_smallgrid_fuel = 2400;
        public const double small_atmospheric_smallgrid_fuel = 600;
        public const double large_atmospheric_largeg_mass = 32970; // KG
        public const double small_atmospheric_largeg_mass = 4000;
        public const double large_atmospheric_smallg_mass = 2948;
        public const double small_atmospheric_smallg_mass = 699;
        public const double small_hydrogen_largegrid = 1080000;
        public const double large_hydrogen_smallgrid = 480000;
        public const double small_hydrogen_smallgrid = 98400;
        public const double large_hydrogen_largegrid_fuel = 4820; // L/S
        public const double small_hydrogen_largegrid_fuel = 803;
        public const double large_hydrogen_smallgrid_fuel = 386;
        public const double small_hydrogen_smallgrid_fuel = 80;
        public const double large_hydrogen_largeg_mass = 6940; // KG
        public const double small_hydrogen_largeg_mass = 1420;
        public const double large_hydrogen_smallg_mass = 1222;
        public const double small_hydrogen_smallg_mass = 334;
        public const double large_ion_largegrid = 4320000; // Ion thrusters
        public const double small_ion_largegrid = 345600;
        public const double large_ion_smallgrid = 172800;
        public const double small_ion_smallgrid = 14400;
        public const double large_ion_largegrid_fuel = 33600; // KW
        public const double small_ion_largegrid_fuel = 3360;
        public const double large_ion_smallgrid_fuel = 2400;
        public const double small_ion_smallgrid_fuel = 200;
        public const double large_ion_largeg_mass = 43200; // KG
        public const double small_ion_largeg_mass = 4380;
        public const double large_ion_smallg_mass = 721;
        public const double small_ion_smallg_mass = 121;

        #endregion Thruster Specs

        #region Containers

        // Large cargo Container
        public const double largecargocontainer_mass_largegrid = 2593; // KG

        public const double largecargocontainer_mass_smallgrid = 626;
        public const double largecargocontainer_with_uranium_largegrid = 1140203;
        public const double largecargocontainer_with_uranium_smallgrid = 42234;

        // Medium Cargo Container NOTE: Availiable only for small blocks.
        public const double mediumcargocontainer_mass_smallgrid = 275; // KG

        public const double mediumcontainer_with_uranium_smallgrid = 9123;

        // Small Cargo Container
        public const double smallcargocontainer_mass_largegrid = 649; // KG

        public const int smallcargocontainer_mass_smallgrid = 49;
        public const int smallcargocontainer_with_uranium_largegrid = 1751;
        public const int smallcargocontainer_with_uranium_smallgrid = 132;

        #endregion Containers

        public Form1()
        {
            InitializeComponent();
            return;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Setting text boxes on start up
            cargo_multiplier.SelectedIndex = 0;
            large_container_quantity.Text = "0";
            medium_container_quantity.Text = "0";
            small_container_quantity.Text = "0";
            tmass_large_atmo.Text = "...";
            tmass_large_hydro.Text = "...";
            tmass_large_ion.Text = "...";
            tmass_small_atmo.Text = "...";
            tmass_small_hydro.Text = "...";
            tmass_small_ion.Text = "...";
            tnewton_large_atmo.Text = "...";
            tnewton_large_hydro.Text = "...";
            tnewton_large_ion.Text = "...";
            tnewton_small_atmo.Text = "...";
            tnewton_small_hydro.Text = "...";
            tnewton_small_ion.Text = "...";
            large_atmospheric_thrusters_quantity.Text = "...";
            small_atmospheric_thrusters_quantity.Text = "...";
            large_hydrogen_thrusters_quantity.Text = "...";
            small_hydrogen_thrusters_quantity.Text = "...";
            large_ion_thrusters_quantity.Text = "...";
            small_ion_thrusters_quantity.Text = "...";
            energy_consumption_large.Text = "...";
            energy_consumption_small.Text = "...";
            fuel_consumption_large.Text = "...";
            fuel_consumption_small.Text = "...";
            ion_consumption_large.Text = "...";
            ion_consumption_small.Text = "...";
        }

        #region Main button

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

            button1.Enabled = true;
            button3.Enabled = true;
            tmass_large_atmo.Enabled = true;
            tmass_large_hydro.Enabled = true;
            tmass_large_ion.Enabled = true;
            tmass_small_atmo.Enabled = true;
            tmass_small_hydro.Enabled = true;
            tmass_small_ion.Enabled = true;
            tnewton_large_atmo.Enabled = true;
            tnewton_large_hydro.Enabled = true;
            tnewton_large_ion.Enabled = true;
            tnewton_small_atmo.Enabled = true;
            tnewton_small_hydro.Enabled = true;
            tnewton_small_ion.Enabled = true;
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

            if (type_of_blocks.SelectedIndex == 0)
            {
                this.mass_summary_set = user_value_kg;
                this.total_newton_value = g_amount * user_value_kg / 1000;
                calc_for_largegrid(total_newton_value);
            }
            if (type_of_blocks.SelectedIndex == 0 & activate_containers.Checked == true)
            {
                calc_largeg_thrusters();
            }
            if (type_of_blocks.SelectedIndex == 1)
            {
                this.mass_summary_set = user_value_kg;
                this.total_newton_value = g_amount * user_value_kg / 1000;
                calc_for_smallgrid(total_newton_value);
            }
            if (type_of_blocks.SelectedIndex == 1 & activate_containers.Checked == true)
            {
                calc_smallg_thrusters();
            }
            return;
        }

        #endregion Main button

        #region Methods of calculating thrusters quantity and consumption

        private void calc_largeg_thrusters()
        {
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
                this.mass_summary_set = (largecargocontainer_mass_largegrid * large_container_parsed) + user_value_kg;
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
                this.mass_summary_set = (smallcargocontainer_mass_largegrid * small_container_parsed) + user_value_kg;
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
                this.total_newton_value = ((largecargocontainer_mass_largegrid * large_container_parsed) + (largecargocontainer_with_uranium_largegrid * large_container_parsed) + (smallcargocontainer_mass_largegrid * small_container_parsed) + (smallcargocontainer_with_uranium_largegrid * small_container_parsed)) * cargo_multiplier_set + user_value_kg;
                this.total_newton_value = mass_summary_set * g_amount / 1000;
                calc_for_largegrid(total_newton_value);
            }
            return;
        }

        private void calc_smallg_thrusters()
        {
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
                this.mass_summary_set = (largecargocontainer_mass_smallgrid * large_container_parsed) + user_value_kg;
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
                this.mass_summary_set = (mediumcargocontainer_mass_smallgrid * medium_container_parsed) + user_value_kg;
                this.total_newton_value = mass_summary_set * g_amount / 1000;
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
                this.mass_summary_set = (smallcargocontainer_mass_smallgrid * small_container_parsed) + user_value_kg;
                this.total_newton_value = mass_summary_set * g_amount / 1000;
                calc_for_smallgrid(total_newton_value);
            }
            // SG + weight include + large and medium containers
            if (type_of_blocks.SelectedIndex == 1 & activate_containers.Checked == true & full_of_ore.Checked == true & activate_large_container.Checked == true & activate_medium_container.Checked == true)
            {
                this.mass_summary_set = ((largecargocontainer_mass_smallgrid * large_container_parsed) + (largecargocontainer_with_uranium_smallgrid * large_container_parsed) + (mediumcargocontainer_mass_smallgrid * medium_container_parsed) + (mediumcontainer_with_uranium_smallgrid * medium_container_parsed)) * cargo_multiplier_set + user_value_kg;
                this.total_newton_value = mass_summary_set * g_amount / 1000;
                calc_for_smallgrid(total_newton_value);
            }
            // SG + weight not included + large and medium containers
            if (type_of_blocks.SelectedIndex == 1 & activate_containers.Checked == true & without_ore.Checked == true & activate_large_container.Checked == true & activate_medium_container.Checked == true)
            {
                this.mass_summary_set = ((largecargocontainer_mass_smallgrid * large_container_parsed) + (mediumcargocontainer_mass_smallgrid * medium_container_parsed)) + user_value_kg;
                this.total_newton_value = mass_summary_set * g_amount / 1000;
                calc_for_smallgrid(total_newton_value);
            }
            //SG + weight included + large small containers
            if (type_of_blocks.SelectedIndex == 1 & activate_containers.Checked == true & full_of_ore.Checked == true & activate_large_container.Checked == true & activate_small_container.Checked == true)
            {
                this.mass_summary_set = ((largecargocontainer_mass_smallgrid * large_container_parsed) + (largecargocontainer_with_uranium_smallgrid * large_container_parsed) + (smallcargocontainer_mass_smallgrid * small_container_parsed) + (smallcargocontainer_with_uranium_smallgrid * small_container_parsed)) * cargo_multiplier_set + user_value_kg;
                this.total_newton_value = mass_summary_set * g_amount / 1000;
                calc_for_smallgrid(total_newton_value);
            }
            //SG + weight not included + large small containers
            if (type_of_blocks.SelectedIndex == 1 & activate_containers.Checked == true & without_ore.Checked == true & activate_large_container.Checked == true & activate_small_container.Checked == true)
            {
                this.mass_summary_set = ((largecargocontainer_mass_smallgrid * large_container_parsed) + (smallcargocontainer_mass_smallgrid * small_container_parsed)) + user_value_kg;
                this.total_newton_value = mass_summary_set * g_amount / 1000;
                calc_for_smallgrid(total_newton_value);
            }
            //SG + weight included + large medium small containers
            if (type_of_blocks.SelectedIndex == 1 & activate_containers.Checked == true & full_of_ore.Checked == true & without_ore.Checked != true & activate_large_container.Checked == true & activate_medium_container.Checked == true & activate_small_container.Checked == true)
            {
                this.mass_summary_set = ((largecargocontainer_mass_smallgrid * large_container_parsed + largecargocontainer_with_uranium_smallgrid * large_container_parsed) + (mediumcargocontainer_mass_smallgrid * medium_container_parsed + mediumcontainer_with_uranium_smallgrid * medium_container_parsed) + (smallcargocontainer_mass_smallgrid * small_container_parsed + smallcargocontainer_with_uranium_smallgrid * small_container_parsed)) * cargo_multiplier_set + user_value_kg;
                this.total_newton_value = mass_summary_set * g_amount / 1000;
                calc_for_smallgrid(total_newton_value);
            }
            //SG + weight not included + large medium small containers
            if (type_of_blocks.SelectedIndex == 1 & activate_containers.Checked == true & without_ore.Checked == true & full_of_ore.Checked != true & activate_large_container.Checked == true & activate_medium_container.Checked == true & activate_small_container.Checked == true)
            {
                this.mass_summary_set = ((largecargocontainer_mass_smallgrid * large_container_parsed) + (mediumcargocontainer_mass_smallgrid * medium_container_parsed) + (smallcargocontainer_mass_smallgrid * small_container_parsed)) + user_value_kg;
                this.total_newton_value = mass_summary_set * g_amount / 1000;
                calc_for_smallgrid(total_newton_value);
            }
            //SG + weight include + medium small containers
            if (type_of_blocks.SelectedIndex == 1 & activate_containers.Checked == true & full_of_ore.Checked == true & full_of_ore.Checked != true & activate_medium_container.Checked == true & activate_small_container.Checked == true)
            {
                this.mass_summary_set = ((mediumcargocontainer_mass_smallgrid * medium_container_parsed) + (mediumcontainer_with_uranium_smallgrid * medium_container_parsed) + (smallcargocontainer_mass_smallgrid * small_container_parsed) + (smallcargocontainer_with_uranium_smallgrid * small_container_parsed)) * cargo_multiplier_set + user_value_kg;
                this.total_newton_value = mass_summary_set * g_amount / 1000;
                calc_for_smallgrid(total_newton_value);
            }
            //SG + weight not include + medium small containers
            if (type_of_blocks.SelectedIndex == 1 & activate_containers.Checked == true & without_ore.Checked == true & activate_medium_container.Checked == true & activate_small_container.Checked == true)
            {
                this.mass_summary_set = ((mediumcargocontainer_mass_smallgrid * medium_container_parsed) + (smallcargocontainer_mass_smallgrid * small_container_parsed)) + user_value_kg;
                this.total_newton_value = mass_summary_set * g_amount / 1000;
                calc_for_smallgrid(total_newton_value);
            }
            return;
        }

        private void calc_for_largegrid(double newtons)
        {
            this.large_atmospheric_largegrid_quantity = newtons / large_atmospheric_largegrid; // Atmospheric thrusters
            this.total_atmo_large_mass = (large_atmospheric_largegrid_quantity * large_atmospheric_largeg_mass) + mass_summary_set;
            tmass_large_atmo.Text = Math.Ceiling(total_atmo_large_mass).ToString() + " Kg";
            this.total_atmo_large_newton = (total_atmo_large_mass * g_amount) / 1000;
            tnewton_large_atmo.Text = Math.Ceiling(total_atmo_large_newton).ToString() + " N";
            this.total_atmo_large_quantity = total_atmo_large_newton / large_atmospheric_largegrid;
            large_atmospheric_thrusters_quantity.Text = Math.Ceiling(total_atmo_large_quantity).ToString();

            this.small_atmospheric_largegrid_quantity = newtons / small_atmospheric_largegrid;
            this.total_atmo_small_mass = (small_atmospheric_largegrid_quantity * small_atmospheric_largeg_mass) + mass_summary_set;
            tmass_small_atmo.Text = Math.Ceiling(total_atmo_small_mass).ToString() + " Kg";
            this.total_atmo_small_newton = (total_atmo_small_mass * g_amount) / 1000;
            tnewton_small_atmo.Text = Math.Ceiling(total_atmo_small_newton).ToString() + " N";
            this.total_atmo_small_quantity = total_atmo_small_newton / small_atmospheric_largegrid;
            small_atmospheric_thrusters_quantity.Text = Math.Ceiling(small_atmospheric_largegrid_quantity).ToString();

            this.large_hydrogen_largegrid_quantity = newtons / large_hydrogen_largegrid; // Hydrogen thrusters
            this.total_hydro_large_mass = (large_hydrogen_largegrid_quantity * large_hydrogen_largeg_mass) + mass_summary_set;
            tmass_large_hydro.Text = Math.Ceiling(total_hydro_large_mass).ToString() + " Kg";
            this.total_hydro_large_newton = (total_hydro_large_mass * g_amount) / 1000;
            tnewton_large_hydro.Text = Math.Ceiling(total_hydro_large_newton).ToString() + " N";
            this.total_hydro_large_quantity = total_hydro_large_newton / large_hydrogen_largegrid;
            large_hydrogen_thrusters_quantity.Text = Math.Ceiling(total_hydro_large_quantity).ToString();

            this.small_hydrogen_largegrid_quantity = newtons / small_hydrogen_largegrid;
            this.total_hydro_small_mass = (small_hydrogen_largegrid_quantity * small_hydrogen_largeg_mass) + mass_summary_set;
            tmass_small_hydro.Text = Math.Ceiling(total_hydro_small_mass).ToString() + " Kg";
            this.total_hydro_small_newton = (total_hydro_small_mass * g_amount) / 1000;
            tnewton_small_hydro.Text = Math.Ceiling(total_hydro_small_newton).ToString() + " N";
            this.total_hydro_small_quantity = total_hydro_small_newton / small_hydrogen_largegrid;
            small_hydrogen_thrusters_quantity.Text = Math.Ceiling(total_hydro_small_quantity).ToString();

            this.large_ion_largegrid_quantity = newtons / large_ion_largegrid; // Ion thrusters
            this.total_ion_large_mass = (large_ion_largegrid_quantity * large_ion_largeg_mass) + mass_summary_set;
            tmass_large_ion.Text = Math.Ceiling(total_ion_large_mass).ToString() + " Kg";
            this.total_ion_large_newton = (total_ion_large_mass * g_amount) / 1000;
            tnewton_large_ion.Text = Math.Ceiling(total_ion_large_newton).ToString() + " N";
            this.total_ion_large_quantity = total_ion_large_newton / large_ion_largegrid;
            large_ion_thrusters_quantity.Text = Math.Ceiling(total_ion_large_quantity).ToString();

            this.small_ion_largegrid_quantity = newtons / small_ion_largegrid;
            this.total_ion_small_mass = (small_ion_largegrid_quantity * small_ion_largeg_mass) + mass_summary_set;
            tmass_small_ion.Text = Math.Ceiling(total_ion_small_mass).ToString() + " Kg";
            this.total_ion_small_newton = (total_ion_small_mass * g_amount) / 1000;
            tnewton_small_ion.Text = Math.Ceiling(total_ion_small_newton).ToString() + " N";
            this.total_ion_small_quantity = total_ion_small_newton / small_ion_largegrid;
            small_ion_thrusters_quantity.Text = Math.Ceiling(total_ion_small_quantity).ToString();

            atmospheric_consumption(total_atmo_large_quantity, total_atmo_small_quantity, large_atmospheric_largegrid_fuel, small_atmospheric_largegrid_fuel);
            hydrogen_consumption(total_hydro_large_quantity, total_hydro_small_quantity, large_hydrogen_largegrid_fuel, small_hydrogen_largegrid_fuel);
            ion_consumption(total_ion_large_quantity, total_ion_small_quantity, large_ion_largegrid_fuel, small_ion_largegrid_fuel);

            return;
        }

        private void calc_for_smallgrid(double newtons)
        {
            double large_atmospheric_smallgrid_quantity = newtons / large_atmospheric_smallgrid; // Atmospheric thrusters
            this.total_atmo_large_mass = (large_atmospheric_smallgrid_quantity * large_atmospheric_smallg_mass) + mass_summary_set;
            tmass_large_atmo.Text = Math.Ceiling(total_atmo_large_mass).ToString() + " Kg";
            this.total_atmo_large_newton = (total_atmo_large_mass * g_amount) / 1000;
            tnewton_large_atmo.Text = Math.Ceiling(total_atmo_large_newton).ToString() + " N";
            this.total_atmo_large_quantity = total_atmo_large_newton / large_atmospheric_smallgrid;
            large_atmospheric_thrusters_quantity.Text = Math.Ceiling(total_atmo_large_quantity).ToString();

            double small_atmospheric_smallgrid_quantity = newtons / small_atmospheric_smallgrid;
            this.total_atmo_small_mass = (small_atmospheric_smallgrid_quantity * small_atmospheric_smallg_mass) + mass_summary_set;
            tmass_small_atmo.Text = Math.Ceiling(total_atmo_small_mass).ToString() + " Kg";
            this.total_atmo_small_newton = (total_atmo_small_mass * g_amount) / 1000;
            tnewton_small_atmo.Text = Math.Ceiling(total_atmo_small_newton).ToString() + " N";
            this.total_atmo_small_quantity = total_atmo_small_newton / small_atmospheric_smallgrid;
            small_atmospheric_thrusters_quantity.Text = Math.Ceiling(total_atmo_small_quantity).ToString();

            double large_hydrogen_smallgrid_quantity = newtons / large_hydrogen_smallgrid; // Hydrogen thrusters
            this.total_hydro_large_mass = (large_hydrogen_smallgrid_quantity * large_hydrogen_smallg_mass) + mass_summary_set;
            tmass_large_hydro.Text = Math.Ceiling(total_hydro_large_mass).ToString() + " Kg";
            this.total_hydro_large_newton = (total_hydro_large_mass * g_amount) / 1000;
            tnewton_large_hydro.Text = Math.Ceiling(total_hydro_large_newton).ToString() + " N";
            this.total_hydro_large_quantity = total_hydro_large_newton / large_hydrogen_smallgrid;
            large_hydrogen_thrusters_quantity.Text = Math.Ceiling(total_hydro_large_quantity).ToString();

            double small_hydrogen_smallgrid_quantity = newtons / small_hydrogen_smallgrid;
            this.total_hydro_small_mass = (small_hydrogen_smallgrid_quantity * small_hydrogen_smallg_mass) + mass_summary_set;
            tmass_small_hydro.Text = Math.Ceiling(total_hydro_small_mass).ToString() + " Kg";
            this.total_hydro_small_newton = (total_hydro_small_mass * g_amount) / 1000;
            tnewton_small_hydro.Text = Math.Ceiling(total_hydro_small_newton).ToString() + " N";
            this.total_hydro_small_quantity = total_hydro_small_newton / small_hydrogen_smallgrid;
            small_hydrogen_thrusters_quantity.Text = Math.Ceiling(total_hydro_small_quantity).ToString();

            double large_ion_smallgrid_quantity = newtons / large_ion_smallgrid; // Ion thrusters
            this.total_ion_large_mass = (large_ion_smallgrid_quantity * large_ion_smallg_mass) + mass_summary_set;
            tmass_large_ion.Text = Math.Ceiling(total_ion_large_mass).ToString() + " Kg";
            this.total_ion_large_newton = (total_ion_large_mass * g_amount) / 1000;
            tnewton_large_ion.Text = Math.Ceiling(total_ion_large_newton).ToString() + " N";
            this.total_ion_large_quantity = total_ion_large_newton / large_ion_smallgrid;
            large_ion_thrusters_quantity.Text = Math.Ceiling(total_ion_large_quantity).ToString();

            double small_ion_smallgrid_quantity = newtons / small_ion_smallgrid;
            this.total_ion_small_mass = (small_ion_smallgrid_quantity * small_ion_smallg_mass) + mass_summary_set;
            tmass_small_ion.Text = Math.Ceiling(total_ion_small_mass).ToString() + " Kg";
            this.total_ion_small_newton = (total_ion_small_mass * g_amount) / 1000;
            tnewton_small_ion.Text = Math.Ceiling(total_ion_small_newton).ToString() + " N";
            this.total_ion_small_quantity = total_ion_small_newton / small_ion_smallgrid;
            small_ion_thrusters_quantity.Text = Math.Ceiling(total_ion_small_quantity).ToString();

            atmospheric_consumption(total_atmo_large_quantity, total_atmo_small_quantity, large_atmospheric_smallgrid_fuel, small_atmospheric_smallgrid_fuel);
            hydrogen_consumption(total_hydro_large_quantity, total_hydro_small_quantity, large_hydrogen_smallgrid_fuel, small_hydrogen_smallgrid_fuel);
            ion_consumption(total_ion_large_quantity, total_ion_small_quantity, large_ion_smallgrid_fuel, small_ion_smallgrid_fuel);

            return;
        }

        private void hydrogen_consumption(double largehydrogen, double smallhydrogen, double largefuel, double smallfuel)
        {
            double fuel_consume_large = Math.Ceiling(largehydrogen) * largefuel;
            fuel_consumption_large.Text = Math.Ceiling(fuel_consume_large).ToString() + " L/S";

            double fuel_consume_small = Math.Ceiling(smallhydrogen * smallfuel);
            fuel_consumption_small.Text = Math.Ceiling(fuel_consume_small).ToString() + " L/S";

            return;
        }

        private void atmospheric_consumption(double largeatm, double smallatm, double largeatmfuel, double smallatmfuel)
        {
            double atm_consume_large = Math.Ceiling(largeatm) * largeatmfuel;
            energy_consumption_large.Text = Math.Ceiling(atm_consume_large).ToString() + " KW";

            double atm_consume_small = Math.Ceiling(smallatm) * smallatmfuel;
            energy_consumption_small.Text = Math.Ceiling(atm_consume_small).ToString() + " KW";

            return;
        }

        private void ion_consumption(double largeion, double smallion, double largeionfuel, double smallionfuel)
        {
            double ion_consume_large = Math.Ceiling(largeion) * largeionfuel;
            ion_consumption_large.Text = Math.Ceiling(ion_consume_large).ToString() + " KW";

            double ion_consume_small = Math.Ceiling(smallion) * smallionfuel;
            ion_consumption_small.Text = Math.Ceiling(ion_consume_small).ToString() + " KW";

            return;
        }

        private void activate_containers_CheckedChanged(object sender, EventArgs e)
        {
            if (activate_containers.Checked != true)
            {
                large_container_quantity.BackColor = Color.White;
                medium_container_quantity.BackColor = Color.White;
                small_container_quantity.BackColor = Color.White;
                activate_large_container.Checked = false;
                activate_medium_container.Checked = false;
                activate_small_container.Checked = false;
            }
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
            return;
        }

        #endregion Methods of calculating thrusters quantity and consumption

        #region Text fields and comboboxes

        private void location_selector_SelectedIndexChanged(object sender, EventArgs e)
        {
            button_calculation.Enabled = true;
            activate_containers.Enabled = true;

            if (user_location_choice.SelectedIndex == 0) // Earthlike
            {
                this.g_amount = 9807; // 1g
                this.planet_msv = 9.8;
                label_gs.Text = "1g";
                pictureBox1.Image = Image.FromFile("C:\\Users\\Greg\\Desktop\\img\\earthlike_planet.png");
            }
            if (user_location_choice.SelectedIndex == 1) // Moon
            {
                this.g_amount = 2451; // 0.25g in Newtons
                this.planet_msv = 2.45;
                label_gs.Text = "0.25g";
                pictureBox1.Image = Image.FromFile("C:\\Users\\Greg\\Desktop\\img\\moon_planet.png");
            }
            if (user_location_choice.SelectedIndex == 2) // Mars
            {
                this.g_amount = 8826; // 0.90g in Newtons
                this.planet_msv = 8.82;
                label_gs.Text = "0.90g";
                pictureBox1.Image = Image.FromFile("C:\\Users\\Greg\\Desktop\\img\\mars_planet.png");
            }
            if (user_location_choice.SelectedIndex == 3) // Europa
            {
                this.g_amount = 2451; // 0.25g in Newtons
                this.planet_msv = 2.45; // 2.452ms
                label_gs.Text = "0.25g";
                pictureBox1.Image = Image.FromFile("C:\\Users\\Greg\\Desktop\\img\\europa_planet.png");
            }
            if (user_location_choice.SelectedIndex == 4) // Triton
            {
                this.g_amount = 9807; // 1g
                this.planet_msv = 9.8;
                label_gs.Text = "1g";
                pictureBox1.Image = Image.FromFile("C:\\Users\\Greg\\Desktop\\img\\triton_planet.png");
            }
            if (user_location_choice.SelectedIndex == 5) // Pertam
            {
                this.g_amount = 11768; // 1.20g in Newtons
                this.planet_msv = 11.77;
                label_gs.Text = "1.20g";
                pictureBox1.Image = Image.FromFile("C:\\Users\\Greg\\Desktop\\img\\pertam_planet.png");
            }
            if (user_location_choice.SelectedIndex == 6) // Alien planet
            {
                this.g_amount = 10787; // 1.10g in Newtons
                this.planet_msv = 10.78;
                label_gs.Text = "1.10g";
                pictureBox1.Image = Image.FromFile("C:\\Users\\Greg\\Desktop\\img\\alien_planet.png");
            }
            if (user_location_choice.SelectedIndex == 7) // Titan
            {
                this.g_amount = 2451; // 0.25g in Newtons
                this.planet_msv = 2.45;
                label_gs.Text = "0.25g";
                pictureBox1.Image = Image.FromFile("C:\\Users\\Greg\\Desktop\\img\\titan_planet.png");
            }
            return;
        }

        private void cargo_no_weight_CheckedChanged(object sender, EventArgs e)
        {
            if (without_ore.Checked == true)
            {
                full_of_ore.Checked = false;
            }
            return;
        }

        private void cargo_weight_CheckedChanged(object sender, EventArgs e)
        {
            if (full_of_ore.Checked == true)
            {
                without_ore.Checked = false;
            }
            return;
        }

        private void large_container_quantity_TextChanged(object sender, EventArgs e)
        {
            bool check_large_cargo = double.TryParse(large_container_quantity.Text, out double value);
            if (check_large_cargo != true)
            {
                label_warning.ForeColor = Color.Red;
                label_warning.Visible = true;
                label_warning.Text = "Enter only digits!";
            }
            else
            {
                label_warning.Visible = false;
                this.large_container_parsed = Convert.ToDouble(large_container_quantity.Text);
            }
            return;
        }

        private void medium_container_quantity_TextChanged(object sender, EventArgs e)
        {
            bool check_medium_cargo = double.TryParse(medium_container_quantity.Text, out double value);
            if (check_medium_cargo != true)
            {
                label_warning.ForeColor = Color.Red;
                label_warning.Visible = true;
                label_warning.Text = "Enter only digits!";
            }
            else
            {
                label_warning.Visible = false;
                this.medium_container_parsed = Convert.ToDouble(medium_container_quantity.Text);
            }
            return;
        }

        private void small_container_quantity_TextChanged(object sender, EventArgs e)
        {
            bool check_small_cargo = double.TryParse(small_container_quantity.Text, out double value);
            if (check_small_cargo != true)
            {
                label_warning.ForeColor = Color.Red;
                label_warning.Visible = true;
                label_warning.Text = "Enter only digits!";
            }
            else
            {
                label_warning.Visible = false;
                this.small_container_parsed = Convert.ToDouble(small_container_quantity.Text);
            }
            return;
        }

        private void activate_large_container_CheckedChanged(object sender, EventArgs e)
        {
            if (activate_large_container.Checked == true)
            {
                large_container_quantity.BackColor = Color.Bisque;
            }
            if (activate_large_container.Checked == false)
            {
                large_container_quantity.BackColor = Color.White;
                large_container_quantity.Text = "0";
            }
            return;
        }

        private void activate_medium_container_CheckedChanged(object sender, EventArgs e)
        {
            if (activate_medium_container.Checked == true)
            {
                medium_container_quantity.BackColor = Color.Bisque;
            }
            if (activate_medium_container.Checked == false)
            {
                medium_container_quantity.BackColor = Color.White;
                medium_container_quantity.Text = "0";
            }
            return;
        }

        private void activate_small_container_CheckedChanged(object sender, EventArgs e)
        {
            if (activate_small_container.Checked == true)
            {
                small_container_quantity.BackColor = Color.Bisque;
            }
            if (activate_small_container.Checked == false)
            {
                small_container_quantity.BackColor = Color.White;
                small_container_quantity.Text = "0";
            }
            return;
        }

        private void type_of_blocks_SelectedIndexChanged(object sender, EventArgs e)
        {
            user_entered_value.Enabled = true;
            user_entered_value.BackColor = Color.Bisque;

            return;
        }

        private void user_entered_value_TextChanged(object sender, EventArgs e)
        {
            user_location_choice.BackColor = Color.Bisque;

            bool check_user_value = double.TryParse(user_entered_value.Text, out double value);
            if (check_user_value != true)
            {
                label_warning.ForeColor = Color.Red;
                label_warning.Visible = true;
                label_warning.Text = "Enter only digits!";
            }
            else
            {
                user_location_choice.Enabled = true;
                label_warning.Visible = false;
                this.user_value_kg = Convert.ToDouble(user_entered_value.Text);
            }
            return;
        }

        #endregion Text fields and comboboxes

        #region Additional buttons

        private void button1_Click(object sender, EventArgs e)
        {
            label_warning.Visible = true;
            label_warning.ForeColor = Color.Green;
            label_warning.Text = "File saved in program directory";

            string applicationPath = Path.GetFullPath(AppDomain.CurrentDomain.BaseDirectory);
            string saveFilePath = Path.Combine(applicationPath, "Saved_specs.txt");
            using var writer = new StreamWriter(saveFilePath, append: false);
            if (activate_containers.Checked == false)
            {
                writer.WriteLine("Location: " + user_location_choice.Text.ToString());
                writer.WriteLine("Type of blocks: " + type_of_blocks.Text.ToString());
                writer.WriteLine("Cargo containers: No");
                writer.WriteLine("");
                writer.WriteLine("/////////////////////");
                writer.WriteLine("ATMOSPHERIC THRUSTERS");
                writer.WriteLine("/////////////////////");
                writer.WriteLine("");
                writer.WriteLine("Total large thrusters mass: " + tmass_large_atmo.Text.ToString());
                writer.WriteLine("Required power: " + tnewton_large_atmo.Text.ToString());
                writer.WriteLine("Large thrusters quantity: " + large_atmospheric_thrusters_quantity.Text.ToString());
                writer.WriteLine("Energy consumption: " + energy_consumption_large.Text.ToString());
                writer.WriteLine("");
                writer.WriteLine("Total small thrusters mass: " + tmass_small_atmo.Text.ToString());
                writer.WriteLine("Required power: " + tnewton_small_atmo.Text.ToString() + " N");
                writer.WriteLine("Small thrusters quantity: " + small_atmospheric_thrusters_quantity.Text.ToString());
                writer.WriteLine("Energy consumption: " + energy_consumption_small.Text.ToString());
                writer.WriteLine("");
                writer.WriteLine("//////////////////");
                writer.WriteLine("HYDROGEN THRUSTERS");
                writer.WriteLine("//////////////////");
                writer.WriteLine("");
                writer.WriteLine("Total large thrusters mass: " + tmass_large_hydro.Text.ToString());
                writer.WriteLine("Required power: " + tnewton_large_hydro.Text.ToString());
                writer.WriteLine("Large thrusters quantity: " + large_hydrogen_thrusters_quantity.Text.ToString());
                writer.WriteLine("Energy consumption: " + fuel_consumption_large.Text.ToString());
                writer.WriteLine("");
                writer.WriteLine("Total small thrusters mass: " + tmass_small_hydro.Text.ToString());
                writer.WriteLine("Required power: " + tnewton_small_hydro.Text.ToString());
                writer.WriteLine("Small thrusters quantity: " + small_hydrogen_thrusters_quantity.Text.ToString());
                writer.WriteLine("Energy consumption: " + fuel_consumption_small.Text.ToString());
                writer.WriteLine("");
                writer.WriteLine("/////////////");
                writer.WriteLine("ION THRUSTERS");
                writer.WriteLine("/////////////");
                writer.WriteLine("");
                writer.WriteLine("Total large thrusters mass: " + tmass_large_ion.Text.ToString());
                writer.WriteLine("Required power: " + tnewton_large_ion.Text.ToString());
                writer.WriteLine("Large thrusters quantity: " + large_ion_thrusters_quantity.Text.ToString());
                writer.WriteLine("Energy consumption: " + ion_consumption_large.Text.ToString());
                writer.WriteLine("");
                writer.WriteLine("Total small thrusters mass: " + tmass_small_ion.Text.ToString());
                writer.WriteLine("Required power: " + tnewton_small_ion.Text.ToString());
                writer.WriteLine("Small thrusters quantity: " + small_ion_thrusters_quantity.Text.ToString());
                writer.WriteLine("Energy consumption: " + ion_consumption_small.Text.ToString());
                writer.WriteLine("");
                writer.WriteLine("///////////////////////////////");
                writer.WriteLine("File created: " + DateTime.Now);
                writer.WriteLine("'SE Fight Gravity' by Belltower");
                writer.WriteLine("///////////////////////////////");
                writer.Close();
            }
            if (activate_containers.Checked == true)
            {
                writer.WriteLine("Location: " + user_location_choice.Text.ToString());
                writer.WriteLine("Type of blocks: " + type_of_blocks.Text.ToString());
                writer.WriteLine("Cargo containers: Yes");
                if (full_of_ore.Checked == true)
                {
                    writer.WriteLine("Cargo filled with ore: Yes");
                }
                else
                {
                    writer.WriteLine("Cargo filled with ore: No");
                }
                writer.WriteLine("Cargo multiplier: " + cargo_multiplier.Text.ToString());
                writer.WriteLine("Large container quantity: " + large_container_quantity.Text.ToString());
                writer.WriteLine("Medium container quantity: " + medium_container_quantity.Text.ToString());
                writer.WriteLine("Small container quantity: " + small_container_quantity.Text.ToString());
                writer.WriteLine("Required thrusters power: " + Math.Ceiling(total_newton_value).ToString() + " N");
                writer.WriteLine("");
                writer.WriteLine("/////////////////////");
                writer.WriteLine("ATMOSPHERIC THRUSTERS");
                writer.WriteLine("/////////////////////");
                writer.WriteLine("");
                writer.WriteLine("Total large thrusters mass: " + tmass_large_atmo.Text.ToString());
                writer.WriteLine("Required power: " + tnewton_large_atmo.Text.ToString());
                writer.WriteLine("Large thrusters quantity: " + large_atmospheric_thrusters_quantity.Text.ToString());
                writer.WriteLine("Energy consumption: " + energy_consumption_large.Text.ToString());
                writer.WriteLine("");
                writer.WriteLine("Total small thrusters mass: " + tmass_small_atmo.Text.ToString());
                writer.WriteLine("Required power: " + tnewton_small_atmo.Text.ToString() + " N");
                writer.WriteLine("Small thrusters quantity: " + small_atmospheric_thrusters_quantity.Text.ToString());
                writer.WriteLine("Energy consumption: " + energy_consumption_small.Text.ToString());
                writer.WriteLine("");
                writer.WriteLine("//////////////////");
                writer.WriteLine("HYDROGEN THRUSTERS");
                writer.WriteLine("//////////////////");
                writer.WriteLine("");
                writer.WriteLine("Total large thrusters mass: " + tmass_large_hydro.Text.ToString());
                writer.WriteLine("Required power: " + tnewton_large_hydro.Text.ToString());
                writer.WriteLine("Large thrusters quantity: " + large_hydrogen_thrusters_quantity.Text.ToString());
                writer.WriteLine("Energy consumption: " + fuel_consumption_large.Text.ToString());
                writer.WriteLine("");
                writer.WriteLine("Total small thrusters mass: " + tmass_small_hydro.Text.ToString());
                writer.WriteLine("Required power: " + tnewton_small_hydro.Text.ToString());
                writer.WriteLine("Small thrusters quantity: " + small_hydrogen_thrusters_quantity.Text.ToString());
                writer.WriteLine("Energy consumption: " + fuel_consumption_small.Text.ToString());
                writer.WriteLine("");
                writer.WriteLine("/////////////");
                writer.WriteLine("ION THRUSTERS");
                writer.WriteLine("/////////////");
                writer.WriteLine("");
                writer.WriteLine("Total large thrusters mass: " + tmass_large_ion.Text.ToString());
                writer.WriteLine("Required power: " + tnewton_large_ion.Text.ToString());
                writer.WriteLine("Large thrusters quantity: " + large_ion_thrusters_quantity.Text.ToString());
                writer.WriteLine("Energy consumption: " + ion_consumption_large.Text.ToString());
                writer.WriteLine("");
                writer.WriteLine("Total small thrusters mass: " + tmass_small_ion.Text.ToString());
                writer.WriteLine("Required power: " + tnewton_small_ion.Text.ToString());
                writer.WriteLine("Small thrusters quantity: " + small_ion_thrusters_quantity.Text.ToString());
                writer.WriteLine("Energy consumption: " + ion_consumption_small.Text.ToString());
                writer.WriteLine("");
                writer.WriteLine("///////////////////////////////");
                writer.WriteLine("File created: " + DateTime.Now);
                writer.WriteLine("'SE Fight Gravity' by Belltower");
                writer.WriteLine("///////////////////////////////");
                writer.Close();
            }
            return;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            return;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.planet_ms = planet_msv;
            form3.totall_mass = mass_summary_set;
            if (type_of_blocks.SelectedIndex == 0)
            {
                form3.block_type_f3 = "large";
            }
            if (type_of_blocks.SelectedIndex == 1)
            {
                form3.block_type_f3 = "small";
            }
            form3.Show();
            return;
        }
    }

    #endregion Additional buttons
}