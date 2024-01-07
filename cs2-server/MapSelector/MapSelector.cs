using System.Text.Json;
using cs2_server.CommandExec;
using cs2_server.Vars;

namespace cs2_server.MapSelector;

public class MapSelector : IMapSelector
{
    private int count = 0;
    private Dictionary<int, string> _names = new Dictionary<int, string>();
    private Dictionary<int, Int64> _mapIds = new Dictionary<int, Int64>();
    private Dictionary<int, string> _extraArguments = new Dictionary<int, string>();

    public MapSelector()
    {
        string jsonPath = ".\\instances.json";
        string jsonString = File.ReadAllText(jsonPath);

        WorkshopMapsArrayObject[] data = JsonSerializer.Deserialize<WorkshopMapsArrayObject[]>(jsonString)!;
        count = data.Length;
        
        int id = 1;
        foreach (WorkshopMapsArrayObject map in data)
        {
            _names.Add(id, map.Name);
            _mapIds.Add(id, map.MapID);
            _extraArguments.Add(id, map.Arguments);
            id++;
        }
    }
    
    public void SelectMap()
    {
        string message = "Select the map :\n";
        for (int i = 1; i <= count; i++)
        {
            message += $"{i}. {_names.GetValueOrDefault(i)} (ID : {_mapIds.GetValueOrDefault(i)})\n";
        }
        Console.WriteLine(message);
        int input = Int32.Parse(Console.ReadLine()!);

        Int64 mapId;
        string extraArguments;
        
        try
        {
            mapId = _mapIds.GetValueOrDefault(input);
            extraArguments = _extraArguments.GetValueOrDefault(input)!;
        }
        catch (Exception) { return; }

        ICommandExecuter commandExecuter = new CommandExecuter();
        commandExecuter.StartServer(mapId, extraArguments);
    }
}