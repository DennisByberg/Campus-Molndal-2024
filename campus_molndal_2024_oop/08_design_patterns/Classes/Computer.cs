using System;

namespace campus_molndal_2024_oop._08_design_patterns.Classes
{
    public class Computer
    {
        private readonly string CPU;
        private readonly string RAM;
        private readonly string Storage;
        private readonly string GraphicsCard;

        private Computer(ComputerBuilder builder)
        {
            CPU = builder.GetCPU();
            RAM = builder.GetRAM();
            Storage = builder.GetStorage();
            GraphicsCard = builder.GetGraphicsCard();
        }

        public static ComputerBuilder Builder(string cpu, string ram)
        {
            return new ComputerBuilder(cpu, ram);
        }

        public override string ToString()
        {
            return $"Computer Specifications:\n" +
                   $"- CPU: {CPU}\n" +
                   $"- RAM: {RAM}\n" +
                   $"- Storage: {Storage ?? "Not specified"}\n" +
                   $"- Graphics Card: {GraphicsCard ?? "Not specified"}";
        }

        public class ComputerBuilder
        {
            private string CPU { get; }
            private string RAM { get; }
            private string Storage { get; set; }
            private string GraphicsCard { get; set; }

            public ComputerBuilder(string cpu, string ram)
            {
                CPU = cpu ?? throw new ArgumentNullException(nameof(cpu));
                RAM = ram ?? throw new ArgumentNullException(nameof(ram));
            }

            public ComputerBuilder SetStorage(string storage)
            {
                Storage = storage;
                return this;
            }

            public ComputerBuilder SetGraphicsCard(string graphicsCard)
            {
                GraphicsCard = graphicsCard;
                return this;
            }

            public Computer Build() => new Computer(this);

            internal string GetCPU() => CPU;
            internal string GetRAM() => RAM;
            internal string GetStorage() => Storage;
            internal string GetGraphicsCard() => GraphicsCard;
        }
    }
}