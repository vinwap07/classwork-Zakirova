namespace OopPrincipal;

public class Student : Human //, Person // нельзя наследоваться от нескольких классов, так как могут быть
                             //одинаковые по названию и принимающим значениям методы, но с разной логикой
{
    // поля

    /* уже не нужны, так как наследуются от класса Human
    private string name;
    private int age;
    */
    private TypeOfStudy typeOfStudy;
    private DateOnly startStudy;
    private DateOnly endStudy;

    public string Name { get; private set; } // это то же самое, что и методы GetName, SetName ниже
    // public string Name { get; init; } - init можно задать только в конструкторе или инициализаторе
    public int Age { get; private set; }
    public TypeOfStudy TypeOfStudy { get; }
    public DateOnly StartStudy { get; init; }
    public DateOnly EndStudy { get; }

    // prop - public int MyProperty { get; set; } - быстрое создание конструктора

    // конструкторы
    public Student(string name, int age) : base(name,age) 
    {
        Name = name;
        TypeOfStudy = TypeOfStudy.University;
        EndStudy = StartStudy.AddYears(4);
    }

    // методы

    public void ChangeSurname(string newSurname)
    {
        var fio = Name.Split(' ');
        fio[0] = newSurname;
        Name = string.Join(" ", fio);
    }
    public string AnswerTheQestion(string question) 
    {
        var answer = "";
        for (int i = 0; i < 100; i++)
        {
            answer += (char) new Random().Next(65, 91);
        }
        return answer;
    }

    /*
    public void SetName(string name)
    {
        this.name = name;
    }
        
    public string GetName() => name;
    */

    public void SetAge(int age) 
    {
        if (age < 0)
        {
            throw new ArgumentException("Ты еще не родился, кринжулька");
        }
        Age = age; // this - именно этого объекта свойство
    }

    public void UpdateAge(int age)
    {
        if (age < 0 || age > Age + 1)
        {
            throw new ArgumentException("Ага-ага, вырос он");
        }
        Age = age;
    }

    public override void Say(string message)
    {
        Console.WriteLine($"{TypeOfStudy.ToString()}");
        base.Say(message);
    }

    /* поверх наследования создаем метод, т.е. он будет по названию так же совпадать с методом класса Human, 
     * но вызываться все равно от класса Student, это "перекрытие" как сказал Кислов
    public new void Say(string message)
    {
        base.Say(message);
    }
    */

    public override void IMoveable.Move()
    {
        Console.WriteLine("Я двигаюсь на метро. Чучух - чучух!"); ;
    }

    public int GetAge() => Age;
}

public enum TypeOfStudy
{
    School,
    University,
    College
}
/* виртуальные свойства и методы
виртуальный метод - метод, помеченный ключевым словом virtual 
то есть наследник может базироваться на виртуальном методе, но при этом добавлять что-то от себя

абстрактный метод - метод, который ничего не делает, но определяет параметры и возвращаемое значение

интерфейс - описание того, что будет 
- интерфейс обязан содержать только публичные свойства и методы. 
  То есть мы никогда не помечаем доступы, но все будет публично. 
- наследник обязан реализовывать методы
- названия всегда начинается с литеры "I" (IMove, ISay)
- не должно быть никакой реализации в интерфейсе, это только описание (жоска ругаца иначе будет Кирилл)
- константы могут быть использованы только начиная с C#8, но лучше их не использовать, лучше, чтобы 
  были только свойства и методы

Разница: 
1. абсртрактный класс привязан к сущности, к иерархии, наследуются только 1 раз (1 наследник), может содержать все 
допустимые методы (конструкторы, абстрактные методы, виртуальные методы и т.д.). Может содержать приватное 
поведениею
2. интерфейс описывает поведение публичное объекта, а не сущность

А уже класс описывает сущность

Интерфейсы должны быть маленькими, лучше много маленьких, чем один большой. Поддерживает множественное наследование

UpCast - перемещение выше по иерархии (к родителю)
DownCast - перемещение ниже по иерархии (к наследнику)

У C# много своих интерфейсов, например: IComparable, IComparer - предоставляют поведение при сравнении 
двух одинаковых объектов. 
*/