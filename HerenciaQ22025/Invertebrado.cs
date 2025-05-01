
namespace HerenciaQ22025
{
    public class Invertebrado : Animal
    {
        public string? TipoCuerpo { get; set; }

        public string? MetodoReproduccion { get; set; }

        public string? TipoAlimentacion { get; set; }

        public string? CicloVida { get; set; }

        public string? Tamano { get; set; }

        public void Imprimir()
        {
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("**************************************************");
            Console.WriteLine($"Nombre: {Nombre}");
            Console.WriteLine($"Edad: {Edad} años");
            Console.WriteLine($"Especie: {Especie}");
            Console.WriteLine($"Hábitat: {Habitat}");
            Console.WriteLine($"Tipo de cuerpo: {TipoCuerpo}");
            Console.WriteLine($"Método de Reproducción: {MetodoReproduccion}");
            Console.WriteLine($"Tipo de alimentación: {TipoAlimentacion}");
            Console.WriteLine($"Ciclo de vida: {CicloVida}");
            Console.WriteLine($"Tamaño: {Tamano}");
            Console.WriteLine("**************************************************");
        }
    }
}
