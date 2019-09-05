using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen01
{
    class Playlists
    {
        public string Titulo { get; set; }
        public string Descripcion { get; set; }
        public List<Pelicula> playlistdepeliculas { get; set; }

        public Playlists()
        {
            Titulo = "no tiene titulo";
            Descripcion = "no cuenta con descripcion";
            playlistdepeliculas = new List<Pelicula>();
        }

        public Playlists(string titulo, string descripcion)
        {
            Titulo = titulo;
            Descripcion = descripcion;
            playlistdepeliculas = new List<Pelicula>();
        }
    }
}
