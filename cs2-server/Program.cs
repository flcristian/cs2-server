using cs2_server;
using cs2_server.CommandExec;
using cs2_server.MapSelector;
using cs2_server.Vars;

internal class Program
{
    public static void Main(string[] args)
    {
        Variables variables = new Variables();
        
        if (variables.GetCS2Path().Equals("YOUR_CS2_PATH"))
        {
            Console.WriteLine("YOU MUST REPLACE THE CS2 PATH IN ORDER FOR IT TO WORK!");
            Console.WriteLine("CLOSE OR PRESS ENTER TO EXIT");
            Console.ReadLine();
            return;
        }

        if (variables.GetGameserverApiCode().Equals("YOUR_STEAM_GAMESERVER_API_CODE"))
        {
            Console.WriteLine("REPLACE STEAM API CODE FROM THE .TXT FILE WITH YOUR OWN!");
            Console.WriteLine("OTHERWISE YOUR SERVER WILL ONLY RUN LOCALLY");
            Console.WriteLine("PRESS ENTER TO CONTINUE ANYWAY");
            Console.WriteLine("CLOSE IF YOU WANT TO CANCEL");
            Console.ReadLine();
        }

        if (variables.GetWorkshopMapStatus())
        {
            IMapSelector selector = new MapSelector();
            selector.SelectMap();
        }
        else
        {
            ICommandExecuter executer = new CommandExecuter();
            executer.StartServer(0, null!);
        }
    }
}