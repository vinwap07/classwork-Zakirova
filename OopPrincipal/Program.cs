
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
student.Say("а у нас будет что-то типо обэда?");

/* var currCunverter = new CurrencyConverter
{
    Currency = 15
}; // нельзя в статическом методе использовать не статические поля, но при этом в нестатическом классе
   // ведь можно создать объект, значит мы можем создать объект, задать значение его полю и передать его в метод

Console.WriteLine(CurrencyConverter.PluralizeRubles(currCunverter.Currency)); 
*/

Console.WriteLine(CurrencyConverter.PluralizeRubles(15));
Console.WriteLine(15.PluralizeRubles());

var currency = 15;
Console.WriteLine(currency.PluralizeRubles());

Console.WriteLine(student.PresentationStudent());