namespace SE_Fight_Gravity
{
    public partial class Form3 : Form
    {
        #region Variables

        public double totall_mass { get; set; }
        public string block_type_f3 { get; set; }
        public double planet_ms { get; set; }
        public double large_atm_quantity = 0;
        public double small_atm_quantity = 0;
        public double large_hydro_quantity = 0;
        public double small_hydro_quantity = 0;
        public double large_ion_quantity = 0;
        public double small_ion_quantity = 0;
        public double power_percentage = 0.0;
        public double result_of_calculations = 0.0;

        public const double large_atmospheric_largegrid = 6480000;
        public const double small_atmospheric_largegrid = 648000;
        public const double large_hydrogen_largegrid = 7200000;
        public const double small_hydrogen_largegrid = 1080000;
        public const double large_ion_largegrid = 4320000;
        public const double small_ion_largegrid = 345600;

        public const double large_atmospheric_smallgrid = 576000;
        public const double small_atmospheric_smallgrid = 96000;
        public const double large_hydrogen_smallgrid = 480000;
        public const double small_hydrogen_smallgrid = 98400;
        public const double large_ion_smallgrid = 172800;
        public const short small_ion_smallgrid = 14400;

        #endregion Variables

        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            totall_mass_calc.Text = totall_mass.ToString();
            power_selector.SelectedIndex = 0;
            l_atm_thr.Text = "0";
            s_atm_thr.Text = "0";
            l_hydrogen_thrusters.Text = "0";
            s_hydrogen_thrusters.Text = "0";
            l_ion_thrusters.Text = "0";
            s_ion_thrusters.Text = "0";
            return;
        }

        #region Text fields

        private void l_atm_thr_TextChanged(object sender, EventArgs e)
        {
            bool check_field = Double.TryParse(l_atm_thr.Text, out double value);
            if (check_field == true)
            {
                this.large_atm_quantity = Convert.ToDouble(l_atm_thr.Text);
                calculate_power();
                statusbar();
                status_calc();
                label12.Visible = false;
                return;
            }
            else
            {
                label12.Visible = true;
            }
            return;
        }

        private void s_atm_thr_TextChanged(object sender, EventArgs e)
        {
            bool check_field = Double.TryParse(s_atm_thr.Text, out double value);
            if (check_field == true)
            {
                this.small_atm_quantity = Convert.ToDouble(s_atm_thr.Text);
                calculate_power();
                statusbar();
                status_calc();
                label12.Visible = false;
                return;
            }
            else
            {
                label12.Visible = true;
            }
            return;
        }

        private void l_hydrogen_thrusters_TextChanged(object sender, EventArgs e)
        {
            bool check_field = Double.TryParse(l_hydrogen_thrusters.Text, out double value);
            if (check_field == true)
            {
                this.large_hydro_quantity = Convert.ToDouble(l_hydrogen_thrusters.Text);
                calculate_power();
                statusbar();
                status_calc();
                label12.Visible = false;
                return;
            }
            else
            {
                label12.Visible = true;
            }
            return;
        }

        private void s_hydrogen_thrusters_TextChanged(object sender, EventArgs e)
        {
            bool check_field = Double.TryParse(s_hydrogen_thrusters.Text, out double value);
            if (check_field == true)
            {
                this.small_hydro_quantity = Convert.ToDouble(s_hydrogen_thrusters.Text);
                calculate_power();
                statusbar();
                status_calc();
                label12.Visible = false;
                return;
            }
            else
            {
                label12.Visible = true;
            }
            return;
        }

        private void l_ion_thrusters_TextChanged(object sender, EventArgs e)
        {
            bool check_field = Double.TryParse(l_ion_thrusters.Text, out double value);
            if (check_field == true)
            {
                this.large_ion_quantity = Convert.ToDouble(l_ion_thrusters.Text);
                calculate_power();
                statusbar();
                status_calc();
                label12.Visible = false;
                return;
            }
            else
            {
                label12.Visible = true;
            }
            return;
        }

        private void s_ion_thrusters_TextChanged(object sender, EventArgs e)
        {
            bool check_field = Double.TryParse(s_ion_thrusters.Text, out double value);
            if (check_field == true)
            {
                this.small_ion_quantity = Convert.ToDouble(s_ion_thrusters.Text);
                calculate_power();
                statusbar();
                status_calc();
                label12.Visible = false;
                return;
            }
            else
            {
                label12.Visible = true;
            }
            return;
        }

        #endregion Text fields

        private void power_selector_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (power_selector.SelectedIndex == 0)
            {
                power_percentage = 1;
            }
            if (power_selector.SelectedIndex == 1)
            {
                power_percentage = 0.9;
            }
            if (power_selector.SelectedIndex == 2)
            {
                power_percentage = 0.8;
            }
            if (power_selector.SelectedIndex == 3)
            {
                power_percentage = 0.7;
            }
            if (power_selector.SelectedIndex == 4)
            {
                power_percentage = 0.6;
            }
            if (power_selector.SelectedIndex == 5)
            {
                power_percentage = 0.5;
            }
            if (power_selector.SelectedIndex == 6)
            {
                power_percentage = 0.4;
            }
            if (power_selector.SelectedIndex == 7)
            {
                power_percentage = 0.3;
            }
            if (power_selector.SelectedIndex == 8)
            {
                power_percentage = 0.2;
            }
            if (power_selector.SelectedIndex == 9)
            {
                power_percentage = 0.1;
            }

            return;
        }

        private void calculate_power()
        {
            if (block_type_f3 == "large")
            {
                this.result_of_calculations = (((large_atmospheric_largegrid * large_atm_quantity) + (large_hydrogen_largegrid * large_hydro_quantity) + (large_ion_largegrid * large_ion_quantity) + (small_atmospheric_largegrid * small_atm_quantity) + (small_hydrogen_largegrid * small_hydro_quantity) + (small_ion_largegrid * small_ion_quantity)) * power_percentage) / planet_ms;
                current_power.Text = Math.Ceiling(result_of_calculations).ToString();
            }
            if (block_type_f3 == "small")
            {
                this.result_of_calculations = (((large_atmospheric_smallgrid * large_atm_quantity) + (large_hydrogen_smallgrid * large_hydro_quantity) + (large_ion_smallgrid * large_ion_quantity) + (small_atmospheric_smallgrid * small_atm_quantity) + (small_hydrogen_smallgrid * small_hydro_quantity) + (small_ion_smallgrid * small_ion_quantity)) * power_percentage) / planet_ms;
                current_power.Text = Math.Ceiling(result_of_calculations).ToString();
            }
            return;
        }

        private void statusbar()
        {
            try
            {
                progressBar1.Maximum = Convert.ToInt32(totall_mass);
                progressBar1.Minimum = 0;
                progressBar1.Value = Convert.ToInt32(result_of_calculations);
            }
            catch
            {
                progressBar1.Maximum = progressBar1.Value;
            }
            return;
        }

        private void status_calc()
        {
            if (result_of_calculations < totall_mass)
            {
                label12_not_enough.Visible = true;
                label14_enough.Visible = false;
            }
            if (result_of_calculations >= totall_mass)
            {
                label12_not_enough.Visible = false;
                label14_enough.Visible = true;
            }
            return;
        }
    }
}