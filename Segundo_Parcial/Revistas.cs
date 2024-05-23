namespace Segundo_Parcial
{
    public class Revistas:Libro
    {
        public int Volumen {  get; set; }
        public int Numero_ejemplas { get; set; }
        public Revistas()
        {
            Volumen = 0;   
            Numero_ejemplas = 0;
        }
    }
}
