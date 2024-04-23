using System;

namespace cs3_app2_SlotMachine
{
    internal class Program
    {
        public class SlotMachine
        {
            public string Title { get; set; }
            public int Coins { get; set; }

            public int play() {
                this.Coins++;
                Random rnd = new Random();

                bool roll1 = rnd.Next(2) == 0;
                bool roll2 = rnd.Next(2) == 0;
                bool roll3 = rnd.Next(2) == 0;

                Console.WriteLine($"Rolling...\n" +
                    $"{(roll1 ? "GOOD" : "FAIL")}\n" +
                    $"{(roll2 ? "GOOD" : "FAIL")}\n" +
                    $"{(roll3 ? "GOOD" : "FAIL")}\n");
                
                if ( roll1 && roll2 && roll3 )
                {
                    int award = this.Coins;
                    this.Coins = 0;
                    return award;
                }  else
                {
                    return -1;
                }
            }
        }
        static void Main(string[] args)
        {
            SlotMachine machine = new SlotMachine();
            Console.WriteLine("Welcome! Would you like to test your luck!");
            bool playing = true;
            do
            {
                Console.WriteLine("[A] Insert one coin into the machine and play.");
                Console.WriteLine("[B] Leave.");
                string Answer = Console.ReadLine().ToUpper();
                if ( Answer == "A")
                {
                    int result = machine.play();
                    if (result > 0)
                    {
                        Console.WriteLine($"Congratulations!!!. You won {result} coins!!\n");
                    }
                    else
                    {
                        Console.WriteLine($"Good luck next time!\n");
                    }
                } else
                {
                    playing = false;
                }
            } while (playing);
        }
    }
}
