// See https://aka.ms/new-console-template for more information
using MoodAnalyzer;
Console.WriteLine("Mood Analyzer");

HappyorSad happySad = new HappyorSad("I am in Sad a Mood");
Console.WriteLine(happySad.AnalysingMood());

Console.WriteLine("------");

Console.WriteLine();
InvalidMood invalidMood = new InvalidMood(" ");
Console.WriteLine(invalidMood.AnalysingMood());

