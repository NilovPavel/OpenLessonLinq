using Comparers;

internal class StudentAgeComparer : IEqualityComparer<Student>
{
    bool IEqualityComparer<Student>.Equals(Student x, Student y)
    {
        return x.Age == y.Age;
    }

    int IEqualityComparer<Student>.GetHashCode(Student obj)
    {
        //return 0;
        
        return 
            //$"{obj.Id}{obj.Name}{obj.Age}"
            $"{obj.Age}"
            .GetHashCode();
    }
}