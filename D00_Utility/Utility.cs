﻿using System;
using System.Runtime.ConstrainedExecution;
using System.Text;

namespace D00_Utility
{
    public static class Utility
    {
        // Encoding da consola, por exemplo, preparar a consola para receber carateres especiais
        public static void SetUnicodeConsole()
        {

            // Console.WriteLine("á Á à À ã Ã â Â ç Ç º ª");

            Console.OutputEncoding = Encoding.UTF8; // System.text

            // Console.WriteLine("á Á à À ã Ã â Â ç Ç º ª");


        }

        public static void WriteTitle(string title)
        {

            Console.WriteLine(new string('-', 50));

            Console.WriteLine(title.ToUpper());

            Console.WriteLine(new string('-', 50));

        }

        public static void WriteSubTitle(string subTitle)
        {

            Console.WriteLine(new string('-', 25));

            Console.WriteLine(subTitle);

            Console.WriteLine(new string('-', 25));

        }

        public static void TerminateConsole()
        {

            Console.WriteLine("\n\nPrime qualquer tecla para saíres.");
            Console.ReadKey(); 
            Console.Clear();

        }

        public static void BlockSeparator(string separator)
        {

            Console.Write(separator);

        }

        public static void WriteMessage(string message, string beginTerminator = "", string endTerminator = "")
        {
            Console.Write($"{beginTerminator}{message}{endTerminator}");
        }

        public static bool ValidateNumber0(double value)
        {
            // Criar o método ValidateNumber0() em D00_Utility:
            // Recebe 1 valor double
            // Devolve true se o número recebido for 0
            // Testem para ver se funciona
                // Console.WriteLine(Utility.ValidateNumber0(0));

            #region v1: Funcional, mas pouco otimizado
            /*
            if (value == 0)
            {
                return true;
            }
            else 
            {
                return false;
            }
            */
            #endregion

            #region v2: Usar o operador ternário
            /*
            return value == 0 ?  true : false;
            */
            #endregion


            #region v3: Versão otimizada

            return value == 0;
            
            #endregion


        }
        /*
        public static bool ValidateNumberDouble(string valueString)
        {

            bool tryParse = false;
            tryParse = double.TryParse(valueString, out double valueDouble);

            return valueDouble != 0;
        }
        */

        /*
        public static bool DoubleValidation(string valueString)
        {

            return double.TryParse(valueString, out double valueDouble) && valueDouble != 0;

        }
        */
                public static bool DoubleValidation(string valueString)
        {

            return double.TryParse(valueString, out double valueDouble) && valueDouble != 0;

        }

        internal static void TestInternal()
        {
            Console.WriteLine("Teste internal");
        } // sendo internal não é possível utilizar noutras assemblys

    }
}
