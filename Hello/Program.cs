// See https://aka.ms/new-console-template for more information
using Entity;
using BzLayer;
 
 MovieBz bz=new MovieBz();
 List<Movie> movies=bz.GetMovies();
 if(movies!=null)
 {
    foreach(var a in movies)
    {
        Console.WriteLine($"{a.ID} {a.Name}{a.Ratings} {a.Ryear}");
    }
     }
    
     else{
Console.WriteLine("No Movies found");
     }

Console.WriteLine("Hello World");