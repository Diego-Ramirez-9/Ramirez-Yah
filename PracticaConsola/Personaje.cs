namespace PracticaConsola
{
    public class Personaje
    {
        public string Nombre { get; set; }
        public int Vida { get; set; }
        public int Ataque { get; set; }


        public Personaje(string nombre, int vida, int ataque)
        {
            Nombre = nombre;
            Vida = vida;
            Ataque = ataque;

        }

        // Método para mostrar los datos en consola
        public void MostrarDatos()
        {
            Console.WriteLine($"Nombre:  {Nombre}");
            Console.WriteLine($"Vida:    {Vida}");
            Console.WriteLine($"Ataque:  {Ataque}");
            Console.WriteLine($"Defensa: {Defensa}");
            Console.WriteLine($"Nivel:   {Nivel}");
            Console.WriteLine("----------------------");
        }
    }
}
