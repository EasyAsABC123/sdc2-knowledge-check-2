using System;
using System.Text.Json;

namespace MyApp // Note: actual namespace depends on the project name.
{
  public class State
  {
    public List<Activity> Activities { get; set; }
    public string Name { get; set; }

    public State()
    {
      Activities = new List<Activity>();
    }
  }

  public class Activity
  {
    public string Name { get; set; }
  }

  public class Root
  {
    public string Name { get; set; }
    public List<string> Problem { get; set; }
  }

  internal class Program
  {
    static void Main(string[] args)
    {
      var states = new List<State>();
      var kentucky = new State() { Name = "Kentucky" };
      kentucky.Activities.Add(new Activity() { Name = "Hiking" });
      kentucky.Activities.Add(new Activity() { Name = "Run" });
      kentucky.Activities.Add(new Activity() { Name = "Sight See" });
      states.Add(kentucky);
      string jsonString = JsonSerializer.Serialize(states);

      Console.WriteLine(jsonString);
      File.WriteAllText("states_code.json", jsonString);

      var practiceJsonString = File.ReadAllText("practice.json");
      var practices = JsonSerializer.Deserialize<List<Root>>(practiceJsonString);
      Console.WriteLine(practices.Count);
    }
  }
}