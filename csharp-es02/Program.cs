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

namespace Esercizio2 // Note: actual namespace depends on the project name.
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
                Console.WriteLine("6 - max e min");
                Console.WriteLine("9 - Esci");

                int iChoice = Convert.ToInt32(Console.ReadLine());

                //somma
                if (iChoice == 0)
                {
                    numbers = new double[2];
                    methods.PopolamentoArray(ref numbers);

                    double dSomma = numbers[0] + numbers[1];
                    Console.WriteLine("{0} + {1} = {2}", numbers[0], numbers[1], dSomma);
                }

                //prodotto
                else if (iChoice == 1)
                {
                    numbers = new double[2];
                    methods.PopolamentoArray(ref numbers);

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
                    methods.PopolamentoArray(ref numbers);

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

                    methods.PopolamentoArray(ref numbers);

                    foreach (double element in numbers)
                    {
                        dSomma = +element;
                    }

                    double dMedia = dSomma / numbers.Length;

                    Console.WriteLine("La media dei numeri inseriti è {0}", dMedia);
                }
                
                // minimo e massimo
                else if (iChoice == 6)
                {
                    Console.WriteLine("Quanti numeri vuoi inserire?");
                    int iLunghezzaArray = Convert.ToInt32(Console.ReadLine());
                    numbers = new double[iLunghezzaArray];

                    methods.PopolamentoArray(ref numbers);

                    double maxValue = numbers.Max();
                    double minValue = numbers.Min();

                    Console.WriteLine("Il numero minimo tra i numeri inseriti è {0}, il massimo è {1}", minValue, maxValue);
                }

                //validation
                else if (iChoice == 9)
                {
                    finito = true;
                }
            }

            //TEORIA
            int v1, v2, v3;
            v1 = 10;
            v2 = 20;
            NuovoMetodo(v1, ref v2, out v3);
            Console.WriteLine("{0}, {1}, {2}", v1, v2, v3);

            bool bret;
            int iret;
            (bret, iret) = ValoriMultipli(3, 4);
            if (bret)
            {
                Console.WriteLine("La somma è andata bene e ha tornato: {0}", iret);
            }
        }

        static int NuovoMetodo(int n1, ref int n2, out  int n3)
        {
            //n1 passato per valore anche se lo modifico, la modifica non è propagata al chiamante
            n1 = 1000;

            //n2 è passato by reference. Quando lo modifico, il suo valore cambia anche nel chiamante
            n2 = 2000;

            //n3, passato solo come out, non mi interessa il suo valore in ingresso. Conta solo
            //che sono obbligato ad assegnargli un valore in uscita
            n3 = 3000;

            return 0;
        }

        //Questo metodo torna 2 valori, un bool e un int
        static (bool, int) ValoriMultipli(int a, int b)
        {
            //mettendo i valori tra parentesi tonde, si construisce un valore di ritorno multiplo
            return (true, a + b);
        }
    }
}
