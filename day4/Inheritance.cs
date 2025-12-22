class Vehicle
{
    public void Start()
    {
        Console.WriteLine("Vehicle started");
    }
}

class Car : Vehicle
{
    public void Start()
    {
        Console.WriteLine("Car started");
    }

    public void Drive()
    {
        Console.WriteLine("Car is driving");
    }
}


class Person
{
    public string Name;

    public Person(string name)
    {
        Name = name;
    }
}

class Students : Person
{
    public int RollNo;

    public Students(string name, int roll) : base(name)
    {
        RollNo = roll;
    }
}