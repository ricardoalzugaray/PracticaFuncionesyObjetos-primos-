using System;

namespace GenerarNumerosPrimos
{
    class Program
    {
        #region Verificar  Primo
        public static bool EsPrimo(int num)
        {
            int divisibilidad;
            bool retorno;

            divisibilidad = 0;
            for (int divisor = 1; divisor <= num; divisor++)
            {
                if (num % divisor == 0)
                {
                    divisibilidad++;
                }
            }

            if (divisibilidad <= 2)
            {
                retorno = true;
            }
            else
            {
                retorno = false;
            }
            return retorno;
        }
        #endregion Verificar Primo

        static void Main(string[] args)
        {
            int desdeNum, hastaNum;
            bool resultado;

            Console.WriteLine("Ingrese el intervalo");
            desdeNum = Convert.ToInt32(Console.ReadLine());
            hastaNum = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\n Los números generados desde {0} a {1} son:", desdeNum, hastaNum);

            for (int num = desdeNum; num <= hastaNum; num++)
            {
                resultado = EsPrimo(num);

                if (resultado)
                {
                    Console.WriteLine(num);
                }
            }

            Console.ReadKey();
        }
    }
}

