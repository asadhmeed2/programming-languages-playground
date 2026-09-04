using MyFirstApp.classes;

using System;

//var checkage = new CheckAge();

//checkage.start();

//var hello = new HelloWorld();

//Console.WriteLine(hello.Hello());

//int[] birdsPerDay = { 2, 5, 0, 7, 4, 1 };

//var birds = new  BirdCount(birdsPerDay);

//Console.WriteLine(string.Join(" ",BirdCount.LastWeek()));


//Console.WriteLine(birds.Today());

//birds.IncrementTodaysCount();

//Console.WriteLine(birds.Today());

//Console.WriteLine(birds.HasDayWithoutBirds());

//Console.WriteLine(birds.CountForFirstDays(4));

//Console.WriteLine("the busy days are:");

//Console.WriteLine(birds.BusyDays());


//var lasagna = new Lasagna();
//Console.WriteLine(lasagna.RemainingMinutesInOven(20)); 
//Console.WriteLine(lasagna.ExpectedMinutesInOven());
//Console.WriteLine(lasagna.PreparationTimeInMinutes(4)); 

//Console.WriteLine(lasagna.ElapsedTimeInMinutes(4,20));

//bool knightIsAwake = true;

//Console.WriteLine(QuestLogic.CanFastAttack(knightIsAwake));

//Console.WriteLine(QuestLogic.CanFastAttack(knightIsAwake));




string s = Identifier.Clean("my   Id");

Console.WriteLine(s);

string s2 = Identifier.Clean("my\0Id");
Console.WriteLine(s2);

