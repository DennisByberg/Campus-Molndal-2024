namespace campus_molndal_2024_oop._08_design_patterns.Classes
{
    public class Burger
    {
        private string bunType;
        private string meatType;
        private string cheeseType;
        private string extras;

        private Burger(BurgerBuilder builder)
        {
            bunType = builder.BunType;
            meatType = builder.MeatType;
            cheeseType = builder.CheeseType;
            extras = builder.Extras;
        }

        public class BurgerBuilder
        {
            public string BunType { get; private set; }
            public string MeatType { get; private set; }
            public string CheeseType { get; private set; }
            public string Extras { get; private set; }

            public BurgerBuilder SetBunType(string bunType)
            {
                BunType = bunType;
                return this;
            }

            public BurgerBuilder SetMeatType(string meatType)
            {
                MeatType = meatType;
                return this;
            }

            public BurgerBuilder SetCheeseType(string cheeseType)
            {
                CheeseType = cheeseType;
                return this;
            }

            public BurgerBuilder SetExtras(string extras)
            {
                Extras = extras;
                return this;
            }

            public Burger Build()
            {
                return new Burger(this);
            }
        }

        public override string ToString()
        {
            return $"Burger [bunType={bunType}, meatType={meatType}, cheeseType={cheeseType}, extras={extras}]";
        }
    }
}
