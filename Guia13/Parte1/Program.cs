using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parte1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int CP, contCartas, tipoCarta, EmprMayor = 0, CartasMayor = 0;
            double pesoCarta, costoFinal, costoBase, recTotal = 0;
            double IVA = 21, costoIVA;
            for (int i = 1; i < 4; i++)
            {
                contCartas = 0;
                Console.WriteLine("\tEmpresa {0}", i);
                Console.Write("Ingrese el peso de la carta (para detener el ingreso, ingrese -1): ");
                pesoCarta = Convert.ToDouble(Console.ReadLine());
                Console.Write("Ingrese el codigo postal (para detener el ingreso, ingrese -1): ");
                CP = Convert.ToInt32(Console.ReadLine());
                while (CP != -1 && pesoCarta != -1)
                {
                    contCartas++;
                    Console.Write("Ingrese el tipo de carta (1 - Simple | 2 - Certificada): ");
                    tipoCarta = Convert.ToInt32((Console.ReadLine()));
                    if(tipoCarta == 1)
                    {
                        costoBase = pesoCarta * 0.5;
                        costoIVA = IVA / 100 * costoBase;
                        costoFinal = costoBase + costoIVA;
                    }
                    else
                    {
                        costoBase = pesoCarta;
                        costoIVA = IVA / 100 * costoBase;
                        costoFinal = costoBase + costoIVA;
                    }
                    Console.Clear();
                    Console.WriteLine("\tDatos de la Carta");
                    Console.WriteLine("Costo Base: ${0}\nIVA: {1}%\nCosto IVA: ${5}\nPeso de la Carta: {3}\nTipo de Carta: {4}\nCosto Final: ${2}",costoBase, IVA, costoFinal, pesoCarta, tipoCarta, costoIVA);
                    Console.WriteLine("Presione ENTER para continuar...");
                    recTotal += costoFinal;
                    Console.ReadKey();

                    Console.Write("Ingrese el peso de la carta (para detener el ingreso, ingrese -1): ");
                    pesoCarta = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Ingrese el codigo postal (para detener el ingreso, ingrese -1): ");
                    CP = Convert.ToInt32(Console.ReadLine());
                }
                if (i == 1)
                {
                    EmprMayor = i; 
                    CartasMayor = contCartas;
                }
                else if (CartasMayor < contCartas) 
                {
                    EmprMayor = i;
                    CartasMayor = contCartas;
                }
            }
            Console.WriteLine("La recaudacion Total es: ", recTotal);
            Console.WriteLine("La empresa con mayor correspondencia a entregar es la Empresa {0} ", EmprMayor);
            Console.WriteLine("Con {0} correspondencias", CartasMayor);
        }
    }
}
