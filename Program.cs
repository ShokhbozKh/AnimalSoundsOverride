namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Rasmda berilgan struktura asosida klasslarni yarating.
            //sound() methodini overriding usulida amalga oshiring.
            //Barcha hayvonlarning o'ziga xos parametrlarini klass fieldi sifatida bering.
            Animal animal = new Animal();
            animal.Sound();
            Animal animal1 = new Dog();
            animal1.Sound();
            Animal animal2 = new Cat();
            animal2.Sound();
            Animal animal3 = new Duck();
            animal3.Sound();

        }
    }
    class Animal
    {
        public virtual void Sound()
        {
            Console.WriteLine("-Umumiy ovozlar-");
        }
    }
    class Dog:Animal
    {
        public override void Sound()
        {
            Console.WriteLine("Dog is sound Bow - Bow");
        }
    }
    class Cat : Animal
    {
        public override void Sound()
        {
            Console.WriteLine("Cat is sound Meow-Meow");
        }
    }
    class Duck : Animal
    {
        public override void Sound()
        {
            Console.WriteLine("Duck is sound Quack-Quack");
        }
    }
}