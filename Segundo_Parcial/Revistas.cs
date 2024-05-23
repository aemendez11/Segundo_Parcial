namespace Segundo_Parcial
{
    public class Revistas:Libro
    {
        public int Volumen {  get; set; }
        public int Numero_ejemplar { get; set; }
        public Revistas()
        {
            Volumen = 0;   
            Numero_ejemplar = 0;
        }
    }
}
