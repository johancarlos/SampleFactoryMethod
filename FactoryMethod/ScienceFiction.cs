using System;
namespace FactoryMethod
{
    public class ScienceFiction:IMovie
    {
        public void ageClasification(int age)
        {
            Console.WriteLine("Esta Pelicula de Ciencia y Ficcion es clasificada para mayores de " + age.ToString() + " años");
        }
    }
}
