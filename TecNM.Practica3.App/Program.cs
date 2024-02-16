using System;
using TecNM.Practica3.Core.Entities;
using TecNM.Practica3.Core.Managers;
using TecNM.Practica3.Core.Services;

namespace TecNM.Practica3.App;

public static class Program{

    public static void Main(String[] args ){
        float salary = 0;
        
        System.Console.WriteLine("Please enter the your salary");
        Single.TryParse(System.Console.ReadLine(), out salary);
        
        var person = new Person{salary = salary};

        var service = new IsrService();
        var managers = new IsrManager(service);

        Isr isr = managers.GetIsr(person);

        System.Console.WriteLine($"You have to pay a total of ${isr.isrResult} MXN of ISR");
    }
}