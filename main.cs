//Первая задача: Напишите запрос Linq, который фильтрует список студентов и возвращает тех, чей средний балл выше 75.
public class Student
{
    public string Name { get; set; }
    public int Age { get; set; }
    public double AverageScore { get; set; }

    public Student(string name, int age, double averageScore)
    {
        Name = name;
        Age = age;
        AverageScore = averageScore;
    }
}

//class Program
//{
//    static void Main(string[] args)
//    {
//        // Создание списка студентов
//        List<Student> students = new List<Student>
//        {
//            new Student("Иван", 20, 78.5),
//            new Student("Мария", 22, 85.0),
//            new Student("Петр", 21, 65.0),
//            new Student("Анна", 19, 90.0),
//            new Student("Олег", 23, 74.0)
//        };

//        var filtered = students.Where(x => x.AverageScore > 75).Select(x => x.Name);

//        foreach (string student in filtered)
//        {
//            Console.WriteLine(student);
//        }
//    }
//}

//Вторая задача: Создайте коллекцию объектов, представляющих книги в библиотеке, с такими свойствами, как название, автор и год издания.
//Используя Linq, напишите запрос, который возвращает список уникальных авторов, которые написали более одной книги.

public class Book
{
    public string Title { get; set; }
    public string Author { get; set; }
    public int Year { get; set; }
    public string Genre { get; set; }

    public Book(string title, string author, int year, string genre)
    {
        Title = title;
        Author = author;
        Year = year;
        Genre = genre;
    }
}

//class Program
//{
//    static void Main(string[] args)
//    {
//        // Создание списка книг
//        List<Book> books = new List<Book>
//        {
//            new Book("Война и мир", "Лев Толстой", 1869, "Роман"),
//            new Book("1984", "Джордж Оруэлл", 1949, "Фантастика"),
//            new Book("Мастер и Маргарита", "Михаил Булгаков", 1967, "Роман"),
//            new Book("Анна Каренина", "Лев Толстой", 1877, "Роман"),
//            new Book("Гарри Поттер и философский камень", "Дж.К. Роулинг", 1997, "Фэнтези")
//        };

//        var repeatedAuthors = books.GroupBy(x => x.Author)
//            .Where(group => group.Count() > 1)
//            .Select(group => group.Key);

//        //// Вывод информации о книгах
//        foreach (var author in repeatedAuthors)
//        {
//            Console.WriteLine(author);
//        }
//    }
//}

//Третья задача: У вас есть список заказов, каждый из которых содержит информацию о товаре, клиенте и стоимости.
//Напишите запрос, который сгруппирует заказы по клиентам и вернет общую сумму всех заказов для каждого клиента.

public class Order
{
    public int ClientId { get; set; }
    public string Product { get; set; }
    public decimal TotalAmount { get; set; }
}

//class Program
//{
//    static void Main()
//    {
//        List<Order> orders = new List<Order>
//        {
//            new Order { ClientId = 1, Product = "Product A", TotalAmount = 100 },
//            new Order { ClientId = 1, Product = "Product B", TotalAmount = 200 },
//            new Order { ClientId = 2, Product = "Product C", TotalAmount = 150 },
//            new Order { ClientId = 2, Product = "Product D", TotalAmount = 50 },
//            new Order { ClientId = 3, Product = "Product E", TotalAmount = 300 }
//        };

//        var result = orders.GroupBy(x => x.ClientId)
//            .Select(g => new
//            {
//                ClientId = g.Key,
//                TotalAmount = g.Sum(x => x.TotalAmount)
//            });

//        foreach (var client in result)
//        {
//            Console.WriteLine($"Client ID: {client.ClientId}, Total Spent: {client.TotalAmount}");
//        }
//    }
//}

//Четвертая задача: Создайте массив чисел и напишите Linq-запрос, который находит максимальное,
//минимальное и среднее значения из этого массива. Используйте методы Linq, такие как Max(), Min(), и Average(), чтобы вычислить результаты.


//class Program
//{
//    static void Main()
//    {
//        int[] numbers = { 3, 5, 7, 2, 8, 10, 4, 6, 1, 9 };
//        int max = numbers.Max();
//        int min = numbers.Min();
//        double avr = numbers.Average();
//    }
//}

//Пятая задача: Разработайте класс Employee, представляющий сотрудников с такими свойствами, как имя, должность и зарплата.
//Напишите запрос Linq, который возвращает список сотрудников, отсортированных по зарплате в порядке убывания и группированных по должностям.
//Также добавьте условие, чтобы в итоговом списке отображались только те должности, которые имеют более трех сотрудников.

class Employee
{
    public string Name { get; set; }
    public string JobTitle { get; set; }
    public double Salary { get; set; }

    public Employee(string name, string jobTitle, double salary)
    {
        Name = name;
        JobTitle = jobTitle;
        Salary = salary;
    }
}

//class Program
//{
//    static void Main()
//    {
//        // Создаем список сотрудников
//        List<Employee> employees = new List<Employee>
//        {
//            new Employee("Иван", "Менеджер", 50000),
//            new Employee("Анна", "Разработчик", 60000),
//            new Employee("Петр", "Разработчик", 55000),
//            new Employee("Елена", "Менеджер", 52000),
//            new Employee("Сергей", "Аналитик", 70000),
//            new Employee("Ольга", "Разработчик", 62000),
//            new Employee("Алексей", "Аналитик", 65000),
//            new Employee("Татьяна", "Менеджер", 48000),
//            new Employee("Кирилл", "Аналитик", 72000),
//            new Employee("Мария", "Аналитик", 68000)
//        };

//        var groupedEmployees = employees
//            .GroupBy(e => e.JobTitle) // Группируем по должности
//            .Where(g => g.Count() > 3) // Условие: только должности с более чем тремя сотрудниками
//            .Select(g => new
//            {
//                JobTitle = g.Key,
//                Employees = g.OrderByDescending(e => e.Salary) // Сортируем по зарплате в порядке убывания
//            });

//        // Выводим результат
//        foreach (var group in groupedEmployees)
//        {
//            Console.WriteLine($"Должность: {group.JobTitle}");
//            foreach (var employee in group.Employees)
//            {
//                Console.WriteLine($"  Имя: {employee.Name}, Зарплата: {employee.Salary}");
//            }
//        }
//    }
//}


//У нас есть список всех преступников. В преступнике есть поля: ФИО, заключен ли он под стражу, рост, вес, национальность.
// Вашей программой будут пользоваться детективы.
//У детектива запрашиваются данные (рост, вес, национальность), и детективу выводятся все преступники, которые подходят под эти параметры,
//но уже заключенные под стражу выводиться не должны.
//class Program
//{
//    public class Criminal
//    {
//        public string FullName { get; set; }
//        public bool IsInCustody { get; set; }
//        public int Height { get; set; }
//        public int Weight { get; set; }
//        public string Nationality { get; set; }
//    }

//    static void Main(string[] args)
//    {
//        var heightParam = 170;
//        var weightParam = 90;
//        var nationlityParam = "Белорус";


//        // Создаем список преступников
//        List<Criminal> criminals = new List<Criminal>
//        {
//            new Criminal { FullName = "Иванов Иван Иванович", IsInCustody = false, Height = 180, Weight = 75, Nationality = "Русский" },
//            new Criminal { FullName = "Петров Петр Петрович", IsInCustody = true, Height = 165, Weight = 70, Nationality = "Русский" },
//            new Criminal { FullName = "Сидоров Сидор Сидорович", IsInCustody = false, Height = 175, Weight = 80, Nationality = "Украинец" },
//            new Criminal { FullName = "Михайлов Михаил Михайлович", IsInCustody = false, Height = 170, Weight = 90, Nationality = "Белорус" },
//            new Criminal { FullName = "Кузнецов Алексей Павлович", IsInCustody = false, Height = 185, Weight = 85, Nationality = "Русский" },
//            new Criminal { FullName = "Лебедев Антон Александрович", IsInCustody = true, Height = 170, Weight = 68, Nationality = "Русский" }
//        };

//        var result = criminals.Where(c => c.Height == heightParam && c.Weight == weightParam && nationlityParam == c.Nationality
//        && !c.IsInCustody);

//        foreach (Criminal criminal in result)
//        {
//            Console.WriteLine(criminal.FullName);
//        }
//    }
//}

//Есть 2 списка в солдатами. Всех бойцов из отряда 1, у которых фамилия начинается на букву Б, требуется перевести в отряд 2. Весь перевод реализуется с помощью Linq
class Program
{
    public class Soldier
    {
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Weapon { get; set; }
        public string Rank { get; set; }
        public int ServiceTimeInMonths { get; set; }

        public Soldier(string name, string lastName, string weapon, string rank, int serviceTimeInMonths)
        {
            Name = name;
            LastName = lastName;
            Weapon = weapon;
            Rank = rank;
            ServiceTimeInMonths = serviceTimeInMonths;
        }
    }

    static void Main(string[] args)
    {
        // Список солдат в отряде 1
        List<Soldier> squad1 = new List<Soldier>
        {
            new Soldier("Иван", "Беляев", "Автомат", "Солдат", 12),
            new Soldier("Петр", "Сидоров", "Пистолет", "Сержант", 24),
            new Soldier("Сергей", "Бобров", "Снайперская винтовка", "Лейтенант", 36),
            new Soldier("Алексей", "Кузнецов", "Гранатомет", "Капитан", 48),
            new Soldier("Дмитрий", "Буров", "Ручной пулемет", "Майор", 60)
        };

        // Перевод бойцов из отряда 1 в отряд 2, если фамилия начинается на букву "Б"
        List<Soldier> squad2 = squad1.Where(s => s.LastName.StartsWith("Б")).ToList();

        // Вывод информации о солдатах в отряде 2
        Console.WriteLine("Солдат в отряде 2 после перевода:");
        foreach (var soldier in squad2)
        {
            Console.WriteLine($"{soldier.Rank} {soldier.LastName} {soldier.Name}, Оружие: {soldier.Weapon}, Служба: {soldier.ServiceTimeInMonths} месяцев");
        }
    }
}
