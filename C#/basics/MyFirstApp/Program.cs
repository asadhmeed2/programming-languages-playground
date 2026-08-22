using MyFirstApp.classes;

using System; 

//var checkage = new CheckAge();

//checkage.start();

//var hello = new HelloWorld();

//Console.WriteLine(hello.Hello());

int[] birdsPerDay = { 2, 5, 0, 7, 4, 1 };

var birds = new  BirdCount(birdsPerDay);

Console.WriteLine(string.Join(" ",BirdCount.LastWeek()));

Console.WriteLine(birds.Today());

