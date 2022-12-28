namespace SE_Fight_Gravity
{
    public static class AtmosphericThrusters
    {
        public static class AtmosphericPower
        {
            // Atmospheric Thrusters Output Power (in Newtons)
            public const double large_atmospheric_largegrid = 6480000;
            public const double small_atmospheric_largegrid = 648000;
            public const double large_atmospheric_smallgrid = 576000;
            public const double small_atmospheric_smallgrid = 96000;
        }

        public static class AtmosphericConsumption
        {
            // Energy consumptions for Atmospheric Thrusters (in KW)
            public const double large_atmospheric_largegrid_fuel = 16800;
            public const double small_atmospheric_largegrid_fuel = 2400;
            public const double large_atmospheric_smallgrid_fuel = 2400;
            public const double small_atmospheric_smallgrid_fuel = 600;
        }

        public static class AtmosphericMass
        {
            // Atmospheric Thrusters Mass (in KG)
            public const double large_atmospheric_largeg_mass = 32970;
            public const double small_atmospheric_largeg_mass = 4000;
            public const double large_atmospheric_smallg_mass = 2948;
            public const double small_atmospheric_smallg_mass = 699;
        }
    }
}