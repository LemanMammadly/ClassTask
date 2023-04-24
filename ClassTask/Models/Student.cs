public class Student
{
	public string Name;
	public string Surname;
	public string Group;
	public double Point;
	public bool isGraduated;


	public Student(string name, string surname, string group, double point, bool isgraduated)
	{
		Name = name;
		Surname = surname;
		Group = group;
		Point = point;
		isGraduated = isgraduated;
	}


	public string FullName()
	{
		return $"{Name} {Surname}";
	}


	public string Info()
	{

        if (isGraduated)
        {
            Console.WriteLine("Telebe mezun olmuşdur.");
        }
        else
        {
            Console.WriteLine("Telebe mezun olmamışdır.");
        }
        return $"Name : {Name} Surname: {Surname} Group: {Group} Point: {Point} isGraduated: {isGraduated}";

	}


	public void NextExam()
	{
		if(Point>80)
		{
		    Console.WriteLine("Telebe növbəti imtahana daxil ola biler.");
		}
		else {
			Console.WriteLine("Telebenin növbəti imtahan daxil olması üçün balı çatmır.");
		}
	}

}


