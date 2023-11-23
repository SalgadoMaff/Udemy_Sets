using Udemy_Sets.Entities;

Console.Write("How many students for course A? ");
int qtt = int.Parse(Console.ReadLine());

HashSet<StudentRecord> students = new HashSet<StudentRecord>();
for (int i = 0; i < qtt; i++)
{
    students.Add(new StudentRecord(int.Parse(Console.ReadLine())));
}

Console.Write("How many students for course B? ");
qtt = int.Parse(Console.ReadLine());
for (int i = 0; i < qtt; i++)
{
    students.Add(new StudentRecord(int.Parse(Console.ReadLine())));
}

Console.Write("How many students for course C? ");
qtt = int.Parse(Console.ReadLine());
for (int i = 0; i < qtt; i++)
{
    students.Add(new StudentRecord(int.Parse(Console.ReadLine())));
}

Console.WriteLine('\n'+"Total Students:"+students.Count());