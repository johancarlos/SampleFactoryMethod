using System;
namespace FactoryMethod
{
    public class Comedy:IMovie
    {
        public void ageClasification(int age)
        {
            Console.WriteLine("Esta Pelicula - Comedia es clasificada para mayores de " + age.ToString() + " años");
        }
    }
}
