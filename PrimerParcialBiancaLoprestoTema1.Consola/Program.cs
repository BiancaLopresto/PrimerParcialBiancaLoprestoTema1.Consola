namespace PrimerParcialBiancaLoprestoTema1.Consola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double altura;
            double area;
            double base1;
            int contador;
            double radio;
            double volumen;
            contador = 0;
            do
            {
                Console.Write("Ingresar la Altura del Cilindro: ");
                altura = Double.Parse(Console.ReadLine());
                Console.Write("Ingrese el Radio del Cilindro: ");
                radio = Double.Parse(Console.ReadLine());
                if (altura != 0 && radio != 0)
                {
                    area = 2 * Math.PI * radio * (altura + radio);
                    base1 = conseguirbase(radio);
                    volumen = base1 * altura;
                    Console.WriteLine("EL Area es: " + area);
                    Console.WriteLine("El Volumen es: " + volumen);
                }
                else
                {
                    Console.WriteLine("No pueden ser ambos ceros");
                }
                contador = contador + 1;
                Console.WriteLine("Los cilindros ingresados fueron: " + contador);
            } while (!(altura == 0 && radio == 0));
        }

        private static double conseguirbase(double radio)
        {
            return Math.PI * Math.Pow(radio,2);
        }
    }
}
    
