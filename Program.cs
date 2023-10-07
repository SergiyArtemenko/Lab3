using System;

class Parent
{
    protected string Pole1;  // Ім'я
    protected int Pole2;     // Рік народження

    public Parent()
    {
        Pole1 = "Невідомо";
        Pole2 = 0;
    }

    public Parent(string name, int birthYear)
    {
        Pole1 = name;
        Pole2 = birthYear;
    }

    public virtual void Print()
    {
        Console.WriteLine("Ім'я: " + Pole1);
        Console.WriteLine("Рік народження: " + Pole2);
    }

    public int Metod1(int currentYear)
    {
        return currentYear - Pole2;  // Вік людини
    }
}

class Child : Parent
{
    private int Pole3;  // Сума балів

    public Child(string name, int birthYear, int examScore) : base(name, birthYear)
    {
        Pole3 = examScore;
    }

    public override void Print()
    {
        base.Print();
        Console.WriteLine("Сума балів на іспиті: " + Pole3);
    }

    public bool Metod2(int passingScore)
    {
        return Pole3 >= passingScore;  // Перевірка на поступлення
    }
}

class Program
{
    static void Main(string[] args)
    {
        Random random = new Random();

        for (int i = 0; i < 5; i++)
        {
            string name = "Абітурієнт" + (i + 1);
            int birthYear = random.Next(1980, 2005);
            int examScore = random.Next(100, 201);
            Child applicant = new Child(name, birthYear, examScore);

            Console.WriteLine("Інформація про абітурієнта " + (i + 1) + ":");
            applicant.Print();
            Console.WriteLine("Абітурієнт " + (i + 1) + " " + (applicant.Metod2(160) ? "поступив" : "не поступив"));
            Console.WriteLine();
        }
    }
}
