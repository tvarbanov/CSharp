using System;
using System.Collections.Generic;
using System.Threading;

class BlackJack
{
    static int money = 1000; //Start money
    static int bet = 5;
    static int dealerScore = 0;
    static int dealerCardsCount = 0;
    static int playerScore = 0;
    static int playerCardsCount = 0;
    static int pointer = 0; //Point place for the next card when printing
    static byte endGame = 0;
    static string dealerCard = string.Empty;
    static string playerCard = string.Empty;
    static string action = string.Empty;

    //Set console size
    public static void RemoveScrollBar()
    {
        Console.BufferHeight = Console.WindowHeight = 40;
        Console.BufferWidth = Console.WindowWidth = 110;
    }

    //Generate deck cards
    static List<string> Deck()
    {
        char[] suits = new char[] { 'C', 'S', 'H', 'D' };
        char[] ranks = new char[] { 'A', '2', '3', '4', '5', '6', '7', '8', '9', 'T', 'J', 'Q', 'K' };
        List<string> deckBeforeRandom = new List<string>();
        List<string> deckAfterRandom = new List<string>();
        Random random = new Random();

        foreach (char suit in suits)
        {
            foreach (char rank in ranks)
            {
                deckBeforeRandom.Add(suit.ToString() + rank);
            }
        }
        //Shuffle the deck
        while (0 < deckBeforeRandom.Count)
        {
            int randomCardIndex = (random.Next(deckBeforeRandom.Count));
            deckAfterRandom.Add(deckBeforeRandom[randomCardIndex]);
            deckBeforeRandom.RemoveAt(randomCardIndex);
        }
        return deckAfterRandom;
    }

    //Gets suit+rank of the card and the position of the top-left corner of the card
    static void PrintCard(char suit, char rank, int left, int top)
    {
        Console.BackgroundColor = ConsoleColor.White;
        if (suit == 'C')
        {
            suit = '♣';
            Console.ForegroundColor = ConsoleColor.Green;
        }
        else if (suit == 'S')
        {
            suit = '♠';
            Console.ForegroundColor = ConsoleColor.Black;
        }
        else if (suit == 'H')
        {
            suit = '♥';
            Console.ForegroundColor = ConsoleColor.Red;
        }
        else if (suit == 'D')
        {
            suit = '♦';
            Console.ForegroundColor = ConsoleColor.Blue;
        }

        Console.SetCursorPosition(left, top + 1);
        Console.WriteLine("╔═════════╗");
        Console.SetCursorPosition(left, top + 2);
        if (rank == 'T')
        {
            Console.WriteLine("║ 10      ║");
        }
        else
        {
            Console.WriteLine("║ {0}       ║", rank);
        }
        Console.SetCursorPosition(left, top + 3);
        Console.WriteLine("║ {0}       ║", suit);
        Console.SetCursorPosition(left, top + 4);
        Console.WriteLine("║         ║");
        Console.SetCursorPosition(left, top + 5);
        Console.WriteLine("║         ║");
        Console.SetCursorPosition(left, top + 6);
        Console.WriteLine("║       {0} ║", suit);
        Console.SetCursorPosition(left, top + 7);
        if (rank == 'T')
        {
            Console.WriteLine("║      10 ║");
        }
        else
        {
            Console.WriteLine("║       {0} ║", rank);
        }
        Console.SetCursorPosition(left, top + 8);
        Console.WriteLine("╚═════════╝");
        Console.BackgroundColor = ConsoleColor.DarkGreen;
        Console.ForegroundColor = ConsoleColor.Black;
    }

    //Take a card from the deck
    static string GetCard(List<string> deck)
    {
        string card = deck[0];
        deck.RemoveAt(0);
        return card;
    }

    //Calculate score 
    static int Score(int score, string card)
    {
        switch (card[1])
        {
            case '2': score += 2; break;
            case '3': score += 3; break;
            case '4': score += 4; break;
            case '5': score += 5; break;
            case '6': score += 6; break;
            case '7': score += 7; break;
            case '8': score += 8; break;
            case '9': score += 9; break;
            case 'T': score += 10; break;
            case 'J': score += 10; break;
            case 'Q': score += 10; break;
            case 'K': score += 10; break;
            case 'A':
                if (score + 11 > 21)
                {
                    score += 1; break;
                }
                else
                {
                    score += 11; break;
                }
            default: score += 0; break;
        }
        return score;
    }

    //Print score
    static void PrintScore(string participant, int top, int left, int score)
    {
        Console.ForegroundColor = ConsoleColor.White;
        Console.SetCursorPosition(left, top);
        Console.Write("{0}'s score: {1}", participant, score);
    }

    //Print hidden card
    static void PrintHiddenCard(int left, int top)
    {
        char symbol = '#';
        Console.BackgroundColor = ConsoleColor.White;
        Console.ForegroundColor = ConsoleColor.Red;
        Console.SetCursorPosition(left, top + 1);
        Console.WriteLine("╔═════════╗");
        Console.SetCursorPosition(left, top + 2);
        Console.WriteLine("║ {0}{0}{0}{0}{0}{0}{0} ║", symbol);
        Console.SetCursorPosition(left, top + 3);
        Console.WriteLine("║ {0}     {0} ║", symbol);
        Console.SetCursorPosition(left, top + 4);
        Console.WriteLine("║ {0}     {0} ║", symbol);
        Console.SetCursorPosition(left, top + 5);
        Console.WriteLine("║ {0}     {0} ║", symbol);
        Console.SetCursorPosition(left, top + 6);
        Console.WriteLine("║ {0}     {0} ║", symbol);
        Console.SetCursorPosition(left, top + 7);
        Console.WriteLine("║ {0}{0}{0}{0}{0}{0}{0} ║", symbol);
        Console.SetCursorPosition(left, top + 8);
        Console.WriteLine("╚═════════╝");
        Console.BackgroundColor = ConsoleColor.DarkGreen;
        Console.ForegroundColor = ConsoleColor.Black;
    }

    //Place bet
    static int PlaceBet(int money)
    {
        Console.BackgroundColor = ConsoleColor.DarkGreen; //Set background color
        Console.ForegroundColor = ConsoleColor.White; //Set text color
        Console.Clear();
        Console.SetCursorPosition(0, 0);
        Console.WriteLine("Money: ${0}", money);
        Console.WriteLine("Bets:");
        Console.WriteLine("1 - 1$");
        Console.WriteLine("2 - 5$");
        Console.WriteLine("3 - 10$");
        Console.WriteLine("4 - 20$");
        Console.WriteLine("5 - 50$");
        Console.WriteLine("6 - 100$");
        Console.Write("Pleace enter your bet(numbers from 1 to 6): ");
        bet = int.Parse(Console.ReadLine());

        switch (bet)
        {
            case 1: bet = 1; break;
            case 2: bet = 5; break;
            case 3: bet = 10; break;
            case 4: bet = 20; break;
            case 5: bet = 50; break;
            case 6: bet = 100; break;
        }
        PrintMoneyAndBet(); //Update top bar with current money and bet
        return bet;
    }

    //Dealer cards
    static void DealerCard(List<string> deck)
    {
        pointer = dealerCardsCount * 12;
        dealerCard = GetCard(deck);
        PrintCard(dealerCard[0], dealerCard[1], pointer, 3);
        dealerScore = Score(dealerScore, dealerCard);
        PrintScore("Dealer", 0, 24, dealerScore);
        dealerCardsCount++;
    }

    //Player cards
    static void PlayerCard(List<string> deck)
    {
        pointer = playerCardsCount * 12;
        playerCard = GetCard(deck);
        PrintCard(playerCard[0], playerCard[1], pointer, 14);
        playerScore = Score(playerScore, playerCard);
        PrintScore("Player", 0, 44, playerScore);
        playerCardsCount++;
    }

    //Printing current money and bet
    static void PrintMoneyAndBet()
    {
        Console.SetCursorPosition(0, 0);
        Console.WriteLine("Money: ${0} Bet: ${1}",money,bet);
    }

    //Actions
    static void Actions(List<string> deck)
    {
        Console.SetCursorPosition(0, 24);
        Console.WriteLine("1 - Double   2 - Hit   3 - Stand");
        Console.Write("\r" + new string(' ', Console.WindowWidth - 1) + "\r"); //Empty the line from previous actions
        action = Console.ReadLine();
        if (action == "1")
        {
            money -= bet; //Takes doubled bet from total money
            bet += bet; //Doubles the bet
            PrintMoneyAndBet(); //Show the new bet in top line
            PlayerCard(deck);
            if(playerScore > 21)
            {
                Console.SetCursorPosition(0, 27);
                Console.WriteLine("You are over 21! YOU LOSE!");
                action = "end";
                return;             
            }
            else if (playerScore == 21)
            {
                Console.SetCursorPosition(0, 27);
                Console.WriteLine("BLACKJACK!!! YOU WIN!!!");
                money += bet * 3;
                action = "end";
                return;
            }
            action = "3"; //Sets stand to proceed
        }     
        else if (action == "2")
        {
            PlayerCard(deck);
            if (playerScore > 21)
            {
                Console.SetCursorPosition(0, 27);
                Console.WriteLine("You are over 21! YOU LOSE!");
                action = "end";
                return;
            }
            else if (playerScore == 21)
            {
                Console.SetCursorPosition(0, 27);
                Console.WriteLine("BLACKJACK!!! YOU WIN!!!");
                money += bet * 3;
                action = "end";
                return;
            }
        }
        if (action == "3")
        {
            while (dealerScore <= 17)
            {
                DealerCard(deck);
                if (dealerScore > 21)
                {
                    Console.SetCursorPosition(0, 27);
                    Console.WriteLine("Dealer is over 21! YOU Win!");
                    money += bet + bet;
                    break;
                }
                else if (dealerScore > 17 && dealerScore == playerScore)
                {
                    Console.SetCursorPosition(0, 27);
                    Console.WriteLine("FLUSH!");
                    money += bet;
                    break;
                }
                else if (dealerScore > 17 && dealerScore > playerScore)
                {
                    Console.SetCursorPosition(0, 27);
                    Console.WriteLine("Dealer WINS!");
                    break;
                }
                else if (dealerScore > 17 && dealerScore < playerScore)
                {
                    Console.SetCursorPosition(0, 27);
                    Console.WriteLine("YOU WIN!");
                    money += bet + bet;
                    break;
                }
            }
            action = "end";         
        }
    }

    static void Main()
    {
        while (money > 0)
        {
            //Reset all variables
            dealerScore = 0;
            dealerCardsCount = 0;
            playerScore = 0;
            playerCardsCount = 0;
            pointer = 0;
            bet = 0;
            action = "";

            //Console size
            RemoveScrollBar();

            PlaceBet(money);
            money -= bet;

            List<string> deck = Deck(); //Fill the deck with cards
            Console.BackgroundColor = ConsoleColor.DarkGreen; //Set background color
            Console.ForegroundColor = ConsoleColor.White; //Set text color
            Console.Clear();

            PrintMoneyAndBet(); //Print top line with info about the current money and bet
            Console.WriteLine("──────────────────────────────────────────────────────────────────────────────────────────────────────────────");
            Console.SetCursorPosition(0, 2); //Set start possition below info bar at top

            //Dealer's cards
            Console.WriteLine("Dealer's Cards");
            DealerCard(deck);
            PrintHiddenCard(12, 3);
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine();

            //Dealer's cards
            Console.WriteLine("Player's Cards");
            PlayerCard(deck);
            PlayerCard(deck);
            Console.ForegroundColor = ConsoleColor.White;
            if (playerScore == 21) //Check if on first 2 card player has a blackjack
            {
                Console.SetCursorPosition(0, 27);
                Console.WriteLine("BLACKJACK!!! YOU WIN!!!");
                money += bet * 3;
                action = "end";
                return;
            }
            Console.WriteLine();

            while (action != "end")
            {
                Actions(deck);
            }

            Console.SetCursorPosition(0, 28);
            Console.WriteLine("New distribution in 5 seconds");
            Thread.Sleep(5000);
        }
    }
}
