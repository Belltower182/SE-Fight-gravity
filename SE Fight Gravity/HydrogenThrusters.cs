namespace SE_Fight_Gravity
{
    public static class HydrogenThrusters
    {
        public static class HydrogenPower
        {
            // Hydrogen Thrusters Output Power (In Newtons)
            public const double large_hydrogen_largegrid = 7200000;
            public const double small_hydrogen_largegrid = 1080000;
            public const double large_hydrogen_smallgrid = 480000;
            public const double small_hydrogen_smallgrid = 98400;
        }

        public static class HydrogenConsumption
        {
            // Hydrogen consumptions for Hydrogen Thrusters (in L/S)
            public const double large_hydrogen_largegrid_fuel = 4820;
            public const double small_hydrogen_largegrid_fuel = 803;
            public const double large_hydrogen_smallgrid_fuel = 386;
            public const double small_hydrogen_smallgrid_fuel = 80;
        }

        public static class HydrogenMass
        {
            // Hydrogen Thrusters Mass (in KG)
            public const double large_hydrogen_largeg_mass = 6940;
            public const double small_hydrogen_largeg_mass = 1420;
            public const double large_hydrogen_smallg_mass = 1222;
            public const double small_hydrogen_smallg_mass = 334;
        }
    }
}