namespace Pair
{
    public class Piar
    {
        public int value1 { get; set; }
        public int value2 { get; set; }
        public int Prais ()
        {
            return value1 * value2;
        }
        public Piar Prais ( Piar CL2)
        {
            Piar p = new Piar ();
            p.value1= this .value1*CL2.value1;
            p.value2= this .value2*CL2.value2;
            return p;
        }
    }
}
