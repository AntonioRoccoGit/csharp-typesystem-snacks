using System;

namespace csharp_typesystem_snacks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //system variables;
            string[] availableGame = { "Maggiore", "Ordina Parole", "Somma Pazza", "Somme e Media?", "Solo Pari!!", "Invito?", "Free dispari", "Indice dispari?", "Non più di 50", "La Magia" };
            int choiceGame;


            //MAIN
            Console.WriteLine("------------------------Oggi ci divertiremo con qualche snack-----------------------");
            Console.WriteLine("---------------------------------Per favore scegli: --------------------------------");
            //choose the game
            for (int i = 0; i < availableGame.Length; i++)
            {
                Console.WriteLine($"{i+1}) {availableGame[i]}");

            }
            choiceGame = int.Parse(Console.ReadLine());
            switch (choiceGame)
            {
                case 1:
                    //Snack 1 : L’utente inserisce due numeri in successione.Il software stampa il maggiore.
                    int firstNumber;
                    int secondNumber;

                    Console.WriteLine("-------------------------------Hai selezionato maggiore--------------------------------");
                    Console.WriteLine();
                    Console.WriteLine("L’utente inserisce due numeri in successione.Il software stampa il maggiore.");
                    Console.WriteLine("Primo Numero: ");
                    firstNumber = int.Parse(Console.ReadLine());
                    Console.WriteLine("Secondo Numero: ");
                    secondNumber = int.Parse(Console.ReadLine());
                    if (firstNumber > secondNumber) { 
                        Console.WriteLine("il numero maggiore è: " + firstNumber);
                    } 
                    else if (secondNumber > firstNumber) {
                        Console.WriteLine("il numero maggiore è: " + secondNumber);
                    }else 
                    { 
                        Console.WriteLine("Nessun numero è più grande");
                    }

                    break;

                case 2:
                    //Snack 2 : L’utente inserisce due parole in successione.Il software stampa prima la parola più corta, poi la parola più lunga.
                    string firstWord;
                    string secondWord;
                    string message = "";

                    Console.WriteLine("-----------------------------------Ordina Parole------------------------------------");
                    Console.WriteLine("L’utente inserisce due parole, verranno visualizzate, in lunghezza crescente");
                    Console.WriteLine();
                    Console.WriteLine("La prima parola: ");
                    firstWord = Console.ReadLine();
                    Console.WriteLine("La seconda parola: ");
                    secondWord = Console.ReadLine();

                    if (firstWord.Length > secondWord.Length)
                    {
                        message = secondWord + ", " + firstWord;
                    }
                    else if (secondWord.Length > firstWord.Length)
                    {
                        message = firstWord + ", " + secondWord;
                    } 
                    else
                    {
                        message = $"Le parole sono lunghe uguali: {firstWord}, {secondWord}";
                    }

                    Console.WriteLine(message);

                    break;

                case 3:
                    //Snack 3: Il software deve chiedere per 10 volte all’utente di inserire un numero.Il programma stampa la somma di tutti i numeri inseriti.
                    int totalSum = 0;

                    Console.WriteLine("-----------------------------------Somma Pazza------------------------------------");
                    Console.WriteLine("Inserire 10 numeri, ne verrà fuori la somma");

                    for (int i = 0; i < 10; i++ )
                    {
                        Console.WriteLine($"Digitare il {i+1}° numero");
                        totalSum = totalSum + int.Parse(Console.ReadLine());
                    }

                    Console.WriteLine($"La somma di tutti i numeri è: {totalSum}");

                    break;

                case 4:
                    //Snack 4: Calcola la somma e la media dei numeri da 2 a 10.
                    float avarageNumber;
                    int totalSum4 = 0;
                    int minNumber = 2;
                    int maxNumber = 10;
                    int divisonNumber = 1; 

                    Console.WriteLine("-----------------------------------Somma e Media?------------------------------------");
                    Console.WriteLine("Hai mai voluto sapere la media e la somma dei numeri da 2 a 10?");
                    for (int i = minNumber; i <= maxNumber; i++)
                    {
                        totalSum4 = totalSum4 + i;
                        divisonNumber++;
                    }
                    avarageNumber = (float)totalSum4 / (float)divisonNumber;
                    Console.WriteLine($"La somma dei numeri è: {totalSum4}");
                    Console.WriteLine($"La media dei numeri è: {MathF.Round(avarageNumber, 2)}");

                    break;

                case 5:
                    //Snack 5: Il software chiede all’utente di inserire un numero.Se il numero inserito è pari, stampa il numero, se è dispari, stampa il numero successivo.
                    int userNumber;
                    int oddNumber;

                    Console.WriteLine("-------------------------------------Solo Pari--------------------------------------");
                    Console.WriteLine("Inserisci un numero: ");
                    userNumber = int.Parse(Console.ReadLine());

                    if (userNumber % 2 == 0) 
                    {
                        oddNumber = userNumber;
                    } else
                    {
                        oddNumber = userNumber + 1;
                    }

                    Console.WriteLine("ECCO UN BEL NUMERO PARI: " + oddNumber);

                    break;

                case 6:
                    //Snack 6: In un array sono contenuti i nomi degli invitati alla festa del grande Gatsby. Chiedi all’utente il suo nome e comunicagli se può partecipare o meno alla festa.
                    string[] bookedGuest = { "Pippo", "Pluto", "Mario", "Davide", "Admin", "Foo", "Bar", };
                    string userName;
                    string userMessage = "Mi dispiace dovremo ucciderla";

                    Console.WriteLine("--------------------------------------Invito?---------------------------------------");
                    Console.WriteLine("C'è un impostore tra la fila... e tu con quell'aria minacciosa, sei stato invitato?");
                    Console.WriteLine();
                    Console.WriteLine("Dai il tuo nome: ");
                    userName = Console.ReadLine();

                    for (int i = 0; i < bookedGuest.Length; i++) 
                    { 
                        if (bookedGuest[i] == userName)
                        {
                            userMessage = "Mi scusi non l'avevo riconosciuta";
                        }
                    }

                    Console.WriteLine(userMessage);

                    break;

                case 7:
                    //Snack 7: Crea un array vuoto. Chiedi per 6 volte all’utente di inserire un numero, se è dispari inseriscilo nell’array.
                    int[] evenArray = new int[6];
                    int positionCounter = 0;

                    Console.WriteLine("-------------------------------------Free Dispari--------------------------------------");

                    for (int i = 0; i < evenArray.Length; i++)
                    {
                        Console.WriteLine($"Inserisci {evenArray.Length} numeri. {i+1}°:  ");
                        int number = int.Parse(Console.ReadLine());

                        //se il numero è dispari
                        if(number % 2 == 1)
                        {
                            evenArray[positionCounter] = number;
                            positionCounter++;
                        }

                    }

                    Console.WriteLine("Ecco i tuoi numeri sfortunati!!! :)");
                    for (int i = 0; i < evenArray.Length; i++)
                    {
                        Console.WriteLine(evenArray[i]);
                    }

                    break;

                case 8:
                    //Snack 8: Crea un array di numeri interi e fai la somma di tutti gli elementi che sono in posizione dispari.
                    int[] intArray = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
                    int sumEvenIndex = 0;

                    Console.WriteLine("-------------------------------------Indice Dispari--------------------------------------");
                    Console.WriteLine("Di una serie di numeri, sommeremo solo quelli con indice dispari");
                    Console.WriteLine();
                    Console.WriteLine("Sequenza: ");
                    for(int i = 0; i < intArray.Length; i++)
                    {
                        int currentElement = intArray[i];
                        Console.WriteLine($"Numero: {currentElement} ha index: {i} - {(i%2 == 0 ? "pari" : "dispari")}");
                        if(i % 2 == 1)
                        {
                            sumEvenIndex = sumEvenIndex + currentElement;
                        }
                    }

                    Console.WriteLine("Ecco il risultato dell'esperimento: " + sumEvenIndex);

                    break;
            }




            //Snack 9: Crea un array vuoto e chiedi all’utente un numero da inserire nell’array.Continua a chiedere i numeri all’utente e a inserirli nell’array, fino a quando la somma degli elementi è minore di 50.
            //Snack 10: Fai inserire un numero, che chiameremo N, all’utente.Genera N array, ognuno formato da 10 numeri casuali tra 1 e 100.Ogni volta che ne crei uno, stampalo a schermo.
            //Buon lavoro!
            //POSSIBILE BONUS:
            //Creare un menù dove mostro gli snacks all'utente e chiedo quale vuole eseguire. Una volta la scelta il programma esegue il snack corrispondente.
        }
    }
}