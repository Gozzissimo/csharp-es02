using System;

namespace Esercizio2
{
    public static class methods
    {
        public static void PopolamentoArray(ref double[] iArray)
        {
            for (int i = 0; i < iArray.Length; i++)
            {
                Console.WriteLine("Inserisci un numero");
                iArray[i] = Convert.ToDouble(Console.ReadLine());
            }
        }
    }
}