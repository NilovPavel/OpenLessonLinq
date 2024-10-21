using Comparers;

//1. Использование интерфейса IComparer для сортировки по id
List<Student> students = new List<Student>
{
    new Student { Id = 8, Name = "Ivan", Age = 21 },
    new Student { Id = 2, Name = "Vasilij", Age = 22 },
    new Student { Id = 6, Name = "George", Age = 23 },
    new Student { Id = 4, Name = "Robert", Age = 20 },
    new Student { Id = 5, Name = "Max", Age = 22 },
};

students.Sort(new StudentIdComparer());
;

//2. Использование IEqualityComparer для удаления дубликатов
students = students.Distinct(new StudentAgeComparer()).ToList();
;

/*Func<Student, Student, int> func = 
    (x,y) 
    =>
    x.Name.CompareTo(y.Name);

Comparison<Student> comparison = new Comparison<Student>(func);*/

//3. Использование Comparison. Я
students.Sort((x,y) => x.Name.CompareTo(y.Name));

//students.Sort(comparison);
;