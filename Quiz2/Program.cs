
using Quiz2.Entity;
using Quiz2.Servise;

CardServise cardServise = new CardServise();
TransactionServise transaction = new TransactionServise();
bool isRun = true;
bool isRun2 = true;
string userCard = "";
string password = "";
do
{
    Console.Clear();
    Console.Write("enter your card code: ");
    userCard = Console.ReadLine();
    Console.Write("enter your password: ");
    password = Console.ReadLine();
    var card = cardServise.Login(userCard, password);
    if (card != null)
    {
        do
        {
            var user = Online.card;
            user = card;
            Console.Clear();
            Console.WriteLine(" 1- Card to Card");
            Console.WriteLine(" 2- history");
            Console.WriteLine(" 3- Exit");
            Console.Write("enter option : ");
            var op = Console.ReadLine();
            isRun2 = true;
            switch (op)
            {
                case "1":
                    Console.Clear();
                    Console.Write("enter destination Card: ");
                    var destinationCard = Console.ReadLine();
                    Console.Write("enter Amount: ");
                    var Amount = float.Parse(Console.ReadLine());
                    var Transfer = transaction.Transfer(user.CardNumber, destinationCard, Amount);
                    if (Transfer == true)
                    {
                        Console.WriteLine("The operation was done");

                    }
                    else
                    {
                        Console.WriteLine("The operation was not performed");
                    }
                    Console.ReadKey();
                    break;
                case "2":
                    Console.Clear();
                    foreach (var item in transaction.GetTransactions(user.CardNumber))
                    {
                        Console.WriteLine(item);
                    }
                    Console.ReadKey();
                    break;
                case "3":
                    Console.Clear();
                    user = null;
                    isRun2 = false;
                    Console.WriteLine();
                    isRun2 = false;
                    break;
            }
        } while (isRun2 == true);
    }
    else
    {
        Console.WriteLine("username or password not true");
    }
} while (isRun);