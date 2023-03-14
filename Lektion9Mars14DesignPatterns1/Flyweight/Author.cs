namespace Lektion9Mars14DesignPatterns1.Flyweight
{
    public class Author
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public int NumberOfPrisesWon { get; set; }
        public Author(string name, int age, int numberOfPrisesWon)
        {
            Name = name;
            Age = age;
            NumberOfPrisesWon = numberOfPrisesWon;
        }
    }
}