using System.Globalization;

namespace Segundo_Parcial
{
    public class Libro
    {
        public string Titulo {  get; set; }
        public string Autor { get; set; }
        public string Genero { get; set; }
        public string A_publicacion {  get; set; }

        public Libro() 
        { 
            Titulo = string.Empty; 
            Autor = string.Empty;
            Genero = string.Empty;
            A_publicacion = string.Empty;
        }  
    }
}
