namespace Clases
{
    internal class Humano
    {
        public string primerNombre;
        public string apellido;

        public void presentarme()
        {
            Console.WriteLine($"Hola, mi nombre es {primerNombre} {apellido}.");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {

            Humano laura = new Humano();
            Humano franco = new Humano();
            laura.primerNombre = "Laura";
            franco.primerNombre = "Franco";
            laura.apellido = "Lopez";
            franco.apellido= "Milano";

            laura.presentarme();
            franco.presentarme();





            Console.Read();
        }
    }
}