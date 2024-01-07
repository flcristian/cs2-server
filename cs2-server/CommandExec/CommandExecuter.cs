using System.Diagnostics;
using System.Text.Json;
using cs2_server.Vars;

namespace cs2_server.CommandExec;

public class CommandExecuter : ICommandExecuter
{
    private Variables _variables;
    private string _arguments;

    public CommandExecuter()
    {
        _variables = new Variables();
        
        string jsonPath = ".\\arguments.json";
        string jsonString = File.ReadAllText(jsonPath);

        ArgumentsObject data = JsonSerializer.Deserialize<ArgumentsObject>(jsonString)!;

        _arguments = data.Arguments;
    }
    
    public void StartServer(Int64 mapId, string extraArguments)
    {
        string commandString =
            $".\\cs2.exe -dedicated{(_variables.GetVacStatus() ? " -insecure" : "")} -port {_variables.GetPort()} +map de_dust2 +sv_setsteamaccount {_variables.GetGameserverApiCode()}";
        if (_variables.GetWorkshopMapStatus()) commandString += $" +host_workshop_map {mapId} {extraArguments}";
        commandString += $" {_arguments}";
        
        Console.WriteLine(commandString);
        
        string workingDirectory = _variables.GetCS2Path();
        
        ProcessStartInfo psi = new ProcessStartInfo
        {
            FileName = "cmd.exe",
            Arguments = "/C " + commandString,
            RedirectStandardOutput = true,
            RedirectStandardError = true,
            UseShellExecute = false,
            CreateNoWindow = true,
            WorkingDirectory = workingDirectory + "\\game\\bin\\win64\\"
        };

        Process process = new Process { StartInfo = psi };
        
        process.Start();
        process.WaitForExit();
    }
}