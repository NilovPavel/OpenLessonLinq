//1. Использование IComparer
using Comparers;

internal class StudentIdComparer : IComparer<Student>
{
    int IComparer<Student>.Compare(Student? x, Student? y)
    {
        return x.Id - y.Id;
    }
}