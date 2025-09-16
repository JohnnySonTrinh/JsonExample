// See https://aka.ms/new-console-template for more information
using System;
using Newtonsoft.Json;

// Simple Person class used for JSON deserialization
public class Person
{
	public string? FirstName { get; set; }
	public string? LastName { get; set; }
	public int Age { get; set; }
}

class Program
{
	static void Main(string[] args)
	{
		// JSON string to parse
		string json = "{ \"FirstName\": \"Alice\", \"LastName\": \"Smith\", \"Age\": 30 }";

		// Deserialize using Newtonsoft.Json
		Person? person = JsonConvert.DeserializeObject<Person>(json);

		if (person is null)
		{
			Console.WriteLine("Failed to parse JSON into Person.");
			return;
		}

		// Output parsed data
		Console.WriteLine($"FirstName: {person.FirstName}");
		Console.WriteLine($"LastName: {person.LastName}");
		Console.WriteLine($"Age: {person.Age}");
	}
}
