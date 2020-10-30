using System;
namespace FactoryMethod
{
    public abstract class MovieFactory
    {
        public abstract IMovie GetMovie(string Movie);
    }
}
