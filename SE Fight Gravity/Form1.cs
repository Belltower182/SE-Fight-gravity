namespace SE_Fight_Gravity
{
    public partial class Form1 : Form
    {
        #region Dynamic Variables

        private double g_amount;
        private double total_newton_value;
        private double user_value_kg;
        private double large_container_parsed;
        private double medium_container_parsed;
        private double small_container_parsed;
        private double cargo_multiplier_set = 1;
        private double mass_summary_set;
        private double planet_msv;
        private double total_atmo_large_quantity; // Atmospheric
        private double total_atmo_small_quantity;
        private double total_atmo_large_mass;
        private double total_atmo_large_newton;
        private double total_atmo_small_mass;
        private double total_atmo_small_newton;
        private double total_hydro_large_quantity; // Hydrogen
        private double total_hydro_small_quantity;
        private double total_hydro_large_mass;
        private double total_hydro_large_newton;
        private double total_hydro_small_mass;
        private double total_hydro_small_newton;
        private double total_ion_large_quantity; // Ion
        private double total_ion_small_quantity;
        private double total_ion_large_mass;
        private double total_ion_large_newton;
        private double total_ion_small_mass;
        private double total_ion_small_newton;
        private double large_atmospheric_largegrid_quantity;
        private double small_atmospheric_largegrid_quantity;
        private double large_hydrogen_largegrid_quantity;
        private double small_hydrogen_largegrid_quantity;
        private double large_ion_largegrid_quantity;
        private double small_ion_largegrid_quantity;
        private double large_atmospheric_smallgrid_quantity;
        private double small_atmospheric_smallgrid_quantity;
        private double large_hydrogen_smallgrid_quantity;
        private double small_hydrogen_smallgrid_quantity;
        private double large_ion_smallgrid_quantity;
        private double small_ion_smallgrid_quantity;

        #endregion Dynamic Variables


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Set text boxes values on start up
            SetFieldsToBasicValues();
        }

        #region Main button

        private void ButtonCalculationClick(object sender, EventArgs e)
        {
            //Set cargo multipliers in variable
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

            //Activate text fields and buttons
            button_save.Enabled = true;
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

            //Calculate mass and give calculated newtons to the methods
            if (type_of_blocks.SelectedIndex == 0)
            {
                this.mass_summary_set = user_value_kg;
                this.total_newton_value = g_amount * user_value_kg / 1000;
                CalculationsForLargegrid(total_newton_value);
            }
            if (type_of_blocks.SelectedIndex == 0 && activate_containers.Checked)
            {
                CalcLargeGridThrusters();
            }
            if (type_of_blocks.SelectedIndex == 1)
            {
                this.mass_summary_set = user_value_kg;
                this.total_newton_value = g_amount * user_value_kg / 1000;
                CalculationsForSmallgrid(total_newton_value);
            }
            if (type_of_blocks.SelectedIndex == 1 && activate_containers.Checked)
            {
                CalcSmallGridThrusters();
            }
        }

        #endregion Main button

        #region Methods of calculating thrusters quantity and consumption

        private void CalcLargeGridThrusters()
        {
            // LG + weight included + large container
            if (type_of_blocks.SelectedIndex == 0 && activate_containers.Checked && full_of_ore.Checked && activate_large_container.Checked)
            {
                this.mass_summary_set = ((Containers.LargeContainers.largecargocontainer_mass_largegrid * large_container_parsed) + (Containers.LargeContainers.largecargocontainer_with_uranium_largegrid * large_container_parsed)) * cargo_multiplier_set + user_value_kg;
                this.total_newton_value = mass_summary_set * g_amount / 1000;
                CalculationsForLargegrid(total_newton_value);
            }
            // LG + weight not included + large container
            if (type_of_blocks.SelectedIndex == 0 && activate_containers.Checked && without_ore.Checked && activate_large_container.Checked)
            {
                this.mass_summary_set = (Containers.LargeContainers.largecargocontainer_mass_largegrid * large_container_parsed) + user_value_kg;
                this.total_newton_value = mass_summary_set * g_amount / 1000;
                CalculationsForLargegrid(total_newton_value);
            }
            // LG + weight included + small container
            if (type_of_blocks.SelectedIndex == 0 && activate_containers.Checked && full_of_ore.Checked && activate_small_container.Checked)
            {
                this.mass_summary_set = ((Containers.SmallContainers.smallcargocontainer_mass_largegrid * small_container_parsed) + (Containers.SmallContainers.smallcargocontainer_with_uranium_largegrid * small_container_parsed)) * cargo_multiplier_set + user_value_kg;
                this.total_newton_value = mass_summary_set * g_amount / 1000;
                CalculationsForLargegrid(total_newton_value);
            }
            // LG + weight not included + small conteiner
            if (type_of_blocks.SelectedIndex == 0 && activate_containers.Checked && without_ore.Checked && activate_small_container.Checked)
            {
                this.mass_summary_set = (Containers.SmallContainers.smallcargocontainer_mass_largegrid * small_container_parsed) + user_value_kg;
                this.total_newton_value = mass_summary_set * g_amount / 1000;
                CalculationsForLargegrid(total_newton_value);
            }
            // LG + weight included + large and small conteiners
            if (type_of_blocks.SelectedIndex == 0 && activate_containers.Checked && full_of_ore.Checked && activate_large_container.Checked && activate_small_container.Checked)
            {
                this.mass_summary_set = ((Containers.LargeContainers.largecargocontainer_mass_largegrid * large_container_parsed) + (Containers.LargeContainers.largecargocontainer_with_uranium_largegrid * large_container_parsed) + (Containers.SmallContainers.smallcargocontainer_mass_largegrid * small_container_parsed) + (Containers.SmallContainers.smallcargocontainer_with_uranium_largegrid * small_container_parsed)) * cargo_multiplier_set + user_value_kg;
                this.total_newton_value = mass_summary_set * g_amount / 1000;
                CalculationsForLargegrid(total_newton_value);
            }
            // LG + weight not included + large and small conteiners
            if (type_of_blocks.SelectedIndex == 0 && activate_containers.Checked && without_ore.Checked && activate_large_container.Checked && activate_small_container.Checked)
            {
                this.total_newton_value = ((Containers.LargeContainers.largecargocontainer_mass_largegrid * large_container_parsed) + (Containers.LargeContainers.largecargocontainer_with_uranium_largegrid * large_container_parsed) + (Containers.SmallContainers.smallcargocontainer_mass_largegrid * small_container_parsed) + (Containers.SmallContainers.smallcargocontainer_with_uranium_largegrid * small_container_parsed)) * cargo_multiplier_set + user_value_kg;
                this.total_newton_value = mass_summary_set * g_amount / 1000;
                CalculationsForLargegrid(total_newton_value);
            }
        }

        private void CalcSmallGridThrusters()
        {
            // SG + weight include + large container
            if (type_of_blocks.SelectedIndex == 1 && activate_containers.Checked && full_of_ore.Checked && activate_large_container.Checked)
            {
                this.mass_summary_set = ((Containers.LargeContainers.largecargocontainer_mass_smallgrid * large_container_parsed) + (Containers.LargeContainers.largecargocontainer_with_uranium_smallgrid * large_container_parsed)) * cargo_multiplier_set + user_value_kg;
                this.total_newton_value = mass_summary_set * g_amount / 1000;
                CalculationsForSmallgrid(total_newton_value);
            }
            // SG + weight not include + large container
            if (type_of_blocks.SelectedIndex == 1 && activate_containers.Checked && without_ore.Checked && activate_large_container.Checked)
            {
                this.mass_summary_set = (Containers.LargeContainers.largecargocontainer_mass_smallgrid * large_container_parsed) + user_value_kg;
                this.total_newton_value = mass_summary_set * g_amount / 1000;
                CalculationsForSmallgrid(total_newton_value);
            }
            // SG + weight include + medium container
            if (type_of_blocks.SelectedIndex == 1 && activate_containers.Checked && full_of_ore.Checked && activate_medium_container.Checked)
            {
                this.mass_summary_set = ((Containers.MediumContainers.mediumcargocontainer_mass_smallgrid * medium_container_parsed) + (Containers.MediumContainers.mediumcontainer_with_uranium_smallgrid * medium_container_parsed)) * cargo_multiplier_set + user_value_kg;
                this.total_newton_value = mass_summary_set * g_amount / 1000;
                CalculationsForSmallgrid(total_newton_value);
            }
            // SG + weight not included + medium container
            if (type_of_blocks.SelectedIndex == 1 && activate_containers.Checked && without_ore.Checked && activate_medium_container.Checked)
            {
                this.mass_summary_set = (Containers.MediumContainers.mediumcargocontainer_mass_smallgrid * medium_container_parsed) + user_value_kg;
                this.total_newton_value = mass_summary_set * g_amount / 1000;
                CalculationsForSmallgrid(total_newton_value);
            }
            // SG + weight included + small container
            if (type_of_blocks.SelectedIndex == 1 && activate_containers.Checked && full_of_ore.Checked && activate_small_container.Checked)
            {
                this.mass_summary_set = ((Containers.SmallContainers.smallcargocontainer_mass_smallgrid * small_container_parsed) + (Containers.SmallContainers.smallcargocontainer_with_uranium_smallgrid * small_container_parsed)) * cargo_multiplier_set + user_value_kg;
                this.total_newton_value = mass_summary_set * g_amount / 1000;
                CalculationsForSmallgrid(total_newton_value);
            }
            // SG + weight not included + small container
            if (type_of_blocks.SelectedIndex == 1 && activate_containers.Checked && without_ore.Checked && activate_small_container.Checked)
            {
                this.mass_summary_set = (Containers.SmallContainers.smallcargocontainer_mass_smallgrid * small_container_parsed) + user_value_kg;
                this.total_newton_value = mass_summary_set * g_amount / 1000;
                CalculationsForSmallgrid(total_newton_value);
            }
            // SG + weight include + large and medium containers
            if (type_of_blocks.SelectedIndex == 1 && activate_containers.Checked && full_of_ore.Checked && activate_large_container.Checked)
            {
                this.mass_summary_set = ((Containers.LargeContainers.largecargocontainer_mass_smallgrid * large_container_parsed) + (Containers.LargeContainers.largecargocontainer_with_uranium_smallgrid * large_container_parsed) + (Containers.MediumContainers.mediumcargocontainer_mass_smallgrid * medium_container_parsed) + (Containers.MediumContainers.mediumcontainer_with_uranium_smallgrid * medium_container_parsed)) * cargo_multiplier_set + user_value_kg;
                this.total_newton_value = mass_summary_set * g_amount / 1000;
                CalculationsForSmallgrid(total_newton_value);
            }
            // SG + weight not included + large and medium containers
            if (type_of_blocks.SelectedIndex == 1 && activate_containers.Checked && without_ore.Checked && activate_large_container.Checked && activate_medium_container.Checked)
            {
                this.mass_summary_set = ((Containers.LargeContainers.largecargocontainer_mass_smallgrid * large_container_parsed) + (Containers.MediumContainers.mediumcargocontainer_mass_smallgrid * medium_container_parsed)) + user_value_kg;
                this.total_newton_value = mass_summary_set * g_amount / 1000;
                CalculationsForSmallgrid(total_newton_value);
            }
            //SG + weight included + large small containers
            if (type_of_blocks.SelectedIndex == 1 && activate_containers.Checked && full_of_ore.Checked && activate_large_container.Checked && activate_small_container.Checked)
            {
                this.mass_summary_set = ((Containers.LargeContainers.largecargocontainer_mass_smallgrid * large_container_parsed) + (Containers.LargeContainers.largecargocontainer_with_uranium_smallgrid * large_container_parsed) + (Containers.SmallContainers.smallcargocontainer_mass_smallgrid * small_container_parsed) + (Containers.SmallContainers.smallcargocontainer_with_uranium_smallgrid * small_container_parsed)) * cargo_multiplier_set + user_value_kg;
                this.total_newton_value = mass_summary_set * g_amount / 1000;
                CalculationsForSmallgrid(total_newton_value);
            }
            //SG + weight not included + large small containers
            if (type_of_blocks.SelectedIndex == 1 && activate_containers.Checked && without_ore.Checked && activate_large_container.Checked && activate_small_container.Checked)
            {
                this.mass_summary_set = ((Containers.LargeContainers.largecargocontainer_mass_smallgrid * large_container_parsed) + (Containers.SmallContainers.smallcargocontainer_mass_smallgrid * small_container_parsed)) + user_value_kg;
                this.total_newton_value = mass_summary_set * g_amount / 1000;
                CalculationsForSmallgrid(total_newton_value);
            }
            //SG + weight included + large medium small containers
            if (type_of_blocks.SelectedIndex == 1 && activate_containers.Checked && full_of_ore.Checked && !without_ore.Checked && activate_large_container.Checked && activate_medium_container.Checked && activate_small_container.Checked)
            {
                this.mass_summary_set = ((Containers.LargeContainers.largecargocontainer_mass_smallgrid * large_container_parsed + Containers.LargeContainers.largecargocontainer_with_uranium_smallgrid * large_container_parsed) + (Containers.MediumContainers.mediumcargocontainer_mass_smallgrid * medium_container_parsed + Containers.MediumContainers.mediumcontainer_with_uranium_smallgrid * medium_container_parsed) + (Containers.SmallContainers.smallcargocontainer_mass_smallgrid * small_container_parsed + Containers.SmallContainers.smallcargocontainer_with_uranium_smallgrid * small_container_parsed)) * cargo_multiplier_set + user_value_kg;
                this.total_newton_value = mass_summary_set * g_amount / 1000;
                CalculationsForSmallgrid(total_newton_value);
            }
            //SG + weight not included + large medium small containers
            if (type_of_blocks.SelectedIndex == 1 && activate_containers.Checked && without_ore.Checked && !full_of_ore.Checked && activate_large_container.Checked && activate_medium_container.Checked && activate_small_container.Checked)
            {
                this.mass_summary_set = ((Containers.LargeContainers.largecargocontainer_mass_smallgrid * large_container_parsed) + (Containers.MediumContainers.mediumcargocontainer_mass_smallgrid * medium_container_parsed) + (Containers.SmallContainers.smallcargocontainer_mass_smallgrid * small_container_parsed)) + user_value_kg;
                this.total_newton_value = mass_summary_set * g_amount / 1000;
                CalculationsForSmallgrid(total_newton_value);
            }
            //SG + weight include + medium small containers
            if (type_of_blocks.SelectedIndex == 1 && activate_containers.Checked && full_of_ore.Checked && !full_of_ore.Checked && activate_medium_container.Checked && activate_small_container.Checked)
            {
                this.mass_summary_set = ((Containers.MediumContainers.mediumcargocontainer_mass_smallgrid * medium_container_parsed) + (Containers.MediumContainers.mediumcontainer_with_uranium_smallgrid * medium_container_parsed) + (Containers.SmallContainers.smallcargocontainer_mass_smallgrid * small_container_parsed) + (Containers.SmallContainers.smallcargocontainer_with_uranium_smallgrid * small_container_parsed)) * cargo_multiplier_set + user_value_kg;
                this.total_newton_value = mass_summary_set * g_amount / 1000;
                CalculationsForSmallgrid(total_newton_value);
            }
            //SG + weight not include + medium small containers
            if (type_of_blocks.SelectedIndex == 1 && activate_containers.Checked && without_ore.Checked && activate_medium_container.Checked && activate_small_container.Checked)
            {
                this.mass_summary_set = ((Containers.MediumContainers.mediumcargocontainer_mass_smallgrid * medium_container_parsed) + (Containers.SmallContainers.smallcargocontainer_mass_smallgrid * small_container_parsed)) + user_value_kg;
                this.total_newton_value = mass_summary_set * g_amount / 1000;
                CalculationsForSmallgrid(total_newton_value);
            }
        }

        private void CalculationsForLargegrid(double newtons)
        {
            this.large_atmospheric_largegrid_quantity = newtons / AtmosphericThrusters.AtmosphericPower.large_atmospheric_largegrid; // Atmospheric thrusters
            this.total_atmo_large_mass = (large_atmospheric_largegrid_quantity * AtmosphericThrusters.AtmosphericMass.large_atmospheric_largeg_mass) + mass_summary_set;
            tmass_large_atmo.Text = Math.Ceiling(total_atmo_large_mass).ToString() + " Kg";
            this.total_atmo_large_newton = (total_atmo_large_mass * g_amount) / 1000;
            tnewton_large_atmo.Text = Math.Ceiling(total_atmo_large_newton).ToString() + " N";
            this.total_atmo_large_quantity = total_atmo_large_newton / AtmosphericThrusters.AtmosphericPower.large_atmospheric_largegrid;
            large_atmospheric_thrusters_quantity.Text = Math.Ceiling(total_atmo_large_quantity).ToString();

            this.small_atmospheric_largegrid_quantity = newtons / AtmosphericThrusters.AtmosphericPower.small_atmospheric_largegrid;
            this.total_atmo_small_mass = (small_atmospheric_largegrid_quantity * AtmosphericThrusters.AtmosphericMass.small_atmospheric_largeg_mass) + mass_summary_set;
            tmass_small_atmo.Text = Math.Ceiling(total_atmo_small_mass).ToString() + " Kg";
            this.total_atmo_small_newton = (total_atmo_small_mass * g_amount) / 1000;
            tnewton_small_atmo.Text = Math.Ceiling(total_atmo_small_newton).ToString() + " N";
            this.total_atmo_small_quantity = total_atmo_small_newton / AtmosphericThrusters.AtmosphericPower.small_atmospheric_largegrid;
            small_atmospheric_thrusters_quantity.Text = Math.Ceiling(small_atmospheric_largegrid_quantity).ToString();

            this.large_hydrogen_largegrid_quantity = newtons / HydrogenThrusters.HydrogenPower.large_hydrogen_largegrid; // Hydrogen thrusters
            this.total_hydro_large_mass = (large_hydrogen_largegrid_quantity * HydrogenThrusters.HydrogenMass.large_hydrogen_largeg_mass) + mass_summary_set;
            tmass_large_hydro.Text = Math.Ceiling(total_hydro_large_mass).ToString() + " Kg";
            this.total_hydro_large_newton = (total_hydro_large_mass * g_amount) / 1000;
            tnewton_large_hydro.Text = Math.Ceiling(total_hydro_large_newton).ToString() + " N";
            this.total_hydro_large_quantity = total_hydro_large_newton / HydrogenThrusters.HydrogenPower.large_hydrogen_largegrid;
            large_hydrogen_thrusters_quantity.Text = Math.Ceiling(total_hydro_large_quantity).ToString();

            this.small_hydrogen_largegrid_quantity = newtons / HydrogenThrusters.HydrogenPower.small_hydrogen_largegrid;
            this.total_hydro_small_mass = (small_hydrogen_largegrid_quantity * HydrogenThrusters.HydrogenMass.small_hydrogen_largeg_mass) + mass_summary_set;
            tmass_small_hydro.Text = Math.Ceiling(total_hydro_small_mass).ToString() + " Kg";
            this.total_hydro_small_newton = (total_hydro_small_mass * g_amount) / 1000;
            tnewton_small_hydro.Text = Math.Ceiling(total_hydro_small_newton).ToString() + " N";
            this.total_hydro_small_quantity = total_hydro_small_newton / HydrogenThrusters.HydrogenPower.small_hydrogen_largegrid;
            small_hydrogen_thrusters_quantity.Text = Math.Ceiling(total_hydro_small_quantity).ToString();

            this.large_ion_largegrid_quantity = newtons / IonThrusters.IonPower.large_ion_largegrid; // Ion thrusters
            this.total_ion_large_mass = (large_ion_largegrid_quantity * IonThrusters.IonMass.large_ion_largeg_mass) + mass_summary_set;
            tmass_large_ion.Text = Math.Ceiling(total_ion_large_mass).ToString() + " Kg";
            this.total_ion_large_newton = (total_ion_large_mass * g_amount) / 1000;
            tnewton_large_ion.Text = Math.Ceiling(total_ion_large_newton).ToString() + " N";
            this.total_ion_large_quantity = total_ion_large_newton / IonThrusters.IonPower.large_ion_largegrid;
            large_ion_thrusters_quantity.Text = Math.Ceiling(total_ion_large_quantity).ToString();

            this.small_ion_largegrid_quantity = newtons / IonThrusters.IonPower.small_ion_largegrid;
            this.total_ion_small_mass = (small_ion_largegrid_quantity * IonThrusters.IonMass.small_ion_largeg_mass) + mass_summary_set;
            tmass_small_ion.Text = Math.Ceiling(total_ion_small_mass).ToString() + " Kg";
            this.total_ion_small_newton = (total_ion_small_mass * g_amount) / 1000;
            tnewton_small_ion.Text = Math.Ceiling(total_ion_small_newton).ToString() + " N";
            this.total_ion_small_quantity = total_ion_small_newton / IonThrusters.IonPower.small_ion_largegrid;
            small_ion_thrusters_quantity.Text = Math.Ceiling(total_ion_small_quantity).ToString();

            CalculationsAtmosphericConsumption(total_atmo_large_quantity, total_atmo_small_quantity, AtmosphericThrusters.AtmosphericConsumption.large_atmospheric_largegrid_fuel, AtmosphericThrusters.AtmosphericConsumption.small_atmospheric_largegrid_fuel);
            CalculationsHydrogenConsumption(total_hydro_large_quantity, total_hydro_small_quantity, HydrogenThrusters.HydrogenConsumption.large_hydrogen_largegrid_fuel, HydrogenThrusters.HydrogenConsumption.small_hydrogen_largegrid_fuel);
            CalculationsIonConsumption(total_ion_large_quantity, total_ion_small_quantity, IonThrusters.IonConsumption.large_ion_largegrid_fuel, IonThrusters.IonConsumption.small_ion_largegrid_fuel);
        }

        private void CalculationsForSmallgrid(double newtons)
        {
            this.large_atmospheric_smallgrid_quantity = newtons / AtmosphericThrusters.AtmosphericPower.large_atmospheric_smallgrid; // Atmospheric thrusters
            this.total_atmo_large_mass = (large_atmospheric_smallgrid_quantity * AtmosphericThrusters.AtmosphericMass.large_atmospheric_smallg_mass) + mass_summary_set;
            tmass_large_atmo.Text = Math.Ceiling(total_atmo_large_mass).ToString() + " Kg";
            this.total_atmo_large_newton = (total_atmo_large_mass * g_amount) / 1000;
            tnewton_large_atmo.Text = Math.Ceiling(total_atmo_large_newton).ToString() + " N";
            this.total_atmo_large_quantity = total_atmo_large_newton / AtmosphericThrusters.AtmosphericPower.large_atmospheric_smallgrid;
            large_atmospheric_thrusters_quantity.Text = Math.Ceiling(total_atmo_large_quantity).ToString();

            this.small_atmospheric_smallgrid_quantity = newtons / AtmosphericThrusters.AtmosphericPower.small_atmospheric_smallgrid;
            this.total_atmo_small_mass = (small_atmospheric_smallgrid_quantity * AtmosphericThrusters.AtmosphericMass.small_atmospheric_smallg_mass) + mass_summary_set;
            tmass_small_atmo.Text = Math.Ceiling(total_atmo_small_mass).ToString() + " Kg";
            this.total_atmo_small_newton = (total_atmo_small_mass * g_amount) / 1000;
            tnewton_small_atmo.Text = Math.Ceiling(total_atmo_small_newton).ToString() + " N";
            this.total_atmo_small_quantity = total_atmo_small_newton / AtmosphericThrusters.AtmosphericPower.small_atmospheric_smallgrid;
            small_atmospheric_thrusters_quantity.Text = Math.Ceiling(total_atmo_small_quantity).ToString();

            this.large_hydrogen_smallgrid_quantity = newtons / HydrogenThrusters.HydrogenPower.large_hydrogen_smallgrid; // Hydrogen thrusters
            this.total_hydro_large_mass = (large_hydrogen_smallgrid_quantity * HydrogenThrusters.HydrogenMass.large_hydrogen_smallg_mass) + mass_summary_set;
            tmass_large_hydro.Text = Math.Ceiling(total_hydro_large_mass).ToString() + " Kg";
            this.total_hydro_large_newton = (total_hydro_large_mass * g_amount) / 1000;
            tnewton_large_hydro.Text = Math.Ceiling(total_hydro_large_newton).ToString() + " N";
            this.total_hydro_large_quantity = total_hydro_large_newton / HydrogenThrusters.HydrogenPower.large_hydrogen_smallgrid;
            large_hydrogen_thrusters_quantity.Text = Math.Ceiling(total_hydro_large_quantity).ToString();

            this.small_hydrogen_smallgrid_quantity = newtons / HydrogenThrusters.HydrogenPower.small_hydrogen_smallgrid;
            this.total_hydro_small_mass = (small_hydrogen_smallgrid_quantity * HydrogenThrusters.HydrogenMass.small_hydrogen_smallg_mass) + mass_summary_set;
            tmass_small_hydro.Text = Math.Ceiling(total_hydro_small_mass).ToString() + " Kg";
            this.total_hydro_small_newton = (total_hydro_small_mass * g_amount) / 1000;
            tnewton_small_hydro.Text = Math.Ceiling(total_hydro_small_newton).ToString() + " N";
            this.total_hydro_small_quantity = total_hydro_small_newton / HydrogenThrusters.HydrogenPower.small_hydrogen_smallgrid;
            small_hydrogen_thrusters_quantity.Text = Math.Ceiling(total_hydro_small_quantity).ToString();

            this.large_ion_smallgrid_quantity = newtons / IonThrusters.IonPower.large_ion_smallgrid; // Ion thrusters
            this.total_ion_large_mass = (large_ion_smallgrid_quantity * IonThrusters.IonMass.large_ion_smallg_mass) + mass_summary_set;
            tmass_large_ion.Text = Math.Ceiling(total_ion_large_mass).ToString() + " Kg";
            this.total_ion_large_newton = (total_ion_large_mass * g_amount) / 1000;
            tnewton_large_ion.Text = Math.Ceiling(total_ion_large_newton).ToString() + " N";
            this.total_ion_large_quantity = total_ion_large_newton / IonThrusters.IonPower.large_ion_smallgrid;
            large_ion_thrusters_quantity.Text = Math.Ceiling(total_ion_large_quantity).ToString();

            this.small_ion_smallgrid_quantity = newtons / IonThrusters.IonPower.small_ion_smallgrid;
            this.total_ion_small_mass = (small_ion_smallgrid_quantity * IonThrusters.IonMass.small_ion_smallg_mass) + mass_summary_set;
            tmass_small_ion.Text = Math.Ceiling(total_ion_small_mass).ToString() + " Kg";
            this.total_ion_small_newton = (total_ion_small_mass * g_amount) / 1000;
            tnewton_small_ion.Text = Math.Ceiling(total_ion_small_newton).ToString() + " N";
            this.total_ion_small_quantity = total_ion_small_newton / IonThrusters.IonPower.small_ion_smallgrid;
            small_ion_thrusters_quantity.Text = Math.Ceiling(total_ion_small_quantity).ToString();

            CalculationsAtmosphericConsumption(total_atmo_large_quantity, total_atmo_small_quantity, AtmosphericThrusters.AtmosphericConsumption.large_atmospheric_smallgrid_fuel, AtmosphericThrusters.AtmosphericConsumption.small_atmospheric_smallgrid_fuel);
            CalculationsHydrogenConsumption(total_hydro_large_quantity, total_hydro_small_quantity, HydrogenThrusters.HydrogenConsumption.large_hydrogen_smallgrid_fuel, HydrogenThrusters.HydrogenConsumption.small_hydrogen_smallgrid_fuel);
            CalculationsIonConsumption(total_ion_large_quantity, total_ion_small_quantity, IonThrusters.IonConsumption.large_ion_smallgrid_fuel, IonThrusters.IonConsumption.small_ion_smallgrid_fuel);
        }

        private void CalculationsHydrogenConsumption(double largehydrogen, double smallhydrogen, double largefuel, double smallfuel)
        {
            double fuel_consume_large = Math.Ceiling(largehydrogen) * largefuel;
            fuel_consumption_large.Text = Math.Ceiling(fuel_consume_large).ToString() + " L/S";

            double fuel_consume_small = Math.Ceiling(smallhydrogen * smallfuel);
            fuel_consumption_small.Text = Math.Ceiling(fuel_consume_small).ToString() + " L/S";
        }

        private void CalculationsAtmosphericConsumption(double largeatm, double smallatm, double largeatmfuel, double smallatmfuel)
        {
            double atm_consume_large = Math.Ceiling(largeatm) * largeatmfuel;
            energy_consumption_large.Text = Math.Ceiling(atm_consume_large).ToString() + " KW";

            double atm_consume_small = Math.Ceiling(smallatm) * smallatmfuel;
            energy_consumption_small.Text = Math.Ceiling(atm_consume_small).ToString() + " KW";
        }

        private void CalculationsIonConsumption(double largeion, double smallion, double largeionfuel, double smallionfuel)
        {
            double ion_consume_large = Math.Ceiling(largeion) * largeionfuel;
            ion_consumption_large.Text = Math.Ceiling(ion_consume_large).ToString() + " KW";

            double ion_consume_small = Math.Ceiling(smallion) * smallionfuel;
            ion_consumption_small.Text = Math.Ceiling(ion_consume_small).ToString() + " KW";
        }

        private void ContainersActivationCheckedChanged(object sender, EventArgs e)
        {
            if (!activate_containers.Checked)
            {
                large_container_quantity.BackColor = Color.White;
                medium_container_quantity.BackColor = Color.White;
                small_container_quantity.BackColor = Color.White;
                activate_large_container.Checked = false;
                activate_medium_container.Checked = false;
                activate_small_container.Checked = false;
            }
            if (type_of_blocks.SelectedIndex == 0 && activate_containers.Checked)
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
            if (type_of_blocks.SelectedIndex == 0 && activate_containers.Checked)
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
            if (type_of_blocks.SelectedIndex == 1 && activate_containers.Checked)
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
            if (type_of_blocks.SelectedIndex == 1 && !activate_containers.Checked)
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

        #endregion Methods of calculating thrusters quantity and consumption

        #region Text fields and comboboxes

        private void LocationSelectorSelectedIndexChanged(object sender, EventArgs e)
        {
            button_calculation.Enabled = true;
            activate_containers.Enabled = true;

            if (user_location_choice.SelectedIndex == 0) // Earthlike
            {
                this.g_amount = 9807; // 1g
                this.planet_msv = 9.8;
                label_gs.Text = "1g";
                pictureBox1.Image = Resource1.earthlike_planet;
            }
            if (user_location_choice.SelectedIndex == 1) // Moon
            {
                this.g_amount = 2451; // 0.25g in Newtons
                this.planet_msv = 2.45;
                label_gs.Text = "0.25g";
                pictureBox1.Image = Resource1.moon_planet;
            }
            if (user_location_choice.SelectedIndex == 2) // Mars
            {
                this.g_amount = 8826; // 0.90g in Newtons
                this.planet_msv = 8.82;
                label_gs.Text = "0.90g";
                pictureBox1.Image = Resource1.mars_planet;
            }
            if (user_location_choice.SelectedIndex == 3) // Europa
            {
                this.g_amount = 2451; // 0.25g in Newtons
                this.planet_msv = 2.45; // 2.452ms
                label_gs.Text = "0.25g";
                pictureBox1.Image = Resource1.europa_planet;
            }
            if (user_location_choice.SelectedIndex == 4) // Triton
            {
                this.g_amount = 9807; // 1g
                this.planet_msv = 9.8;
                label_gs.Text = "1g";
                pictureBox1.Image = Resource1.triton_planet;
            }
            if (user_location_choice.SelectedIndex == 5) // Pertam
            {
                this.g_amount = 11768; // 1.20g in Newtons
                this.planet_msv = 11.77;
                label_gs.Text = "1.20g";
                pictureBox1.Image = Resource1.pertam_planet;
            }
            if (user_location_choice.SelectedIndex == 6) // Alien planet
            {
                this.g_amount = 10787; // 1.10g in Newtons
                this.planet_msv = 10.78;
                label_gs.Text = "1.10g";
                pictureBox1.Image = Resource1.alien_planet;
            }
            if (user_location_choice.SelectedIndex == 7) // Titan
            {
                this.g_amount = 2451; // 0.25g in Newtons
                this.planet_msv = 2.45;
                label_gs.Text = "0.25g";
                pictureBox1.Image = Resource1.titan_planet;
            }
        }

        private void CargoWithoutWeightCheckedChanged(object sender, EventArgs e)
        {
            if (without_ore.Checked)
            {
                full_of_ore.Checked = false;
            }
        }

        private void CargoWithWeightCheckedChanged(object sender, EventArgs e)
        {
            if (full_of_ore.Checked)
            {
                without_ore.Checked = false;
            }
        }

        private void LargeContainerQuantityTextChanged(object sender, EventArgs e)
        {
            bool check_large_cargo = double.TryParse(large_container_quantity.Text, out double value);
            if (!check_large_cargo)
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
        }

        private void MediumContainerQuantityTextChanged(object sender, EventArgs e)
        {
            bool check_medium_cargo = double.TryParse(medium_container_quantity.Text, out double value);
            if (!check_medium_cargo)
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
        }

        private void SmallContainerQuantityTextChanged(object sender, EventArgs e)
        {
            bool check_small_cargo = double.TryParse(small_container_quantity.Text, out double value);
            if (!check_small_cargo)
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
        }

        private void LargeContainerActivationCheckedChanged(object sender, EventArgs e)
        {
            if (activate_large_container.Checked)
            {
                large_container_quantity.BackColor = Color.Bisque;
            }
            if (!activate_large_container.Checked)
            {
                large_container_quantity.BackColor = Color.White;
                large_container_quantity.Text = "0";
            }
        }

        private void ActivateMediumContainerCheckedChanged(object sender, EventArgs e)
        {
            if (activate_medium_container.Checked)
            {
                medium_container_quantity.BackColor = Color.Bisque;
            }
            if (!activate_medium_container.Checked)
            {
                medium_container_quantity.BackColor = Color.White;
                medium_container_quantity.Text = "0";
            }
        }

        private void ActivateSmallContainerCheckedChanged(object sender, EventArgs e)
        {
            if (activate_small_container.Checked)
            {
                small_container_quantity.BackColor = Color.Bisque;
            }
            if (!activate_small_container.Checked)
            {
                small_container_quantity.BackColor = Color.White;
                small_container_quantity.Text = "0";
            }
        }

        private void TypeOfBlocksSelectorSelectedIndexChanged(object sender, EventArgs e)
        {
            user_entered_value.Enabled = true;
            user_entered_value.BackColor = Color.Bisque;
        }

        private void UserEnteredValueTextChanged(object sender, EventArgs e)
        {
            user_location_choice.BackColor = Color.Bisque;

            bool check_user_value = double.TryParse(user_entered_value.Text, out double value);
            if (!check_user_value)
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
        }

        private void SetFieldsToBasicValues()
        {
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

        #endregion Text fields and comboboxes

        #region Additional buttons

        private void SaveButtonClick(object sender, EventArgs e)
        {
            label_warning.Visible = true;
            label_warning.ForeColor = Color.Green;
            label_warning.Text = "File saved in program directory";

            string applicationPath = Path.GetFullPath(AppDomain.CurrentDomain.BaseDirectory);
            string saveFilePath = Path.Combine(applicationPath, "Saved_specs.txt");
            using var writer = new StreamWriter(saveFilePath, append: false);
            if (!activate_containers.Checked)
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
            if (activate_containers.Checked)
            {
                writer.WriteLine("Location: " + user_location_choice.Text.ToString());
                writer.WriteLine("Type of blocks: " + type_of_blocks.Text.ToString());
                writer.WriteLine("Cargo containers: Yes");
                if (full_of_ore.Checked)
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
        }

        private void InfoButtonClick(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
        }

        private void MixedCalculationsButtonClick(object sender, EventArgs e)
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
        }
    }

    #endregion Additional buttons
}