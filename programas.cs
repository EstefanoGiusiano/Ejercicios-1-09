using System;

namespace Expert_SRP
{
    class Program
    {
        static void Main(string[] args)
        {
            Alfajor a = new Alfajor(10, 8.5); 
            // Esta mal el principio SRP ya que la responsabilidad sobre una no está sola parte de la funcionalidad
            //la tarea de convertir no debe estar dentro del kiosco
            Kiosco k = new Kiosco();
            if (k.PuedeComprar(a, 15, "$"))//podría ser otra clase - mal src
            {
                Console.WriteLine("Felicitaciones! Tiene suficiente dinero para comprar un alfajor :)");
            }
            else
            {
                Console.WriteLine("Mejor consiga un trabajo :(");
            }
        }
    }
}

-------------------------------------------------------------------------------------------

using System;

namespace SRP
{
    
    class Program
    {
        static void Main(string[] args)
        {
            Libro libro1 = new Libro("Design Patterns","Erich Gamma & Others","001-034");
            Libro libro2 = new Libro("Pro C#","Troelsen","001-035")
            libro1.AlmacenarLibro("A","7");
            //capas se podría hacer una clase pero en realidad está todo bien a mi parecer
            //establece que cada módulo o clase debe tener responsabilidad sobre una sola parte de la funcionalidad
            libro2.AlmacenarLibro("B","3");

        }
    }
}



-------------------------------------------------------------------------------------------
using System;
//todo bien
namespace Program
{
    class Program
    { 
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
