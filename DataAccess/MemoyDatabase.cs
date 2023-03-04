namespace BlazorApp.DataAccess;
using BlazorApp.Data;

public class MemoryDatabase
{
    public List<Movie> Movies { get; set; }
    public List<Category> Categories { get; set; }
    public List<Actor> Actors { get; set; }

    public MemoryDatabase(){
        Movies = new List<Movie>();
        Categories = new List<Category>();
        Actors = new List<Actor>();
        
        AddDefaultActors();
        AddDefaultCategories();

        AddDefaultMovies();
    }

    private void AddDefaultCategories()
    {
        Categories.Add(new Category { Id = 1, Name = "Action" });
        Categories.Add(new Category { Id = 2, Name = "Comedy" });
        Categories.Add(new Category { Id = 3, Name = "Drama" });
        Categories.Add(new Category { Id = 4, Name = "Horror" });
        Categories.Add(new Category { Id = 5, Name = "Romance" });
        Categories.Add(new Category { Id = 6, Name = "Thriller" });
    }
    
    private void AddDefaultActors()
    {
        Actors.Add(new Actor { Id = 1, Name = "Tom Hanks", Bio = "Thomas Jeffrey Hanks is an American actor and filmmaker. Known for both his comedic and dramatic roles, Hanks is one of the most popular and recognizable film stars worldwide, and is widely regarded as an American cultural icon.", BirthDate = new DateTime(1956, 7, 9) });
        Actors.Add(new Actor { Id = 2, Name = "Morgan Freeman", Bio = "Morgan Freeman is an American actor, film director, and narrator. Freeman has also won a Golden Globe Award and a Screen Actors Guild Award.", BirthDate = new DateTime(1937, 6, 1) });
        Actors.Add(new Actor { Id = 3, Name = "Leonardo DiCaprio", Bio = "Leonardo Wilhelm DiCaprio is an American actor, film producer, and environmentalist. DiCaprio began his career by appearing in television commercials in the late 1980s. He made his film debut in 1991 in Critters 3.", BirthDate = new DateTime(1974, 11, 11) });
        Actors.Add(new Actor { Id = 4, Name = "Robert De Niro", Bio = "Robert Anthony De Niro is an American actor, producer, and director. De Niro is a recipient of various accolades, including two Academy Awards, a Golden Globe Award, the Cecil B. DeMille Award, the AFI Life Achievement Award, and the Presidential Medal of Freedom.", BirthDate = new DateTime(1943, 8, 17) });
        Actors.Add(new Actor { Id = 5, Name = "Al Pacino", Bio = "Alfredo James Pacino is an American actor and filmmaker. Pacino has had a career spanning over five decades, during which time he has received numerous accolades and honors both competitive and honorary, among them an Academy Award, two Tony Awards, two Primetime Emmy Awards, a British Academy Film Award, four Golden Globe Awards, the Lifetime Achievement Award from the American Film Institute, the Golden Globe Cecil B. DeMille Award, and the National Medal of Arts.", BirthDate = new DateTime(1940, 4, 25) });
        Actors.Add(new Actor { Id = 6, Name = "Brad Pitt", Bio = "William Bradley Pitt is an American actor and film producer. He has received multiple awards and nominations including an Academy Award as producer under his own company Plan B Entertainment.", BirthDate = new DateTime(1963, 12, 18) });
        Actors.Add(new Actor { Id = 7, Name = "Johnny Depp", Bio = "John Christopher Depp II is an American actor, producer, and musician. He has won the Golden Globe Award and Screen Actors Guild Award for Best Actor.", BirthDate = new DateTime(1963, 6, 9) });
    }

    private void AddDefaultMovies()
    {
        Category action = Categories.FirstOrDefault(c => c.Name == "Action");
        Category drama = Categories.FirstOrDefault(c => c.Name == "Drama");

        Movies.Add(new Movie { Id = 1, Title = "The Shawshank", Director = "Frank Darabont", ReleaseYear = 1994, Category = drama});
        Movies.Add(new Movie { Id = 2, Title = "The Godfather", Director = "Francis Coppola", ReleaseYear = 1972, Category = action});
        Movies.Add(new Movie { Id = 3, Title = "The Godfather", Director = "Francis Ford Coppola", ReleaseYear = 1974, Category = action});
        Movies.Add(new Movie { Id = 4, Title = "The Dark Knight", Director = "Christopher Nolan", ReleaseYear = 2008, Category = action});
        Movies.Add(new Movie { Id = 5, Title = "The Lord of the Rings", Director = "Peter Jackson", Category = drama });
        Movies.Add(new Movie { Id = 6, Title = "Pulp Fiction", Director = "Quentin Tarantino", ReleaseYear = 1994,  Category = drama});
        Movies.Add(new Movie { Id = 7, Title = "Schindler's List", Director = "Steven Spielberg", ReleaseYear = 1993,  Category = drama});
    }
}