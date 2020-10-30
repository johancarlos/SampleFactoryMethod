using System;

namespace FactoryMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Factory Method Sample";
            MovieFactory factory = new ConcreteMovieFactory();
            string res = "";
            do
            {
                Console.WriteLine("====== Movies ======");
                Console.WriteLine("Seleccionar Categoria");
                Console.WriteLine("1. Comedia");
                Console.WriteLine("2. Accion");
                Console.WriteLine("3. Ciencia y Ficcion");
                Console.WriteLine("Elegir Operacion: ");

                res = Console.ReadLine();
                string eleccion = Convert.ToString(res);

                switch (eleccion)
                {
                    case "1":
                        IMovie comedy = factory.GetMovie("Comedy");
                        comedy.ageClasification(0);
                        break;
                    case "2":
                        IMovie action = factory.GetMovie("Action");
                        action.ageClasification(16);
                        break;
                    case "3":
                        IMovie science = factory.GetMovie("Science Fiction");
                        science.ageClasification(12);
                        break;
                }
                Console.Write("Realizar otra operacion? si/no:");
                res = Console.ReadLine();
            }
            while (res == "si");
            Console.WriteLine("Proceso Finalizado");

        }

    }
}