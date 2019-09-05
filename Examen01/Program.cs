using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen01
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Playlists> playlists = new List<Playlists>();
            Playlists playlists1 = new Playlists("1)Romance", "perfecto par acomecia romantica");
            Playlists playlists2 = new Playlists("2)aventura", "con 10 canciones epicas...");

            playlists.Add(playlists1);
            playlists.Add(playlists2);

            playlists1.playlistdepeliculas.Add(new Pelicula("juanito2", "joseM.", "terror", "mexico", "juanito regresa por venganza", 1999, 3, 2));//poner para cachar y no se cierra le progrma 
            playlists1.playlistdepeliculas.Add(new Pelicula("juanito3", "joseM.J.", "comedia", "argentina", "juanito regresa por risas", 1999, 10, 1));
            playlists1.playlistdepeliculas.Add(new Pelicula("juanito4", "joseM.L", "ficcion", "venezuela", "juanito regresa por las galaxias", 1989,3, 1));
            playlists1.playlistdepeliculas.Add(new Pelicula("juanito5", "joseM.K", "terror2", "chile", "juanito regresa por mas venganza", 1998, 5, 3));
            playlists1.playlistdepeliculas.Add(new Pelicula("juanito6", "joseM.M", "suspenso", "japon", "juanito regresa por venganza", 1996, 4, 4));
            playlists1.playlistdepeliculas.Add(new Pelicula("juanito7", "joseM.G", "risa", "costa rica", "juanito regresa por chistes", 1990, 5, 7));
            playlists1.playlistdepeliculas.Add(new Pelicula("juanito8", "joseM.H", "aventura", "cuba", "juanito regresa por aventura", 1949, 2, 6));
            playlists1.playlistdepeliculas.Add(new Pelicula("juanito9", "joseM.T", "romance", "alemania", "juanito regresa por romance", 1899, 3, 8));


            playlists2.playlistdepeliculas.Add(new Pelicula("juanito10", "joseM.", "terror", "mexico1", "juanito regresa por venganza", 1999, 3, 2));//poner para cachar y no se cierra le progrma 
            playlists2.playlistdepeliculas.Add(new Pelicula("juanito11", "joseM.J.", "comedia", "argentina2", "juanito regresa por risas", 1998, 650, 1));
            playlists2.playlistdepeliculas.Add(new Pelicula("juanito12", "joseM.L", "ficcion", "venezuela3", "juanito regresa por las galaxias", 1998, 3, 1));
            playlists2.playlistdepeliculas.Add(new Pelicula("juanito13", "joseM.K", "terror2", "chile4", "juanito regresa por mas venganza", 1998, 4, 3));
            playlists2.playlistdepeliculas.Add(new Pelicula("juanito14", "joseM.M", "suspenso", "japon5", "juanito regresa por venganza", 1996, 4, 4));
            playlists2.playlistdepeliculas.Add(new Pelicula("juanito15", "joseM.G", "risa", "costa rica6", "juanito regresa por chistes", 1990, 5, 7));
            playlists2.playlistdepeliculas.Add(new Pelicula("juanito16", "joseM.H", "aventura", "cuba7", "juanito regresa por aventura", 1949, 2, 6));
            playlists2.playlistdepeliculas.Add(new Pelicula("juanito17", "joseM.T", "romance", "alemania8", "juanito regresa por romance", 1899, 3, 8));
            playlists2.playlistdepeliculas.Add(new Pelicula("juanito18", "joseM.H", "aventura", "cuba9", "juanito regresa por aventura", 1999, 2, 6));




            foreach (Playlists play in playlists)
            {
                Console.WriteLine("*" + play.Titulo + "-" + play.Descripcion);
                foreach(Pelicula peli in  play.playlistdepeliculas)
                {
                    Console.WriteLine("1) *" + peli.Titulo);

                    try
                    {
                        peli.Año = peli.Año;
                        Console.WriteLine("año:" + peli.Año);
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("el año no es correcto");
                    }

                }
            }


            Console.Read();

        }
    }
}
