using Entity;
namespace Datalayer;
public class DataAccess
{
    public static List<Movie> movie=new List<Movie>()
    {
        new Movie{ID=1, Name="Toofan",Ryear=2023,Ratings=3},
        new Movie{ID=2, Name="Ludo",Ryear=2021,Ratings=4},
        new Movie{ID=3, Name="Toofan",Ryear=2022,Ratings=3},
        new Movie{ID=4, Name="Gunjan",Ryear=2020,Ratings=5},
        new Movie{ID=5, Name="Big Bull",Ryear=2020,Ratings=4},

    };
    public List<Movie >GetMovies()
    {
        return movie;

    }
}
