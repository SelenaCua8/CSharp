namespace desadiodos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Por favor ingrese un texto: ");
            string ingreso = Console.ReadLine();
            Console.WriteLine("ingrese el caracterque quiere buscar en el texto: ");
            char ingresoBuscado = Console.ReadLine()[0];
            int buscarIndice = ingreso.IndexOf(ingresoBuscado);
            Console.WriteLine("EL indice del caracter {0} en el texto es {1}", ingresoBuscado, buscarIndice);
            Console.ReadKey();
        }
    }
}