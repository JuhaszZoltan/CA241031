using CA241031;
using System.Text;

List<Emelet> emeletek = new();
using StreamReader sr = new(@"..\..\..\src\parkolohaz.txt", Encoding.UTF8);
while (!sr.EndOfStream) emeletek.Add(new(sr.ReadLine()));

Console.WriteLine(" #no | szint neve | sz1 | sz2 | sz3 | sz4 | sz5 | sz6");
Console.WriteLine("-----------------------------------------------------");
for (int i = 0; i < emeletek.Count; i++)
    Console.WriteLine($" {i+1,2}. | {emeletek[i]}");
Console.Write("\n");

var f08 = emeletek.MinBy(e => e.Szektorok.Values.Sum()).Nev;
Console.WriteLine($"8.: Legkevesebb parkoló autó: {f08}");




