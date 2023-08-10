using System;

namespace Constructores
{
    public class Humano
    {
        public string nombre;
        public string apellido;
        public string colorOjos;
        public int edad;

        public Humano(string nombre, string apellido, string colorOjos, int edad)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.colorOjos = colorOjos;
            this.edad = edad;
        }

        public void presentarme()
        {

            if(edad == 1)
            Console.WriteLine($"Hola, mi nombre es {nombre} y mi apellido es {apellido}. Mi color de ojos es {colorOjos} y tengo un {edad} año.");
            else
                Console.WriteLine($"Hola, mi nombre es {nombre} y mi apellido es {apellido}. Mi color de ojos es {colorOjos} y tengo {edad} años.");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Humano luis = new Humano("Luis", "Garay", "marrón", 42);
            Humano ana = new Humano("Ana", "Maina", "verde", 1);

            luis.presentarme();
            ana.presentarme();

            Console.Read();
        }
    }
}