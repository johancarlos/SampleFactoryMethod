using System;
namespace FactoryMethod
{
    public class Action:IMovie
    {
        public void ageClasification(int age)
        {
            Console.WriteLine("Esta Pelicula de Accion es clasificada para mayores de " + age.ToString() + " años");
        }
    }
}
