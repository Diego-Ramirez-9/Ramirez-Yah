using PracticaConsola;
internal class Program
{
    static void Main(string[] args)
    {
        Personaje guerrero = new Personaje("Arthur", 100, 25, 15, 1);
        Personaje mago = new Personaje("Merlín", 70, 40, 5, 3);

        // Mostrar sus datos
        guerrero.MostrarDatos();
        mago.MostrarDatos();

        guerrero.Vida -= mago.Ataque;
        Console.WriteLine($"{guerrero.Nombre} recibió un ataque. Vida restante: {guerrero.Vida}");

        Console.ReadKey();
    }
}
