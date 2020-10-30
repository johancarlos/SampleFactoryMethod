using System;
namespace FactoryMethod
{
    public class ConcreteMovieFactory: MovieFactory
    {
        public override IMovie GetMovie(string Movie)
        {
            switch (Movie)
            {
                case "Comedy":
                    return new Comedy();
                case "Action":
                    return new Action();
                case "Science Fiction":
                    return new ScienceFiction();
                default:
                    throw new Exception(string.Format("Movie '{0}' cannot be created", Movie));
            }

        }
    }
}
