
using OopPrincipal;

var student = new Student("Kislov Kirill", 18);
var student2 = new Student("Kislov Kirill", 2);
var student3 = new Student("LOLOLO", 99)
{
    /* уже нельзя инициализировать воззраст и конец обучения, так как доступы к свойствам - приватные
    age = 18,
    endStudy = DateOnly.Parse("2025-05-31"),
    */
    StartStudy = DateOnly.FromDateTime(DateTime.Now),
};

/* уже нельзя инициализировать возрасть и конец обучения, так как доступы к свойствам - приватные
student3.age = -18;
student3.endStudy = DateOnly.Parse("2125-05-31");
*/



//student.SetName("Ksilophone Kirill");
//student.ChangeSurname("Ksilophone");
//Console.WriteLine(student.GetName());
Console.WriteLine(student3.EndStudy);
Console.WriteLine(student.Say("а у нас будет что-то типо обэда?"));
