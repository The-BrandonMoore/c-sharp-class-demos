using CH20EFBmdbConsole.Db;
using CH20EFBmdbConsole.Models;

namespace CH20EFBmdbConsole
{
    internal class Program
    {
        static MovieDb movieDb = new();
        static ActorDb actorDb = new();
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Entity Framework, the BMDB Manager");

            string command = "";
            while (command != "exit")
            {
                DisplayMenu();
                command = PromptInput("Command:  ");

                switch (command)
                {
                    case "movies":
                    case "movie":
                        string movieCommand = "";
                        Console.WriteLine("\nYou have Entered the Movie Information Menu");
                        Console.WriteLine("To go back to the main menu, enter the command 'back'\n");
                        while (movieCommand != "back")
                        {
                            MovieMenu();
                            Console.Write("Enter a Movie Menu Keyword: ");
                            movieCommand = Console.ReadLine().ToLower();
                            switch (movieCommand)
                            {
                                case "list":
                                    ListMovies();
                                    break;
                                case "get":
                                    GetMovie();
                                    break;
                                case "add":
                                    AddMovie();
                                    break;
                                case "del":
                                    DeleteMovie();
                                    break;
                                case "back":
                                    break;
                                default:
                                    Console.WriteLine("Invalid keyword entered. Please enter a valid Menu keyword.");
                                    break;
                            }

                        }
                        break;
                    case ("actors"):
                    case ("actor"):
                        string actorCommand = "";
                        Console.WriteLine("\nYou Have Entered the Actor Information Menu");
                        Console.WriteLine("To go back to the main menu, enter the command 'back'\n");
                        while (actorCommand != "back")
                        {
                            ActorSubMenu();
                            Console.Write("Enter an Actor Menu Keyword: ");
                            actorCommand = Console.ReadLine().ToLower();
                            switch (actorCommand)
                            {
                                case ("menu"):
                                    ActorSubMenu();
                                    break;
                                case ("list"):
                                    ListActors();
                                    break;
                                case ("get"):
                                    GetActor();
                                    break;
                                case ("add"):
                                    AddActor();
                                    break;
                                case ("del"):
                                    DeleteActor();
                                    break;
                                case ("back"):
                                    break;
                                default:
                                    Console.WriteLine("Invalid keyword. Please enter a valid Menu keyword.");
                                    break;
                            }
                        }
                        break;
                    case ("exit"):
                        break;
                    default:
                        Console.WriteLine("Invalid keyword entered. Please enter a valid Menu keyword.");
                        break;

                }

            }
            Console.WriteLine("BYE");
        }
        //Actor Methods
        static void ActorSubMenu()
        {
            Console.WriteLine("  Actor Information Menu");
            Console.WriteLine("++++++++++++++++++++++++++++++");
            Console.WriteLine("Menu - Display Actor Info Menu");
            Console.WriteLine("List -- list all actors");
            Console.WriteLine("Get -- get actor information by ID");
            Console.WriteLine("Add -- add an actor");
            Console.WriteLine("Del -- delete an actor");
            Console.WriteLine("Back -- back to the main menu\n");
        }
        static void ListActors()
        {
            Console.WriteLine("\nActors List: ");
            Console.WriteLine("-------------");
            List<Actor> actors = actorDb.GetActors();
            foreach (Actor actor in actors)
            {
                Console.WriteLine(actor);
            }
        }
        static void GetActor()
        {
            Console.WriteLine("\nGet Actor By Id");
            Console.WriteLine("-----------------");
            int id = int.Parse(PromptInput("Actor ID:  "));
            Actor a = actorDb.FindActor(id);
            if (a != null)
            {
                Console.WriteLine($"Actor Found: {a}");
            }
            else
            {
                Console.WriteLine($"No Actor Found for ID: {id}");
            }
        }
        static void AddActor()
        {
            Console.WriteLine("\nAdd an Actor: ");
            Console.WriteLine("--------------");
            string firstName = PromptInput("FirstName: ");
            string lastName = PromptInput("Last Name: ");
            string gender = PromptInput("gender (m/f): ");
            DateOnly birthDate = DateOnly.Parse(PromptInput("Birthdate: "));
            Actor a = new Actor(firstName, lastName, gender, birthDate);
            actorDb.AddActor(a);
            Console.WriteLine($"Actor Added: {a}");
        }
        static void DeleteActor()
        {
            Console.WriteLine("\nDelete an actor: ");
            Console.WriteLine("-----------------");
            int id = int.Parse(PromptInput("Actor ID:  "));
            Actor a = actorDb.FindActor(id);
            if (a != null)
            {
                actorDb.RemoveActor(a);
                Console.WriteLine($"Actor Deleted");
            }
            else
            {
                Console.WriteLine($"No Actor Found for ID: {id}");
            }
        }

        // Movie methods
        static void MovieMenu()
        {
            Console.WriteLine("  Movie Information Menu");
            Console.WriteLine("++++++++++++++++++++++++++");
            Console.WriteLine("Menu - Display Movie Info Menu");
            Console.WriteLine("List -- list all movies");
            Console.WriteLine("Get -- get a movie by id");
            Console.WriteLine("Add -- add a movie");
            Console.WriteLine("Update -- Update a movie's title");
            Console.WriteLine("Del -- delete a movie");
            Console.WriteLine("Back -- back to the main menu\n");
        }
        static void ListMovies()
        {
            Console.WriteLine("\nMovies List: ");
            Console.WriteLine("-------------");
            List<Movie> movies = movieDb.GetMovies();
            foreach (Movie movie in movies)
            {
                Console.WriteLine(movie);
            }
        }
        static void GetMovie()
        {
            Console.WriteLine("\nGet Movie By Id");
            Console.WriteLine("-----------------");
            int id = int.Parse(PromptInput("Movie ID:  "));
            Movie m = movieDb.FindMovie(id);
            if (m != null)
            {
                Console.WriteLine($"Movie Found: {m}");
            }
            else
            {
                Console.WriteLine($"No Movie Found for ID: {id}");
            }
        }
        static void AddMovie()
        {
            Console.WriteLine("\nAdd a Movie: ");
            Console.WriteLine("--------------");
            string title = PromptInput("Movie Title: ");
            int year = int.Parse(PromptInput("Release Year: "));
            string rating = PromptInput("Age Rating: ");
            string director = PromptInput("Director: ");
            Movie m = new Movie(title, year, rating, director);
            movieDb.AddMovie(m);
            Console.WriteLine($"Movie Added: {m}");
        }
        static void DeleteMovie()
        {
            Console.WriteLine("\nDelete a movie: ");
            Console.WriteLine("-----------------");
            int id = int.Parse(PromptInput("Movie ID:  "));
            Movie m = movieDb.FindMovie(id);
            if (m != null)
            {
                movieDb.RemoveMovie(m);
                Console.WriteLine($"Movie Deleted");
            }
            else
            {
                Console.WriteLine($"No Movie Found for ID: {id}");
            }
        }


        static string PromptInput(string prompt)
        {
            Console.Write(prompt);
            return Console.ReadLine();
        }

        static void DisplayMenu()
        {
            Console.WriteLine("\n  Main Menu");
            Console.WriteLine("+++++++++++++");
            Console.WriteLine("Menu - Display Main Menu");
            Console.WriteLine("Movies -- Enter the Movie Information Sub-Menu");
            Console.WriteLine("Actors -- Enter the Actor Information Sub-Menu");
            Console.WriteLine("Exit -- exit the app\n");
        }




    }
}

