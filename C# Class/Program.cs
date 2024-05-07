using System.Drawing;
using System.Threading.Channels;
//This is for Task 1
Animal animal1 = new Animal("Max", "cat", "black", 5);
animal1.DisplayAnimal();
Console.WriteLine();
//This is for Task 2
Building building1 = new Building("MyHouse", 10, 100, "Baku");
building1.DisplayBuilding();
int volume = building1.BuildingVolume();
Console.WriteLine("Volume is " + volume);
Console.WriteLine();
//This is for Task 3
int[] homeworkgrade = { 70, 80, 90, 100 };
int[] projectgrade = {60, 70, 100, 100 };
int[] quizgrade = {70, 60, 80, 70 };
bool[] continuity = {true, true, false, false, true};
Student student1 = new Student("Javid", "Qulu-zade", 17, homeworkgrade, projectgrade, quizgrade, 100, continuity);
double avg1 = student1.HomeworkGradeAverage();
double avg2 = student1.ProjectGradeAverage();
double avg3 = student1.quizAverage();
double avg4 = student1.continuityAverage();
double avg5 = student1.finalGradeAverage();
student1.DisplayStudent();
PassCheck(avg1, avg2, avg3, avg4, avg5);
Console.WriteLine();
//This is for Task 4
Gun arifle;
Gun sniperifle;
arifle = new Gun("M4A1", 40, 20, 40, "assault");
sniperifle = new Gun("AWP", 5, 4, 5, "sniper");
arifle.GunStatus();
arifle.Fire();
arifle.Reload();
arifle.Fire();
arifle.GunStatus();
sniperifle.GunStatus();
sniperifle.Fire();
sniperifle.Reload();
sniperifle.Fire();
sniperifle.GunStatus();
Console.WriteLine();
//This is for Task 5
Console.Write("Enter num 1: ");
double num1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Enter num 2: ");
double num2 = Convert.ToDouble(Console.ReadLine());
Calculator calc = new Calculator(num1, num2);
repeat:
Console.WriteLine("Choose operator: '+' '-' '*' '/'");
string op = Console.ReadLine();
//**************************************************************************************************************************
//Switch for Task 5
switch (op)
{
    case "+": calc.Add(); break;
    case "-": calc.Substract(); break;
    case "*": calc.Multiply(); break;
    case "/": calc.Divide(); break;
        default: Console.WriteLine("Enter correct operator"); goto repeat;
}
//**************************************************************************************************************************
//Function for Task 3 to check student certification
static void PassCheck(double avg1, double avg2, double avg3, double avg4, double finalGrade)
{
    double sum = (avg1 + avg2 + avg3 + avg4 + finalGrade);
    if ((sum) > 95)
    {
        Console.WriteLine($"Your result: {sum} - High Honour");
    }
    else if ((sum) > 85)
    {
        Console.WriteLine($"Your result: {sum} - Honour");
    }
    else if ((sum) > 65)
    {
        Console.WriteLine($"Your result: {sum} - Normal");
    }
    else
    {
        Console.WriteLine($"Your result:  {sum} - fail");
    }
}
//**************************************************************************************************************************

public class Animal
{
    public string name;
    public string breed;
    public string color;
    public int age;
    
    public Animal(string name, string breed, string color, int age) 
    {
        this.name = name;
        this.breed = breed;
        this.color = color;
        this.age = age;
    } 
    public void DisplayAnimal()
    {
        Console.WriteLine($"name = {name}");
        Console.WriteLine($"breed = {breed}");
        Console.WriteLine($"color = {color}");
        Console.WriteLine($"age = {age}");
    }
}
public class Building
{
    public string name;
    public int height;
    public int area;
    public string adress;

    public Building(string name, int height, int area, string adress)
    {
        this.name = name;
        this.height = height;
        this.area = area;
        this.adress = adress;
    }
    public void DisplayBuilding()
    {
        Console.WriteLine($"name = {name}");
        Console.WriteLine($"height = {height}");
        Console.WriteLine($"area = {area}");
        Console.WriteLine($"adress = {adress}");
    }
    public int BuildingVolume() 
    {
        return height*area;
    }
}
public class Student
{
    public string name;
    public string surname;
    public int age;
    public int[] homeworkGrade;
    int[] projectGrade;
    int[] quizGrade;
    int finalGrade;
    bool[] continuity;



    public Student(string name, string surname, int age, int[] homeworkGrade, int[] projectGrade, int[] quizGrade, int finalGrade, bool[] continuity)
    {
        this.name = name;
        this.surname = surname;
        this.age = age;
        this.homeworkGrade = homeworkGrade;
        this.projectGrade = projectGrade;
        this.quizGrade = quizGrade;
        this.finalGrade = finalGrade;
        this.continuity = continuity;
    }
    public double HomeworkGradeAverage()
    {
        double avg1 = 0;
        double sum1 = 0;
        foreach(double i in homeworkGrade)
        {
            sum1 += i;
        }
        avg1 = sum1/(homeworkGrade.Length);
        avg1 *= 0.2;
        return avg1;
    }
    public double ProjectGradeAverage()
    {
        double avg2 = 0;
        double sum2 = 0;
        foreach (double i in projectGrade)
        {
            sum2 += i;
        }
        avg2 = sum2 / (projectGrade.Length);
        avg2 *= 0.2;
        return avg2;
    }
    public double quizAverage()
    {
        double avg3 = 0;
        double sum3 = 0;
        foreach (double i in quizGrade)
        {
            sum3 += i;
        }
        avg3 = sum3 / quizGrade.Length;
        avg3 *= 0.2;
        return avg3;
    }
    public double continuityAverage()
    {
        double avg4 = 0;
        double ctr = 0;
        foreach (bool i in continuity)
        {
            if (i)
            {
                ctr++;
            }
        }
        avg4 = (ctr / continuity.Length) * 100;
        avg4 *= 0.1;
        return avg4;
    }
    public double finalGradeAverage()
    {
        double avg5 = finalGrade*0.3;
        return avg5;
    }
    public void DisplayStudent()
    {
        Console.WriteLine($"name - {name}");
        Console.WriteLine($"surname - {surname}");
        Console.WriteLine($"age - {age}");
        Console.Write("Homeworks: ");
        foreach(int i in homeworkGrade)
        {
            Console.Write(i+ " ");
        }
        Console.WriteLine();
        Console.Write("Projects: ");
        foreach(int i in projectGrade)
        {
            Console.Write(i+" ");
        }
        Console.WriteLine();
        Console.Write("Quiz: ");
        foreach (int i in quizGrade)
        {
            Console.Write(i + " ");
        }
        Console.WriteLine();
        foreach(bool i in continuity)
        {
            if (i)
            {
                Console.Write("Ishtirak edib ");
            }
            else
            {
                Console.Write("Ishtirak etmiyib ");
            }
        }
        Console.WriteLine();
        Console.WriteLine($"Final project - {finalGrade}");
    }
}
public class Gun
{
    public string name;
    public int MaxCapasity;
    public int CurrentBullet;
    public int TotalBullet;
    public string Type;
    
    public Gun(string name, int MaxCapasity, int CurrentBullet, int TotalBullet, string type)
    {
        this.name = name;
        this.MaxCapasity = MaxCapasity;
        this.CurrentBullet = CurrentBullet;
        this.TotalBullet = TotalBullet;

        if (type != "assault" && type != "sniper")
        {
            Console.WriteLine("Gun name ERROR");
            return;
        }
        this.Type = type;
    }
    public void Fire()
    {
        if (Type == "assault")
        {
            if (CurrentBullet > 0)
            {
                Console.WriteLine($"{name} Shooted: All bullets shooted");
                this.CurrentBullet = 0;
            }
            else
            {
                Console.WriteLine("You don't have bullets in gun");
            }
        }
        else if (Type == "sniper")
        {
            if (CurrentBullet > 0)
            {
                Console.WriteLine($"{name} Shooted: One bullet shooted");
                CurrentBullet -= 1;
            }
            else
            {
                Console.WriteLine("You don't have bullets in gun");
            }
        }
    }
    public void Reload()
    {
        if (TotalBullet == 0)
        {
            Console.WriteLine("You don't have bullets to reload");
            return;
        }

        int spaceLeft = MaxCapasity - CurrentBullet;
        if (spaceLeft > 0)
        {
            if (spaceLeft >= TotalBullet)
            {
                CurrentBullet += TotalBullet;
                this.TotalBullet = 0;
            }
            else
            {
                this.CurrentBullet = MaxCapasity;
                TotalBullet -= spaceLeft;
            }
            Console.WriteLine($"{name} Done: {spaceLeft} bullets üere added");
        }
        else
        {
            Console.WriteLine("Gun is full");
        }
    }
    public void GunStatus()
    {
        Console.WriteLine($"Gun name: {name}");
        Console.WriteLine($"the number of bullets for this moment: {CurrentBullet}");
        Console.WriteLine($"The number of all bullets you have for this moment: {TotalBullet}");
        Console.WriteLine($"Gun type: {Type}");
    }

}

public class Calculator
{
    double num1;
    double num2;
    public Calculator(double num1, double num2)
    {
        this.num1 = num1;
        this.num2 = num2;
    }
    public void Add() 
    {
        Console.WriteLine(num1 + num2);  
    }
    public void Substract() 
    { 
        Console.WriteLine(num1 - num2); 
    }
    public void Multiply()
    {
        Console.WriteLine(num1 * num2);
    }
    public void Divide()
    {
        if (num2 == 0)
        {
            Console.WriteLine("Divided by zero");
        }
        else
        {
            Console.WriteLine(num1 / num2);
        }
    }
}
