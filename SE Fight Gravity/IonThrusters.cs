namespace SE_Fight_Gravity
{
    public static class IonThrusters
    {
        public static class IonPower
        {
            // Ion Thrusters Output Power (in Newtons)
            public const double large_ion_largegrid = 4320000;
            public const double small_ion_largegrid = 345600;
            public const double large_ion_smallgrid = 172800;
            public const double small_ion_smallgrid = 14400;
        }

        public static class IonConsumption
        {
            // Energy consumptions for Ion Thrusters (in KW)
            public const double large_ion_largegrid_fuel = 33600;
            public const double small_ion_largegrid_fuel = 3360;
            public const double large_ion_smallgrid_fuel = 2400;
            public const double small_ion_smallgrid_fuel = 200;
        }

        public static class IonMass
        {
            // Ion Thrusters Mass (in KG)
            public const double large_ion_largeg_mass = 43200;
            public const double small_ion_largeg_mass = 4380;
            public const double large_ion_smallg_mass = 721;
            public const double small_ion_smallg_mass = 121;
        }
    }
}