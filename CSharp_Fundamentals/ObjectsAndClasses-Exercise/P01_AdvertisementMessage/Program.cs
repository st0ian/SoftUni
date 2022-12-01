using System;

namespace P01_AdvertisementMessage
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Message message = new Message();

            int count = int.Parse(Console.ReadLine());

            for (int i = 0; i < count; i++)
            {
                PrintRandomizedMsg(message.Prases, message.Events, message.Authors, message.Cities);
            }
            Console.WriteLine($"{string.Join(" ", message.Cities)}");
        }

        public static void PrintRandomizedMsg(string [] prases, string[] events, string[] authors, string[] cities)
        {
            string phrase = prases[RandomPosition(prases)];
            string _event = events [RandomPosition(events)];
            string author = authors[RandomPosition(authors)];
            string city = cities[RandomPosition(cities)];

            Console.WriteLine($"{phrase} {_event} {author} – {city}.");
        }

        public static int RandomPosition (string[] input)
        {
            Random random = new Random();
            int position = random.Next(1, input.Length);

            return position;
        }
    }

    public class Message
    {
        public string[] Prases { get; set; }
        public string[] Events { get; set; }
        public string[] Authors { get; set; }
        public string[] Cities { get; set; }

        public Message()
        {
            Prases = new string[] { "Excellent product.", "Such a great product.", "I always use that product.", "Best product of its category.",
                                     "Exceptional product.", "I can’t live without this product." };
            Events = new string[] { "Now I feel good.", "I have succeeded with this product.", "Makes miracles. I am happy of the results!",
                                 "I cannot believe but now I feel awesome.", "Try it yourself, I am very satisfied.", "I feel great!" };
            Authors = new string[] { "Diana", "Petya", "Stella", "Elena", "Katya", "Iva", "Annie", "Eva" };
            Cities = new string[] { "Burgas", "Sofia", "Plovdiv", "Varna", "Ruse" };
        }          
    }
}
