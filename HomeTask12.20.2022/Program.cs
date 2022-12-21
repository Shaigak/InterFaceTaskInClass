// See https://aka.ms/new-console-template for more information
using HomeTask12._20._2022;
using HomeTask12._20._2022.Models;
using HomeTask12._20._2022.Services;
using HomeTask12._20._2022.Services.Interfaces;

Console.WriteLine("Hello, World!");

//int a = 40;
//a = 60;

//Bird bird = new Bird();
//bird.Sound();
//bird.Eating();

//Shark shark = new Shark();
//shark.Sound();
//shark.Eating();

////Animal animal = new Animal();
////animal.Sound();

//Car car = new Car();

//Getnums(1,2,3,4,5,6,7);


//static void Getnums(params int[]arr)
//{
//    foreach (var item in arr)
//    {
//        Console.WriteLine(item);
//    }
//}

//CalculateService service = new CalculateService();


//service.SumNumbers(10,15);

IPerson person = new Person();
person.GetName();

ICalculateService service = new CalculateService();
var result =service.GetSumNumbersFromArray(new int[] { 1, 2, 4, 6 });
Console.WriteLine(result);