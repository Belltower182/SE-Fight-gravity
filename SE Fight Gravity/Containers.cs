namespace SE_Fight_Gravity
{
    public static class Containers
    {
        public static class LargeContainers
        {
            // Container mass
            public const double largecargocontainer_mass_largegrid = 2593;
            public const double largecargocontainer_mass_smallgrid = 626;

            // Container mass full of uranium
            public const double largecargocontainer_with_uranium_largegrid = 1140203;
            public const double largecargocontainer_with_uranium_smallgrid = 42234;
        }

        public static class MediumContainers
        {
            // NOTE: Medium containers availiable only for small blocks.
            // Container mass
            public const double mediumcargocontainer_mass_smallgrid = 275;
            // Container mass full of uranium
            public const double mediumcontainer_with_uranium_smallgrid = 9123;
        }

        public static class SmallContainers
        {
            public const double smallcargocontainer_mass_largegrid = 649;
            public const double smallcargocontainer_mass_smallgrid = 49;
            public const double smallcargocontainer_with_uranium_largegrid = 1751;
            public const double smallcargocontainer_with_uranium_smallgrid = 132;
        }
    }
}