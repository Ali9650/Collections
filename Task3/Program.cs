
namespace Task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student();
            student.AddGrade("Ali",new List<int> { 1,2,3,4});
            student.GetAverageGrade("Ali");
            student.GetAllGradesByStudent("Ali");
        }
    }
}
