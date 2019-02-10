using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS3020_HW2_OOP_Character_Battle
{
    class Program
    {
        static void Main(string[] args)
        {
            char classChoice = 'm';

            //Have users choose class and create character objects
            Console.WriteLine("Player 1, what class do you choose? m,w,a?");
            classChoice = char.Parse(Console.ReadLine());
            Character Player1 = CreateCharacter(classChoice, 1, 23);
            Console.WriteLine("Player 2, what class do you choose? m,w,a?");
            classChoice = char.Parse(Console.ReadLine());
            Character Player2 = CreateCharacter(classChoice, 2, 28);
           
            //Players battle till one runs out of HP
            while(Player1. health >= 0 && Player2.health >= 0)
            {
                PrintPositions(Player1.position, Player2.position);
                PrintHealth(Player1.health, Player2.health);
                if (Player1.priority <= Player2.priority)
                {
                    PrintOptions(Player1, Player2);
                    Player1.priority = 1;
                    Player2.priority = 0;
                }
                else
                {
                    PrintOptions(Player2, Player1);
                    Player1.priority = 0;
                    Player2.priority = 1;
                }
            }
            //Print winner
            if (Player1.health > Player2.health)
                Console.WriteLine("Player 1 wins.");
            else
                Console.WriteLine("Player 2 wins.");
        }
        static public Character CreateCharacter(char classChoice, int playerNum, int startingPosition)
        {
            switch (classChoice)
            {
                case 'm':
                    Mage MagePlayer = new Mage(playerNum, startingPosition);
                    return MagePlayer;
                case 'w':
                    Warrior WarriorPlayer = new Warrior(playerNum, startingPosition);
                    return WarriorPlayer;
                case 'a':
                    Archer ArcherPlayer = new Archer(playerNum, startingPosition);
                    return ArcherPlayer;
                default:
                    Mage DefaultPlayer = new Mage(playerNum, startingPosition);
                    return DefaultPlayer;
            }
                
        }
        static void PrintPositions(int player1Position, int player2Position)
        {
            Console.WriteLine("");
            for (int i = 1; i <= 50; i++)
            {
                if (i == player1Position)
                {
                    Console.Write("1");
                }
                if (i == player2Position)
                {
                    Console.Write("2");
                }
                if (i != player1Position && i != player2Position)
                {
                    Console.Write("-");
                }
            }
        }
        static void PrintHealth(int player1Health, int player2Health)
        {
            Console.WriteLine("\nPlayer 1 HP: " + player1Health + " - Player 2 HP: " + player2Health);
            Console.WriteLine("");
        }
        static void PrintOptions(Character Player, Character Target)
        {
            int menuChoice = 0;
            int moveUnits = 0;
            char attackChoice = 'n';
            Console.WriteLine("Player " + Player.num + ", what do you choose to do?");
            Console.WriteLine(Player.GetMovementAttackDescription());
            Console.WriteLine(Player.GetSpecialDescription());
            menuChoice = int.Parse(Console.ReadLine());
            switch (menuChoice)
            {
                case 1:
                    Console.WriteLine("How many units do you want to move?");
                    moveUnits = int.Parse(Console.ReadLine());
                    Console.WriteLine(Player.Move(moveUnits));
                    Console.WriteLine("Would you like to attack? y/n");
                    attackChoice = char.Parse(Console.ReadLine());
                    switch (attackChoice)
                    {
                        case 'y':
                            Console.WriteLine("You have opted to attack.");
                            Console.WriteLine(Player.Attack(Target));
                            break;
                        case 'n':
                            Console.WriteLine("You have opted not to attack.");
                            break;
                        default:
                            break;
                    }
                    break;
                case 2:
                    Console.WriteLine("You have opted for your special attack.");
                    Console.WriteLine(Player.Special(Target));
                    break;
                default:
                    break;
            }
        }
    }
}
