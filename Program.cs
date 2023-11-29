
using Orientacao.ContentContext;
using Orientacao.SubscriptionContext;
using System.Linq;

internal class Program
{
    private static void Main(string[] args)
    {
        var Articles = new List<Article>();
        Articles.Add(new Article("Artigo sobre OOP", "orientacao-objetos"));
        Articles.Add(new Article("Artigo sobre C#", "csharp"));
        Articles.Add(new Article("Artigo sobre .net", "dotnet"));


        foreach (var article in Articles)
        {
            Console.WriteLine(article.Id);
            Console.WriteLine(article.Title);
            Console.WriteLine(article.Url);
        }

        var courses = new List<Course>();
        var courseOOP = new Course("Fundamentos OOP", "Fundamentos-oop");
        var courseCsharp = new Course("Fundamentos C#", "Fundamentos-csharp");
        var courseAspNet = new Course("Fundamentos ASP.NET", "Fundamentos-aspnet");
        courses.Add(courseOOP);
        courses.Add(courseCsharp);
        courses.Add(courseAspNet);

        

        var careers = new List<Career>();
        var careerDotNet = new Career("Especialista .NET", "especialista-dotnet");
        var careerItem2 = new CareerItem(2, "Aprenda OOP", "", null);
        var careerItem = new CareerItem(1, "Comece por aqui", "", courseCsharp);
        var careerItem3 = new CareerItem(3, "Aprenda .NET", "", courseAspNet);
        careerDotNet.Items.Add(careerItem2);
        careerDotNet.Items.Add(careerItem);
        careerDotNet.Items.Add(careerItem3);
        careers.Add(careerDotNet);

        foreach(var career in careers)
        {
            Console.WriteLine(career.Title);

            foreach (var item in career.Items.OrderBy(x =>x.Order))
            {
                Console.WriteLine($"{item.Order} - {item.Title}");
                Console.WriteLine(item.Course?.Title);
                Console.WriteLine(item.Course?.Level);

                foreach (var notification in item.Notifications)
                {
                    Console.WriteLine($"{notification.Property} - {notification.Messege}");
                }
            }

            var payPalSubscription = new PayPalSubscription();
            var student = new Student();
            student.CreateSubscription(payPalSubscription);
        }


    }
}