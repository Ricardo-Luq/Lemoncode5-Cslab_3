# Lemoncode5-Cslab_3
Laboratory made for testing C# classes

## Tasks
#### 1. Read books
Create the function IsBookRead and have it receive a list of books and a title, return wether it has been read. A book is an object with string title and boolean isRead. 
If no such book exists, return false.
```cs
        public class Book {
            public string Title { get; set; }
            public bool IsRead { get; set; }
        }
        public static bool IsBookRead(Book[] books, string titleToSearch) {
            bool bookFound = false;
            int i = 0;
            while (!bookFound && i < books.Length) {
                if (titleToSearch == books[i].Title) {
                    return books[i].IsRead;
                }
                i++;
            }
            return false; //if no book was found, return false
        }
        static void Main(string[] args) {
            var books = new Book[] {
                new Book {
                    Title = "Harry Potter y la piedra filosofal",
                    IsRead = true
                },
                new Book {
                    Title = "Canción de hielo y fuego",
                    IsRead = false
                },
                new Book {
                    Title = "Devastación",
                    IsRead = true
                },
            };

            Console.WriteLine(IsBookRead(books, "Devastación")); // true
            Console.WriteLine(IsBookRead(books, "Canción de hielo y fuego")); // false
            Console.WriteLine(IsBookRead(books, "Los Pilares de la Tierra")); // false
        }
```
#### 2. Slot machine
Create a slot machine object with a coin counter which increases every time we __play__.
Whenever the method play is called, increase the coin count and generate 3 random booleans. If they are all true the user will have won, thus show the message:
> "Congratulations!!!. You won {coin amount} coins!!"

Then the coin count will be reset, as they have all been given to the user. If they lost however, show the following message:

>  "Good luck next time!!"

Ask the player if they will play or move on.
- If they do play, call that method.
- If they don't, finish the program
```cs
        public class SlotMachine {
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
                
                if ( roll1 && roll2 && roll3 ) {
                    int award = this.Coins;
                    this.Coins = 0;
                    return award;
                }  else {
                    return -1;
                }
            }
        }
        static void Main(string[] args) {
            SlotMachine machine = new SlotMachine();
            Console.WriteLine("Welcome! Would you like to test your luck!");
            bool playing = true;
            do {
                Console.WriteLine("[A] Insert one coin into the machine and play.");
                Console.WriteLine("[B] Leave.");
                string Answer = Console.ReadLine().ToUpper();

                if ( Answer == "A") {
                    int result = machine.play();
                    if (result > 0) {
                        Console.WriteLine($"Congratulations!!!. You won {result} coins!!\n");
                    } else {
                        Console.WriteLine($"Good luck next time!\n");
                    }
                } else {
                    playing = false;
                }
            } while (playing);
        }
```
