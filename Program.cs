//Please create required classes to represent inventory storage.
//There should be 5 different items we could store in the inventory. Use inheritance.


using System.Drawing;

namespace SGT2_HomeWork_004_Inventory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var paper = new Paper
            {
                AmountLeft = 13,
                Id = 1,
                Title = "Paper 1"
            };

            var colorsForPrinters = new ColorsForPrinter
            {
                AmountLeft = 100,
                Id = 2,
                Title = "Color 1"

            };

            var notebooks = new Notebook
            {
                AmountLeft = 34,
                Id = 3,
                Title = "Nt book 1"
            };

            var repo = new InventoryRepository();

            repo.Add(paper);
            repo.Add(notebooks);
            repo.Add(colorsForPrinters);

            foreach (var item in repo.InventoryItems) {
                Console.WriteLine($"Id: {item.Id} - Title: {item.Title} - Availability: {repo.CheckAvailability(item.Id, 30)}");
            }

        }
    }
}