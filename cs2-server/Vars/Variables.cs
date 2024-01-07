using System.Net.Http.Json;
using System.Text.Json;

namespace cs2_server.Vars;

public class Variables
{
    private string _cs2Path = null!; // Right click on CS2. Select browse local files. THIS IS YOUR PATH!    
    private string _steamGameserverApiCode = null!; // https://steamcommunity.com/dev/managegameservers - use code 730 for CS2!
    private int _port = 27015;
    private bool _vacStatus = false;
    private bool _workshopMapStatus = false;
    
    public Variables()
    {
        string jsonPath = ".\\variables.json";
        string jsonString = File.ReadAllText(jsonPath);

        VariablesObject data = JsonSerializer.Deserialize<VariablesObject>(jsonString)!;

        _cs2Path = data.CS2Path;
        _steamGameserverApiCode = data.SteamGameserverApiCode;
        _port = data.Port;
        _vacStatus = data.VacEnabled;
        _workshopMapStatus = data.UseWorkshopMap;
    }

    public string GetGameserverApiCode()
    {
        return _steamGameserverApiCode;
    }

    public string GetCS2Path()
    {
        return _cs2Path;
    }

    public int GetPort()
    {
        return _port;
    }

    public bool GetVacStatus()
    {
        return _vacStatus;
    }

    public bool GetWorkshopMapStatus()
    {
        return _workshopMapStatus;
    }
}