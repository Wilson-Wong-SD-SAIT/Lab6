using System;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text.Json;

namespace Lab6
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Event a = new Event(1, "Calgary ");

			File.WriteAllText("event.json", JsonSerializer.Serialize(a));
			Event decode_a = JsonSerializer.Deserialize<Event>(File.ReadAllText("event.json"));
			Console.WriteLine(decode_a.EventNumber);
			Console.WriteLine(decode_a.Location);

			ReadFromFile("Hackathon");
		}


		internal static void ReadFromFile(string str) 
		{
			Console.WriteLine("Tech Competition");

			using (StreamWriter streamWriter = File.CreateText("event.txt")) 
			{
				streamWriter.WriteLine(str);
				Console.WriteLine("In Word: " + str);
			}

			using (StreamReader streamReader = File.OpenText("event.txt"))
			{	
				streamReader.BaseStream.Seek(0, SeekOrigin.Begin);
				Console.WriteLine("The First character is: " + (char)streamReader.Read());
			}

			using (StreamReader streamReader = File.OpenText("event.txt"))
			{
				streamReader.BaseStream.Seek((int)(streamReader.BaseStream.Length / 2)-1, SeekOrigin.Begin);
				Console.WriteLine("The Middle character is: " + (char)streamReader.Read());
			}

			using (StreamReader streamReader = File.OpenText("event.txt"))
			{
				streamReader.BaseStream.Seek(-3, SeekOrigin.End);
				Console.WriteLine("The Last character is: " + (char)streamReader.Read());
			}

		}
	}
}