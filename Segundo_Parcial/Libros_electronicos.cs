using System.Globalization;

namespace Segundo_Parcial
{
    public class Libros_electronicos:Libro
    {
        public string Formato {  get; set; }
        public int Peso { get; set; }
        public Libros_electronicos()
        {
            Formato = string.Empty; 
            Peso = 0;   
        }
    }
}
