namespace Task_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student();
            student.AddGrade("Ali", new List<int> { 1, 2, 3, 4 });
            student.AddGrade("Namiq", new List<int>() { 1, 2,});
            student.GetAverageGrade("Ali");

            var grades = student.GetAllGradesByStudent("Ali");

            foreach (var item in grades)
            {
                Console.WriteLine(item);
            }
        }
    }
}
