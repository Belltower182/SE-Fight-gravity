namespace SE_Fight_Gravity
{
    public partial class Form1 : Form
    {
        #region Variables
        public const decimal newton = 9807;
        public decimal g_amount = 1;

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

        public const decimal large_atmospheric_largegrid_fuel = 16360000; // Mw
        public const decimal small_atmospheric_largegrid_fuel = 2360000; // Mw
        public const decimal large_atmospheric_smallgrid_fuel = 2400000; // Mw
        public const decimal small_atmospheric_smallgrid_fuel = 700000; // Mw

        public const decimal large_ion_largegrid = 4320000; // Ионные ускорители
        public const decimal small_ion_largegrid = 345600;
        public const decimal large_ion_smallgrid = 172800;
        public const decimal small_ion_smallgrid = 14400;

        public const decimal large_ion_largegrid_fuel = 33600000; // Mw
        public const decimal small_ion_largegrid_fuel = 3360000; // Mw
        public const decimal large_ion_smallgrid_fuel = 2400000; // Mw
        public const decimal small_ion_smallgrid_fuel = 200000; // Mw

        // Large Cargo Container
        public const decimal largecargocontainer_mass_smallgrid = 260; // Kg
        public const decimal largecargocontainer_volume_smalldrid = 16000; // Litres

        public const decimal largecargocontainer_mass_largegrid = 2450; // Kg
        public const decimal largecargocontainer_volume_largegrid = 421000; // Litres

        // Medium Cargo Container NOTE: Availiable only for small blocks.
        public const int mediumcargocontainer_mass_smallblock = 151; // Kg
        public const int mediumcargocontainer_volume_smallblock = 3400; //Litres

        // Small Cargo Container
        public const int smallcargocontainer_mass_smallblock = 73; // Kg
        public const int smallcargocontainer_volume_smallblock = 125; // Litres
        public const int smallcargocontainer_mass_bigblock = 576; // Kg
        public const int smallcargocontainer_volume_bigblock = 15625; // Litres
        #endregion

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void type_of_blocks_SelectedIndexChanged(object sender, EventArgs e)
        {
            user_entered_value.Enabled = true;
        }

        private void user_entered_value_TextChanged(object sender, EventArgs e)
        {
            user_location_choice.Enabled = true;
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
                pictureBox1.Image = Image.FromFile("C:\\Users\\Greg\\Desktop\\img\\earthlike.png");
            }
            if (user_location_choice.SelectedIndex == 1) // Moon
            {
                this.g_amount = 2451; // 0.25g in Newtons
                gravity_location.Text = "0.25g";
                height_of_gravity.Text = "2.678м";
                pictureBox1.Image = Image.FromFile("C:\\Users\\Greg\\Desktop\\img\\moon.png");
            }
            if (user_location_choice.SelectedIndex == 2) // Mars
            {
                this.g_amount = 8826; // 0.90g in Newtons
                gravity_location.Text = "0.90g";
                height_of_gravity.Text = "39.311м";
                pictureBox1.Image = Image.FromFile("C:\\Users\\Greg\\Desktop\\img\\mars.png");
            }
            if (user_location_choice.SelectedIndex == 3) // Europa
            {
                this.g_amount = 2451; // 0.25g in Newtons
                gravity_location.Text = "0.25g";
                height_of_gravity.Text = "3.150м";
                pictureBox1.Image = Image.FromFile("C:\\Users\\Greg\\Desktop\\img\\europa.png");
            }
            if (user_location_choice.SelectedIndex == 4) // Triton
            {
                this.g_amount = 9807; // 1g
                gravity_location.Text = "1g";
                height_of_gravity.Text = "36000м";
                pictureBox1.Image = Image.FromFile("C:\\Users\\Greg\\Desktop\\img\\triton.png");
            }
            if (user_location_choice.SelectedIndex == 5) // Pertam
            {
                this.g_amount = 11768; // 1.20g in Newtons
                gravity_location.Text = "1.20g";
                height_of_gravity.Text = "18.510м";
                pictureBox1.Image = Image.FromFile("C:\\Users\\Greg\\Desktop\\img\\pertam.png");
            }
            if (user_location_choice.SelectedIndex == 6) // Alien planet
            {
                this.g_amount = 10787; // 1.10g in Newtons
                gravity_location.Text = "1.10g";
                height_of_gravity.Text = "39.870м";
                pictureBox1.Image = Image.FromFile("C:\\Users\\Greg\\Desktop\\img\\alien.png");
            }
            if (user_location_choice.SelectedIndex == 7) // Titan
            {
                this.g_amount = 2451; // 0.25g in Newtons
                gravity_location.Text = "0.25g";
                height_of_gravity.Text = "Уточнить";
                pictureBox1.Image = Image.FromFile("C:\\Users\\Greg\\Desktop\\img\\titan.png");
            }
        }

        private void button_calculation_Click(object sender, EventArgs e)
        {
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

            decimal user_value_kg = decimal.Parse(user_entered_value.Text);
            decimal total_newton_value = g_amount * user_value_kg / 1000;
            newton_result.Text = Math.Ceiling(total_newton_value).ToString() + " N";

            if (type_of_blocks.SelectedIndex == 0 & activate_containers.Checked == false) // Большие блоки + чекбокс не выбран
            {
                decimal large_atmospheric_largegrid_quantity = total_newton_value / large_atmospheric_largegrid; // Атмосферные ускорители
                large_atmospheric_thrusters_quantity.Text = Math.Ceiling(large_atmospheric_largegrid_quantity).ToString();

                decimal small_atmospheric_largegrid_quantity = total_newton_value / small_atmospheric_largegrid;
                small_atmospheric_thrusters_quantity.Text = Math.Ceiling(small_atmospheric_largegrid_quantity).ToString();

                decimal large_hydrogen_largegrid_quantity = total_newton_value / large_hydrogen_largegrid; // Водородные ускорители
                large_hydrogen_thrusters_quantity.Text = Math.Ceiling(large_hydrogen_largegrid_quantity).ToString();

                decimal small_hydrogen_largegrid_quantity = total_newton_value / small_hydrogen_largegrid;
                small_hydrogen_thrusters_quantity.Text = Math.Ceiling(small_hydrogen_largegrid_quantity).ToString();

                decimal large_ion_largegrid_quantity = total_newton_value / large_ion_largegrid; // Ионные ускорители
                large_ion_thrusters_quantity.Text = Math.Ceiling(large_ion_largegrid_quantity).ToString();

                decimal small_ion_largegrid_quantity = total_newton_value / small_ion_largegrid;
                small_ion_thrusters_quantity.Text = Math.Ceiling(small_ion_largegrid_quantity).ToString();

                hydrogen_consumption(large_hydrogen_largegrid_quantity, small_hydrogen_largegrid_quantity, large_hydrogen_largegrid_fuel, small_hydrogen_largegrid_fuel);
                atmospheric_consumption(large_atmospheric_largegrid_quantity, small_atmospheric_largegrid_quantity, large_atmospheric_largegrid_fuel, small_atmospheric_largegrid_fuel);
                ion_consumption(large_ion_largegrid_quantity, small_ion_largegrid_quantity, large_ion_largegrid_fuel, small_ion_largegrid_fuel);
            }

            if (type_of_blocks.SelectedIndex == 1 & activate_containers.Checked == false) // Малые блоки + чекбокс не выбран
            {
                decimal large_atmospheric_smallgrid_quantity = total_newton_value / large_atmospheric_smallgrid; // Атмосферные ускорители
                large_atmospheric_thrusters_quantity.Text = Math.Ceiling(large_atmospheric_smallgrid_quantity).ToString();

                decimal small_atmospheric_smallgrid_quantity = total_newton_value / small_atmospheric_smallgrid;
                small_atmospheric_thrusters_quantity.Text = Math.Ceiling(small_atmospheric_smallgrid_quantity).ToString();

                decimal large_hydrogen_smallgrid_quantity = total_newton_value / large_hydrogen_smallgrid; // Водородные ускорители
                large_hydrogen_thrusters_quantity.Text = Math.Ceiling(large_hydrogen_smallgrid_quantity).ToString();

                decimal small_hydrogen_smallgrid_quantity = total_newton_value / small_hydrogen_smallgrid;
                small_hydrogen_thrusters_quantity.Text = Math.Ceiling(small_hydrogen_smallgrid_quantity).ToString();

                decimal large_ion_smallgrid_quantity = total_newton_value / large_ion_smallgrid; // Ионные ускорители
                large_ion_thrusters_quantity.Text = Math.Ceiling(large_ion_smallgrid_quantity).ToString();

                decimal small_ion_smallgrid_quantity = total_newton_value / small_ion_smallgrid;
                small_ion_thrusters_quantity.Text = Math.Ceiling(small_ion_smallgrid_quantity).ToString();

                hydrogen_consumption(large_hydrogen_smallgrid_quantity, small_hydrogen_smallgrid_quantity, large_hydrogen_smallgrid_fuel, small_hydrogen_smallgrid_fuel); // Рассчет потребления водорода
                atmospheric_consumption(large_atmospheric_smallgrid_quantity, small_atmospheric_smallgrid_quantity, large_atmospheric_smallgrid_fuel, small_atmospheric_smallgrid_fuel);
                ion_consumption(large_ion_smallgrid_quantity, small_ion_smallgrid_quantity, large_ion_smallgrid_fuel, small_ion_smallgrid_fuel);
            }
        }

        #region Calculation Power Methods
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
                switch_cargo_weight.Enabled = true;
                activate_large_container.Enabled = true;
                large_container_quantity.Enabled = true;
                activate_medium_container.Enabled = false;
                medium_container_quantity.Enabled = false;
                activate_small_container.Enabled = true;
                small_container_quantity.Enabled = true;
            }
            if (type_of_blocks.SelectedIndex == 0 & activate_containers.Checked == false)
            {
                switch_cargo_weight.Enabled = false;
                activate_large_container.Enabled = false;
                large_container_quantity.Enabled = false;
                activate_medium_container.Enabled = false;
                medium_container_quantity.Enabled = false;
                activate_small_container.Enabled = false;
                small_container_quantity.Enabled = false;
            }
            if (type_of_blocks.SelectedIndex == 1 & activate_containers.Checked == true)
            {
                switch_cargo_weight.Enabled = true;
                activate_large_container.Enabled = true;
                large_container_quantity.Enabled = true;
                activate_medium_container.Enabled = true;
                medium_container_quantity.Enabled = true;
                activate_small_container.Enabled = true;
                small_container_quantity.Enabled = true;
            }
            if (type_of_blocks.SelectedIndex == 1 & activate_containers.Checked == false)
            {
                switch_cargo_weight.Enabled = false;
                activate_large_container.Enabled = false;
                large_container_quantity.Enabled = false;
                activate_medium_container.Enabled = false;
                medium_container_quantity.Enabled = false;
                activate_small_container.Enabled = false;
                small_container_quantity.Enabled = false;
            }
        }
    }
}