using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen01
{
    class Pelicula
    {
        public string Titulo { get; set; }
        private int _año;
        public int Año
        {
            get
            {
                return _año;
            }
            set
            {
                if(value > 1800 && value < 2019)
                {
                    _año = value;
                }
                else
                {
                    throw new Exception("no esta dentro del año correcto");
                }
            }
        }

        public string Director { get; set; }
        public string Genero { get; set; }
        public string PaisDeOrigen { get; set; }

        private int _duracion;


        public int Duracion
        {
            get
            {
                return _duracion;
            }
            set
            {
                if(value>0)
                {
                    _duracion = value;
                }
                else
                {
                    throw new Exception("no tiene la duracion adecuada");
                }
            }
        }

        private double _rating;
        public double Rating
        {
            get
            {
                return _rating;
            }
            set
            {
                if (value >= 0 && value <=10)
                {
                    _rating = value;
                }
                else
                {
                    throw new Exception("no tiene el rating de imdb adecuado");
                }
            }
        }

        public string Sinopsis { get; set; }




        public Pelicula ()
        {
            Titulo = "no tiene titulo";
            Director = "no tiene director";
            Genero="no tiene genero";
            PaisDeOrigen = "no tiene pais de origen";
            Sinopsis = "no tiene ninguna sinopsis";
            Año = 0;
            Duracion = 0;
            Rating = 0;

        }

        public Pelicula(string titulo, string director, string genero, string paisdeorigen, string sinopsis, int año, int duracion, double rating)
        {
            Titulo = titulo;
            Genero = genero;
            PaisDeOrigen = paisdeorigen;
            Sinopsis = sinopsis;
            Año = año;
            Duracion = duracion;
            Rating = rating;
            Director = director;
            
        }
    }
}
