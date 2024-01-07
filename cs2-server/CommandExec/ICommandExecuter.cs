namespace cs2_server.CommandExec;

public interface ICommandExecuter
{
    void StartServer(Int64 mapId, string extraArguments);
}