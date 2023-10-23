Student<int> student1 = new Student<int>("Иванов");
student1.TakeExam(4); 

Student<string> student2 = new Student<string>("Петров");
student2.TakeExam("зачет"); 

Console.WriteLine($"Имя: {student1.Name}");
Console.WriteLine($"Оценка за экзамен: {student1.NumGrade}");

Console.WriteLine($"Имя: {student2.Name}");
Console.WriteLine($"Результат за зачет: {student2.PassFailGrade}");

class Student<T>
{
    public T PassFailGrade { get; set; }
    public T NumGrade { get; set; }
    public string Name { get; set; }
    
    public Student(string name)
    {
        Name = name;
    }

    public void TakeExam(T grade)
    {
        if(typeof(T) == typeof(int))
        {
            NumGrade = grade;
        }
        else if (typeof(T) == typeof(string) && (string)(object)grade == "зачет" || (string)(object)grade == "незачет")
        {
            PassFailGrade = grade;
        }
        else
        {
            Console.WriteLine("Invalid grade type");
        }
    }
    
}