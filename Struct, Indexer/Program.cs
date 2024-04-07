using Core.Models;

string name;
string authorName;
double pageCount;
string check;
string value;

Library library = new Library();
do
{
    Console.WriteLine("1. kitab elave et");
    Console.WriteLine("2. istediyin kitabi axtar");
    Console.WriteLine("3. istediyin kitabi sil");
    Console.WriteLine("4. istediyin kitablari axtar");
    Console.WriteLine("0. proqrami bitir");


    Console.Write("Secim edin: ");
    check = Console.ReadLine();
    switch (check)
    {
        case "1":
            Console.Write("name daxil et: ");
            name = Console.ReadLine();
            Console.Write("authorName daxil et: ");
            authorName = Console.ReadLine();
            Console.Write("pageCount daxil et: ");
            pageCount = Convert.ToDouble(Console.ReadLine());

            Books book = new Books(name, authorName, pageCount);
            library.GetBook(book);
            break;

        case "2":
            Console.Write("value daxil et: ");
            value = Console.ReadLine();
            foreach (Books itemFind in library.FindAllBooksByName(value))
            {
                Console.WriteLine(itemFind);
            }
            break;
        case "3":
            Console.Write("value daxil et: ");
            value = Console.ReadLine();
            foreach (Books itemRemove in library.RemoveAllBookByName(value))
            {
                Console.WriteLine(itemRemove);
            }
            break;
        case "4":
            Console.Write("value daxil et: ");
            value = Console.ReadLine();
            foreach (Books itemSearch in library.SearchBooks(value))
            {
                Console.WriteLine(itemSearch);
            }
            break;
    }
} while (check != "0");
