namespace Lektion9Mars14DesignPatterns1.Prototype
{
    public class Human : IPrototype
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public Human(string name, int age)
        {
            Name = name;
            Age = age;
        }
        public Human(Human human)
        {
            Name = human.Name;
            Age = human.Age;
        }
        public IPrototype Clone()
        {
            return new Human(this);
        }
    }
}