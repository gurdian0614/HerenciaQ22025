using HerenciaQ22025;

Vertebrado vertebrado = new Vertebrado();
Invertebrado invertebrado = new Invertebrado();
int opcion;

Console.WriteLine("********************************");
Console.WriteLine("*             MENU             *");
Console.WriteLine("* 1. Animal Vertebrado         *");
Console.WriteLine("* 2. Animal Invertebrado       *");
Console.WriteLine("********************************");
Console.Write("Escoja la opción: ");
opcion = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

switch(opcion)
{
    case 1:
        Console.WriteLine("*********************************");
        Console.WriteLine("*       ANIMAL VERTEBRADO       *");
        Console.WriteLine("*********************************");
        Console.Write("Nombre: ");
        vertebrado.Nombre = Console.ReadLine();
        Console.Write("Edad: ");
        vertebrado.Edad = Convert.ToInt32(Console.ReadLine());
        Console.Write("Especie: ");
        vertebrado.Especie = Console.ReadLine();
        Console.Write("Hábitat: ");
        vertebrado.Habitat = Console.ReadLine();
        Console.Write("Tipo de Esqueleto: ");
        vertebrado.TipoEsqueleto = Console.ReadLine();
        Console.Write("Número de extremidades: ");
        vertebrado.NumeroExtremidades = Convert.ToInt32(Console.ReadLine());
        Console.Write("Tipo de sangre: ");
        vertebrado.TipoSangre = Console.ReadLine();
        Console.Write("Dieta: ");
        vertebrado.Dieta = Console.ReadLine();
        Console.Write("Expectativa de vida: ");
        vertebrado.ExpectativaVida = Convert.ToInt32(Console.ReadLine());
        Console.Write("Tipo de Reproducción: ");
        vertebrado.Reproduccion = Console.ReadLine();
        vertebrado.Imprimir();
        break;

    case 2:
        Console.WriteLine("**********************************");
        Console.WriteLine("*       ANIMAL INVERTEBRADO      *");
        Console.WriteLine("**********************************");
        Console.Write("Nombre: ");
        invertebrado.Nombre = Console.ReadLine();
        Console.Write("Edad: ");
        invertebrado.Edad = Convert.ToInt32(Console.ReadLine());
        Console.Write("Especie: ");
        invertebrado.Especie = Console.ReadLine();
        Console.Write("Hábitat: ");
        invertebrado.Habitat = Console.ReadLine();
        Console.Write("Tipo de cuerpo: ");
        invertebrado.TipoCuerpo = Console.ReadLine();
        Console.Write("Método de reproducción: ");
        invertebrado.MetodoReproduccion = Console.ReadLine();
        Console.Write("Tipo de alimentación: ");
        invertebrado.TipoAlimentacion = Console.ReadLine();
        Console.Write("Ciclo de vida: ");
        invertebrado.CicloVida = Console.ReadLine();
        Console.Write("Tamaño: ");
        invertebrado.Tamano = Console.ReadLine();
        invertebrado.Imprimir();
        break;

    default:
        Console.WriteLine("Opción no válida");
        break;
}