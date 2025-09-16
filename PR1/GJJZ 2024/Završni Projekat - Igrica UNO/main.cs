using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace UNO
{
    internal class Program
    {
        enum card
        {
            RED1, RED2, RED3, RED4, RED5, RED6, RED7, RED8, RED9, RED0, //RED_PLUS_TWO, RED_BLOCK,
            BLUE1, BLUE2, BLUE3, BLUE4, BLUE5, BLUE6, BLUE7, BLUE8, BLUE9, BLUE0, //BLUE_PLUS_TWO, BLUE_BLOCK,
            YELLOW1, YELLOW2, YELLOW3, YELLOW4, YELLOW5, YELLOW6, YELLOW7, YELLOW8, YELLOW9, YELLOW0, //YELLOW_PLUS_TWO, YELLOW_BLOCK,
            GREEN1, GREEN2, GREEN3, GREEN4, GREEN5, GREEN6, GREEN7, GREEN8, GREEN9, GREEN0, //GREEN_PLUS_TWO, GREEN_BLOCK,

            //CHANGE_COLOR, PLUS_FOUR

        }

        public struct game_settings
        {
            public int card_limit;
            public int start_with_how_many_cards;
        }
        static void print_a_card_from_info(char main, ConsoleColor card, string extra)
        {
            if (extra == null)
            {
                extra = "  ";
            }
            Console.ForegroundColor = ConsoleColor.White;
            //Console.WriteLine();
            Console.BackgroundColor = card;

            Console.Write(" UNO ");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.WriteLine("            .");
            Console.BackgroundColor = card;
            Console.Write("|");
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = card;
            Console.Write(" {0}", extra);
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = card;

            Console.Write("|");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.WriteLine("            .");
            Console.BackgroundColor = card;
            Console.Write("|");
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = card;

            Console.Write(" {0} ", main);

            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = card;

            Console.Write("|");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.WriteLine("            .");
            Console.BackgroundColor = card;
            Console.Write("|");
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = card;
            Console.Write("   ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = card;

            Console.Write("|");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.WriteLine("            .");
            Console.BackgroundColor = card;

            Console.Write("     ");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.WriteLine("            .");
            Console.BackgroundColor = card;
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
        }
        static void print_a_card(card card)
        {
            if (card == null)
            {
                return;
            }
            switch (card)
            {
                case card.RED0:
                    print_a_card_from_info('0', ConsoleColor.Red, null);
                    break;
                case card.RED1:
                    print_a_card_from_info('1', ConsoleColor.Red, null);
                    break;
                case card.RED2:
                    print_a_card_from_info('2', ConsoleColor.Red, null);
                    break;
                case card.RED3:
                    print_a_card_from_info('3', ConsoleColor.Red, null);
                    break;
                case card.RED4:
                    print_a_card_from_info('4', ConsoleColor.Red, null);
                    break;
                case card.RED5:
                    print_a_card_from_info('5', ConsoleColor.Red, null);
                    break;
                case card.RED6:
                    print_a_card_from_info('6', ConsoleColor.Red, null);
                    break;
                case card.RED7:
                    print_a_card_from_info('7', ConsoleColor.Red, null);
                    break;
                case card.RED8:
                    print_a_card_from_info('8', ConsoleColor.Red, null);
                    break;
                case card.RED9:
                    print_a_card_from_info('9', ConsoleColor.Red, null);
                    break;
                    /*
                case card.RED_BLOCK:
                    print_a_card_from_info('X', ConsoleColor.Red, null);
                    break;
                   
                case card.RED_PLUS_TWO:
                    print_a_card_from_info(' ', ConsoleColor.Red, "+2");
                    break;*/
                ///////////////////////////////////////////////////////// BLUE
                case card.BLUE0:
                    print_a_card_from_info('0', ConsoleColor.Blue, null);
                    break;
                case card.BLUE1:
                    print_a_card_from_info('1', ConsoleColor.Blue, null);
                    break;
                case card.BLUE2:
                    print_a_card_from_info('2', ConsoleColor.Blue, null);
                    break;
                case card.BLUE3:
                    print_a_card_from_info('3', ConsoleColor.Blue, null);
                    break;
                case card.BLUE4:
                    print_a_card_from_info('4', ConsoleColor.Blue, null);
                    break;
                case card.BLUE5:
                    print_a_card_from_info('5', ConsoleColor.Blue, null);
                    break;
                case card.BLUE6:
                    print_a_card_from_info('6', ConsoleColor.Blue, null);
                    break;
                case card.BLUE7:
                    print_a_card_from_info('7', ConsoleColor.Blue, null);
                    break;
                case card.BLUE8:
                    print_a_card_from_info('8', ConsoleColor.Blue, null);
                    break;
                case card.BLUE9:
                    print_a_card_from_info('9', ConsoleColor.Blue, null);
                    break;/*
                case card.BLUE_BLOCK:
                    print_a_card_from_info('X', ConsoleColor.Blue, null);
                    break;

                case card.BLUE_PLUS_TWO:
                    print_a_card_from_info(' ', ConsoleColor.Red, "+2");
                    break;*/
                ///////////////////////////////////////////////////////// YELLOW
                case card.YELLOW0:
                    print_a_card_from_info('0', ConsoleColor.DarkYellow, null);
                    break;
                case card.YELLOW1:
                    print_a_card_from_info('1', ConsoleColor.DarkYellow, null);
                    break;
                case card.YELLOW2:
                    print_a_card_from_info('2', ConsoleColor.DarkYellow, null);
                    break;
                case card.YELLOW3:
                    print_a_card_from_info('3', ConsoleColor.DarkYellow, null);
                    break;
                case card.YELLOW4:
                    print_a_card_from_info('4', ConsoleColor.DarkYellow, null);
                    break;
                case card.YELLOW5:
                    print_a_card_from_info('5', ConsoleColor.DarkYellow, null);
                    break;
                case card.YELLOW6:
                    print_a_card_from_info('6', ConsoleColor.DarkYellow, null);
                    break;
                case card.YELLOW7:
                    print_a_card_from_info('7', ConsoleColor.DarkYellow, null);
                    break;
                case card.YELLOW8:
                    print_a_card_from_info('8', ConsoleColor.DarkYellow, null);
                    break;
                case card.YELLOW9:
                    print_a_card_from_info('9', ConsoleColor.DarkYellow, null);
                    break;/*
                case card.YELLOW_BLOCK:
                    print_a_card_from_info('X', ConsoleColor.DarkYellow, null);
                    break;

                case card.YELLOW_PLUS_TWO:
                    print_a_card_from_info(' ', ConsoleColor.DarkYellow, "+2");
                    break;
                    */
                ///////////////////////////////////////////////////////// GREEN
                case card.GREEN0:
                    print_a_card_from_info('0', ConsoleColor.Green, null);
                    break;
                case card.GREEN1:
                    print_a_card_from_info('1', ConsoleColor.Green, null);
                    break;
                case card.GREEN2:
                    print_a_card_from_info('2', ConsoleColor.Green, null);
                    break;
                case card.GREEN3:
                    print_a_card_from_info('3', ConsoleColor.Green, null);
                    break;
                case card.GREEN4:
                    print_a_card_from_info('4', ConsoleColor.Green, null);
                    break;
                case card.GREEN5:
                    print_a_card_from_info('5', ConsoleColor.Green, null);
                    break;
                case card.GREEN6:
                    print_a_card_from_info('6', ConsoleColor.Green, null);
                    break;
                case card.GREEN7:
                    print_a_card_from_info('7', ConsoleColor.Green, null);
                    break;
                case card.GREEN8:
                    print_a_card_from_info('8', ConsoleColor.Green, null);
                    break;
                case card.GREEN9:
                    print_a_card_from_info('9', ConsoleColor.Green, null);
                    break;/*
                case card.GREEN_BLOCK:
                    print_a_card_from_info('X', ConsoleColor.Green, null);
                    break;

                case card.GREEN_PLUS_TWO:
                    print_a_card_from_info(' ', ConsoleColor.Green, "+2");
                    break;

                //// BLACK CARDS
                case card.CHANGE_COLOR:
                    print_a_card_from_info('?', ConsoleColor.DarkGray, "co");
                    break;

                case card.PLUS_FOUR:
                    print_a_card_from_info(' ', ConsoleColor.DarkGray, "+4");
                    break;*/


            }
        }


        static void print_error_message(string x)
        {

            ConsoleColor save = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("Information/Error: ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(x);

            Console.ForegroundColor = save;
        }


        static void ask_to_continue()
        {
            print_error_message("Continue? [ENTER]");
            Console.ReadLine();
        }
        static card return_card_system()
        {
            Array values = Enum.GetValues(typeof(card)); //stackoverflow
            Random random = new Random(); //stackoverflow
            card random_card = (card)values.GetValue(random.Next(values.Length)); //stackoverflow

            return random_card;
        }
        static card return_random_card(card[] x, int c)
        {
            card cardd = return_card_system();

            while (cardd == x[c])
            {
                cardd = return_card_system();
            }
            return cardd;
        }


        static card[] bring_new_card_to_deck(card[] x, int c)
        {

            if (c < x.Length)
            {


                x.SetValue(return_random_card(x, c), c + 1);
            }
            else
            {
                print_error_message("You have reached the max card array value of " + x.Length);
            }

            return x;
        }

        static void print_your_deck(card[] x, int c)
        {
            print_error_message("Your deck: ");
            for (int i = 0; i < c; i++)
            {
                Console.WriteLine("                " + (i + 1) + ": ");
                print_a_card(x[i]);
            }
        }

        static void print_uno_textart()
        {
            Console.WriteLine("\r\n██╗░░░██╗███╗░░██╗░█████╗░\r\n██║░░░██║████╗░██║██╔══██╗\r\n██║░░░██║██╔██╗██║██║░░██║\r\n██║░░░██║██║╚████║██║░░██║\r\n╚██████╔╝██║░╚███║╚█████╔╝\r\n░╚═════╝░╚═╝░░╚══╝░╚════╝░"); //preuzeto sa fsymbols.com
            Console.WriteLine("");


            //Console.WriteLine("\r\n███╗░░░███╗░█████╗░██████╗░██╗██╗░░░██╗░██████╗\r\n████╗░████║██╔══██╗██╔══██╗██║██║░░░██║██╔════╝\r\n██╔████╔██║███████║██████╔╝██║██║░░░██║╚█████╗░\r\n██║╚██╔╝██║██╔══██║██╔══██╗██║██║░░░██║░╚═══██╗\r\n██║░╚═╝░██║██║░░██║██║░░██║██║╚██████╔╝██████╔╝\r\n╚═╝░░░░░╚═╝╚═╝░░╚═╝╚═╝░░╚═╝╚═╝░╚═════╝░╚═════╝░");
        }
        static void clear_console()
        {
            Console.Clear();
            print_uno_textart();
        }
        static bool check_compatibity(card a, card b)
        {
            string a_string = a.ToString();
            string b_string = b.ToString();
            if (a_string[0] == b_string[0]) //proveriti boju
            {
                //Console.WriteLine("111");
                return true;
            }
            else if (a_string[a_string.Length - 1] == b_string[b_string.Length - 1]) //sa iste brojeve, za block/plus_two (zavrsavaju se sa k i o)
            {
                //Console.WriteLine("222");
                return true;

            }/*
            else if (b == card.PLUS_FOUR) //crna karta moze na svaku
            {
                Console.WriteLine("333");
                return true;
            }
            else if (b == card.CHANGE_COLOR) //crna karta moze na svaku
            {
                Console.WriteLine("444");
                return true;
            }*/
            else
            {
                return false;
            }
        }
        static card[] move_card_outside_of_deck(card[] x, int index_of_removed, int place)
        {
            x.SetValue(x[place - 1], index_of_removed);

            x.SetValue(null, place);
            return x;
        }
        static string get_player_move()
        {
            Console.WriteLine();
            ConsoleColor save = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("->  Your move [CARD INDEX]: ");
            Console.ForegroundColor = ConsoleColor.White;
            string a = Console.ReadLine();


            Console.ForegroundColor = save;
            return a;

        }
        static card find_compatible_card(card a)
        {

            card x = return_card_system();
            while (check_compatibity(a, x)==false)
            {
                x = return_card_system();
            }
            return x;
        }
        static void print_a_current_card(card current_card_on_table)
        {
            print_error_message("This card is on the table: ");
            print_a_card(current_card_on_table);
        }

        static void Main(string[] args)
        {
            //Pisao sam promenljive na engleskom 👍


            Console.Title = "UNO Game - by Luka Orlic";
            clear_console();
            game_settings settings = new game_settings();
            settings.card_limit = 100;
            settings.start_with_how_many_cards = 2;

            int occupied_space = 0;
            int number_of_moves = 0;

            card[] card_list = new card[settings.card_limit];


            //               ISPISUJEMO INSTRUKCIJE
            print_error_message("Hello, we are playing this game by these settings. ");
            print_error_message("Card deck limit: " + settings.card_limit);
            print_error_message("You start with how many cards: " + settings.start_with_how_many_cards);
            string possible_cards = "";
            foreach (string name in Enum.GetNames(typeof(card)))
            {
                possible_cards += name + ", ";
            }
            print_error_message("Here are all imported cards in this game: " + possible_cards);
            ask_to_continue();
            clear_console();
            print_error_message("To draw a new card type [D].");
            print_error_message("To drop a card type [CARD INDEX].");
            ask_to_continue();

            print_error_message("Now we will create your deck. ");
            ask_to_continue();
            clear_console();



            //                 PRAVIMO DECK
            for (int i = 0; i < settings.start_with_how_many_cards; i++)
            {
                card_list = bring_new_card_to_deck(card_list, occupied_space);
                occupied_space++;
            }
            for (int i = settings.start_with_how_many_cards; i < settings.card_limit; i++)
            {
                card_list.SetValue(null, i);
            }
            print_your_deck(card_list, occupied_space);
            ask_to_continue();


            card current_card_on_table = return_card_system();
            print_a_current_card(current_card_on_table);

            //                IGRA

            while (occupied_space > 0)
            {


                string move = get_player_move().ToUpper();
                int n;
                bool isNumeric = int.TryParse(move, out n); ///STACK OVERFLOW

                if (isNumeric = true && move != "" && move != "D")
                {

                    isNumeric = int.TryParse(move, out n);
                    if (n > 0 && n <= occupied_space)
                    {
                        //Console.WriteLine(move);
                        //Console.WriteLine("pass 1");
                        if (check_compatibity(current_card_on_table, card_list[n - 1]) == true)
                        {
                            //Console.WriteLine("pass 2");
                            current_card_on_table = card_list[n - 1];
                            move_card_outside_of_deck(card_list, n - 1, occupied_space);
                            occupied_space--;
                            clear_console();
                            print_error_message("Good job! ");
                            if (occupied_space != 0)
                            {
                                print_error_message("Computer played: ");
                                current_card_on_table = find_compatible_card(current_card_on_table);
                                print_a_card(current_card_on_table);
                            }
                           
                         
                            number_of_moves++;
                        }
                        else
                        {
                            clear_console();
                            print_error_message("Card you've chosen was incompatible. We will bring new card to your deck. ");
                            ask_to_continue();
                            clear_console();
                            card_list = bring_new_card_to_deck(card_list, occupied_space);
                            occupied_space++;
                            if (occupied_space != 0)
                            {
                                print_error_message("Computer played: ");
                                current_card_on_table = find_compatible_card(current_card_on_table);
                                print_a_card(current_card_on_table);
                            }

                            number_of_moves++;
                        }
                    }
                }
                else if (move == "D")
                {
                    number_of_moves++;
                    clear_console();
                    print_error_message("We brought new card to your deck ");
                    ask_to_continue();
                    clear_console();
                    card_list = bring_new_card_to_deck(card_list, occupied_space);
                    occupied_space++;
                    print_error_message("Computer played: ");
                    current_card_on_table = find_compatible_card(current_card_on_table);
                    print_a_card(current_card_on_table);
                   
                }
                else
                {
                    clear_console();
                    print_error_message("There was an error with in your typo! ");
                   
                   
                }
                if (occupied_space != 0)
                {
                    ask_to_continue();
                    clear_console();
                    print_your_deck(card_list, occupied_space);
                    print_a_current_card(current_card_on_table);
                }
            }
            //clear_console();
            //print_your_deck(card_list, occupied_space);
            //ask_to_continue();
            Console.WriteLine("\r\n░██╗░░░░░░░██╗██╗███╗░░██╗\r\n░██║░░██╗░░██║██║████╗░██║\r\n░╚██╗████╗██╔╝██║██╔██╗██║\r\n░░████╔═████║░██║██║╚████║\r\n░░╚██╔╝░╚██╔╝░██║██║░╚███║\r\n░░░╚═╝░░░╚═╝░░╚═╝╚═╝░░╚══╝");
            print_error_message("Good job, you completed the game in: "+number_of_moves+" moves.");
            ask_to_continue();

            clear_console();
            print_error_message("END OF PROGRAM");
            //print_error_message("Good job, you completed the game in: " + number_of_moves + " moves.");
            //print_a_current_card(current_card_on_table);

            //move_card_outside_of_deck(card_list, 4, occupied_space);
            //occupied_space--;
            //print_your_deck(card_list, occupied_space);





        }
    }
}
