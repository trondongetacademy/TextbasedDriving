namespace InterfaceAndInheritance
{
    public class Display
    {
        public Display()
        {
            // Kaller på DisplayBooks Constructoren 1:1
            var DisplayBooks = new DisplayBooks();

            DisplayBooks.AddNewBook("Bill Gates - How to avoid a climate disaster", 2021, 384);
            DisplayBooks.AddNewBook("Bjørn Andreas - Jomsviking, Danelovs Land", 2021, 492);
            DisplayBooks.AddNewBook("Clive Cussler - Dødelig nedtelling", 2020 ,383);

            DisplayBooks.ShowBookList();
        }
        
    }
}