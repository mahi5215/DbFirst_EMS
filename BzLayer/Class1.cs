namespace BzLayer;
using Datalayer;
using Entity;
public class MovieBz
{
    public List<Movie> GetMovies()
    {
        DataAccess dataAccess= new DataAccess();
        return dataAccess.GetMovies();
    }
}
