namespace HelloWorld;

class Program
{
    static void Main() 
    {
		string name = Console.ReadLine();
		int age = int.Parse(Console.ReadLine());
		int course = int.Parse(Console.ReadLine());
		string groupNum = Console.ReadLine();
		bool hasPet = false;
        Console.WriteLine("Анкета студента:");
		Console.WriteLine("Вас зовут " + name);
		Console.WriteLine("Вам " + age + " лет");
		Console.WriteLine("Вы на " + course + " курсе");
		Console.WriteLine("В группе " + groupNum);
		Console.WriteLine("Есть ли у вас домашний питомец: " + hasPet);
    }
}
