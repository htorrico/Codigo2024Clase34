// See https://aka.ms/new-console-template for more information
using Services;

Console.WriteLine("Hello, World!");

var service = new CourseService();
var servicios = service.Get();

foreach (var item in servicios)
{
    Console.WriteLine(item.Name);
}

Console.Read();

