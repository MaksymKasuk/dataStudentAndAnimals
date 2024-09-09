using System;

namespace Lab_1_1
{
    class Student
    {
        string name;
        int age;
        string role;
        int course;
        double rating;

        public Student(string name, int age, int course, double rating)
        {
            this.name = name;
            this.age = age;
            this.course = course;
            this.rating = rating;
        }
        public void EditStudent(string name, int age, double rating)
        {
            this.name = name;
            this.age = age;
            this.rating = rating;
        }
        public string GetRole(int course)
        {
            if (course <= 4)
                role = "бакалавр";
            else
                role = "магістр";
            return role;
        }
        public void Student_Rating()
        {
            if (rating >= 82)
                Console.WriteLine("Привіт відмінникам");
            else
                if (rating <= 59)
                Console.WriteLine("Перездача! Треба краще вчитися!");
            else
                Console.WriteLine("Можна вчитися ще краще!");
        }
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }

        public int Age
        {
            get
            {
                return age;
            }
            set
            {
                age = value;
            }
        }
        public string Role
        {
            get
            {
                return role;
            }
            set
            {
                role = value;
            }
        }
        public int Course
        {
            get
            {
                return course;
            }
            set
            {
                course = value;
            }
        }
        public double Rating
        {
            get
            {
                return rating;
            }
            set
            {
                rating = value;
            }
        }
    }
}
class Tvarina
{
    
    private string imya;
    private double vaga;
    private int vik;
    private string vyd;

   
    public string Imya
    {
        get { return imya; }
        set { imya = value; }
    }

    public double Vaga
    {
        get { return vaga; }
        set { vaga = value; }
    }

    public int Vik
    {
        get { return vik; }
        set { vik = value; }
    }

    public string Vyd
    {
        get { return vyd; }
        set { vyd = value; }
    }

    
    public Tvarina()
    {
        Imya = "Невідомо";
        Vaga = 0.0;
        Vik = 0;
        Vyd = "Невідомий";
    }

   
    public void VyvestyInformatsiyu()
    {
        Console.WriteLine("Ім'я: {Imya}, Вага: {Vaga} кг, Вік: {Vik} років, Вид: {Vyd}");
    }

   
    public void ZminytyVagu(double novaVaga)
    {
        Vaga = novaVaga;
        Console.WriteLine("Вага тварини {Imya} змінена на {Vaga} кг.");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Tvarina tvaryna = new Tvarina();

        tvaryna.Imya = "Лев";
        tvaryna.Vaga = 190.5;
        tvaryna.Vik = 8;
        tvaryna.Vyd = "Хижак";

        tvaryna.VyvestyInformatsiyu();
        tvaryna.ZminytyVagu(200.0);
    }
}