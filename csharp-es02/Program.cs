using System;

//Tipi di dati

//Scalari
//    -Boolean
//    -Character
//    -Integer
//    -Real

//Strutturati
//    -Complessi
//    -Stringhe
//    -Strutture di dati
//    -Vettori
//    -Liste
//    -Tavole Hash
//    -Dizionari
//    -Alberi
//    -Grafi

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*for (char paperino = 'a'; paperino < 'z'; paperino++)
            {
                Console.WriteLine(paperino);

                var a = "aaa";
                //Utilizzo var <nome> per dichiarare una varibile assegnandogli
                //il tipo dell'oggetto che gli sto assegnando come valore
            }

            int n = 0;
            for (int i = 0; i < 512; i++)
            {
                if (n == 16)
                {
                    Console.WriteLine();
                    n = 0;
                }
                n++;

                //Console.Write("{0}", Convert.ToChar(i));

                Console.Write("{0}", (char)i);
                // l'operazione qua sopra (char) si chiama "casting"
                // praticamente gli dico di interpretare "i" come un carattere invece che come un int
            }

            for (char paperino = 'a'; paperino < 'z'; paperino++)
            {
                Console.WriteLine((long)paperino);
            }*/

            //--------------------------------------------------------------------------------------

            //ESERCIZIO
            //Un semplice calcolatore
            //Realizzare un programma che chiede all'utente che tipo di operazione intende
            //svolgere(0 - somma, 1 - prodotto, 2 - divisione, 3 - sottrazione, 4 - quadrato, 5 - media)
            //e poi se somma, prodotto, divisione o sottrazione chiede due valori, se quadrato
            //chiede un solo valore e se media chiede 10 valori.

            //Utilizzare un vettore di interi o reali(a vostra scelta) per archiviare i valori di input

            //Opzionale:  implementare l'operazione di elevamento a potenza superiore al 2.

            //aiutino
            //foreach (string s in "alfa beta gamma delta".Split(' '))
            //{
            //    Console.WriteLine("<{0}>", s);
            //}
            //foreach (string s in "alfa beta ; ; gamma delta".Split(new char[] { ' ', ';' }))
            ////creao un vettore e gli assegno dei valori divisi)
            //{
            //    Console.WriteLine("<{0}>", s);
            //}

            //----------------------

            
            bool finito = false;
            double[] numbers;

            while (!finito)
            {
                Console.WriteLine("Inserire un numero da 0 a 5 e premere invio per selezionare una delle seguenti operazioni");
                Console.WriteLine();
                Console.WriteLine("0 - somma");
                Console.WriteLine("1 - prodotto");
                Console.WriteLine("2 - divisione");
                Console.WriteLine("3 - sottrazione");
                Console.WriteLine("4 - quadrato");
                Console.WriteLine("5 - media");
                Console.WriteLine("9 - Esci");

                int iChoice = Convert.ToInt32(Console.ReadLine());

                //somma
                if (iChoice == 0)
                {
                    numbers = new double[2];
                    for (int i = 0; i < numbers.Length; i++)
                    {
                        Console.WriteLine("Inserisci un numero");
                        numbers[i] = Convert.ToDouble(Console.ReadLine());
                    }

                    double dSomma = numbers[0] + numbers[1];
                    Console.WriteLine("{0} + {1} = {2}", numbers[0], numbers[1], dSomma);
                }

                //prodotto
                else if (iChoice == 1)
                {
                    numbers = new double[2];
                    for (int i = 0; i < numbers.Length; i++)
                    {
                        Console.WriteLine("Inserisci un numero");
                        numbers[i] = Convert.ToDouble(Console.ReadLine());
                    }

                    double dProdotto = numbers[0] * numbers[1];
                    Console.WriteLine("{0} * {1} = {2}", numbers[0], numbers[1], dProdotto);
                }

                // divisione
                else if (iChoice == 2)
                {
                    numbers = new double[2];
                    for (int i = 0; i < numbers.Length; i++)
                    {
                        Console.WriteLine("Inserisci un numero");
                        numbers[i] = Convert.ToDouble(Console.ReadLine());
                    }

                    double dDivisione = numbers[0] / numbers[1];
                    Console.WriteLine("{0} / {1} = {2}", numbers[0], numbers[1], dDivisione);
                }

                // sottrazione
                else if (iChoice == 3)
                {
                    numbers = new double[2];
                    for (int i = 0; i < numbers.Length; i++)
                    {
                        Console.WriteLine("Inserisci un numero");
                        numbers[i] = Convert.ToDouble(Console.ReadLine());
                    }

                    double dSottrazione = numbers[0] - numbers[1];
                    Console.WriteLine("{0} - {1} = {2}", numbers[0], numbers[1], dSottrazione);
                }

                // potenza
                else if (iChoice == 4)
                {
                    numbers = new double[1];
                    Console.WriteLine("Inserisci un numero");
                    numbers[0] = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("Inserisci la potenza a cui vuoi elevare");
                    double dPotenza = Convert.ToDouble(Console.ReadLine());

                    double dRisultatoPotenza = Math.Pow(numbers[0], dPotenza);
                    Console.WriteLine("{0} elevato alla {1} da {2}", numbers[0], dPotenza, dRisultatoPotenza);
                }

                // media
                else if (iChoice == 5)
                {
                    numbers = new double[10];
                    double dSomma = 0;

                    for (int i = 0; i < numbers.Length; i++)
                    {
                        Console.WriteLine("Inserisci un numero");
                        numbers[i] = Convert.ToDouble(Console.ReadLine());
                    }

                    foreach (double element in numbers)
                    {
                        dSomma = +element;
                    }

                    double dMedia = dSomma / numbers.Length;

                    Console.WriteLine("La media dei numeri inseriti è {0}", dMedia);
                }
                
                // massimo
                else if (iChoice == 6)
                {
                    numbers = new double[10];
                    double dSomma = 0;

                    for (int i = 0; i < numbers.Length; i++)
                    {
                        Console.WriteLine("Inserisci un numero");
                        numbers[i] = Convert.ToDouble(Console.ReadLine());
                    }

                    foreach (double element in numbers)
                    {
                        dSomma = +element;
                    }

                    double dMedia = dSomma / numbers.Length;

                    Console.WriteLine("La media dei numeri inseriti è {0}", dMedia);
                }

                //validation
                else if (iChoice == 9)
                {
                    finito = true;
                }
            }
        }
    }
}
