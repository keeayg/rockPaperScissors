namespace rockPaperScissors
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int RockChoice = 1;
            int PaperChoice = 2;
            int ScissorsChoice = 3;




            int draw = 0;

            int playerWins = 0;
            int computerWins = 0;
            Console.WriteLine("WELCOME TO ROCK PAPER SCİSSORS GAME!");
            Console.WriteLine("Do you want to Play?");
            Console.WriteLine("y/n");

            var yesOrNo = Console.ReadLine();

            if (yesOrNo == "y")
            {
                Console.WriteLine("What's your name?");

            }
            var playerName = Console.ReadLine();

            if (yesOrNo == "y")
            {
                while (playerWins != 3 || computerWins != 3)
                {
                    Console.WriteLine("");
                    Console.WriteLine("Make Choice\n1---Rock\n2---Paper\n3---Scissors");
                    int playerChoice = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine();
                    Random rndComp = new Random();
                    var randomComputerChoice = rndComp.Next(1, 3);
                   

                   // Console.WriteLine(randomComputerChoice);
                   // Console.WriteLine(playerChoice);
                    //play


                    if (playerChoice == 2 && randomComputerChoice == RockChoice)
                    {
                        ++playerWins;
                        Console.WriteLine($"Player's Choice: PAPER\nComputer Choice: ROCK");
                        Console.WriteLine($"{playerName} WİNS THİS ROUND. CONGRATULATİONS!!!");
                        Console.WriteLine();
                    }


                    if (playerChoice == 3 && randomComputerChoice == PaperChoice)
                    {
                        ++playerWins;
                        Console.WriteLine($"Player's Choice: SCİSSORS\nComputer Choice: PAPER");
                        Console.WriteLine($"{playerName} WİNS THİS ROUND. CONGRATULATİONS!!!");
                        Console.WriteLine();

                    }


                    if (playerChoice == 1 && randomComputerChoice == ScissorsChoice)
                    {
                        ++playerWins;
                        Console.WriteLine($"Player's Choice: ROCK\nComputer Choice: SCİSSORS");
                        Console.WriteLine($"{playerName} WİNS THİS ROUND. CONGRATULATİONS!!!");
                        Console.WriteLine();

                    }
                    // enemy
                    if (playerChoice == 3 && randomComputerChoice == RockChoice)
                    {
                        ++computerWins;
                        Console.WriteLine($"Player's Choice: SCİSSORS\nComputer Choice: ROCK");
                        Console.WriteLine($"{playerName} FUCKED BY COMPUTER");
                        Console.WriteLine();

                    }


                    if (playerChoice == 1 && randomComputerChoice == PaperChoice)
                    {
                        ++computerWins;
                        Console.WriteLine($"Player's Choice: ROCK\nComputer Choice: PAPER");
                        Console.WriteLine($"{playerName} FUCKED BY COMPUTER");
                        Console.WriteLine();

                    }


                    if (playerChoice == 2 && randomComputerChoice == ScissorsChoice)
                    {
                        ++computerWins;
                        Console.WriteLine($"Player's Choice: PAPER\nComputer Choice: SCİSSORS");
                        Console.WriteLine($"{playerName} FUCKED BY COMPUTER");
                        Console.WriteLine();

                    }




                    if (randomComputerChoice == 1 && playerChoice == 1)
                    {

                        ++draw;
                        Console.WriteLine("IT'S DRAW!!!1");
                        Console.WriteLine();

                    }
                    if (randomComputerChoice == 2 && playerChoice == 2)
                    {
                        ++draw;
                        Console.WriteLine("IT'S DRAW!!!");
                        Console.WriteLine();

                    }
                    if (randomComputerChoice == 3 && playerChoice == 3)
                    {
                        ++draw;
                        Console.WriteLine("IT'S DRAW!!!");
                        Console.WriteLine();

                    }
                    Console.WriteLine("------------------------------");
                    Console.WriteLine("PLAYER WİNS: " + playerWins);
                    Console.WriteLine("COPMUTER WİNS: " + computerWins);
                    Console.WriteLine("DRAW SCORE: " + draw);
                    Console.WriteLine("------------------------------");



                }
            }

        }
    }
}