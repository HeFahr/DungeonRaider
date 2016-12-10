namespace DungeonRaider.Utils.Math
{
    public class StatFunction
    {
        public string StringPresentation { get; private set; } = "f(x) = (Factor * (x + xAddend)) ^ Exponent";

        public double Factor { get; private set; }
        public double XAddend { get; private set; }
        public double Exponent { get; private set; }


        public StatFunction(double factor, double xAddend, double exponent)
        {
            Factor = factor;
            XAddend = xAddend;
            Exponent = exponent;
        }

        public double f(double x)
        {
            return System.Math.Pow(Factor * (x + XAddend), Exponent);
        }
    }
}
