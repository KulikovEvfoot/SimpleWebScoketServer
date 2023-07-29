using WebSocketSharp.Server;

namespace SimpleWebSocketServer.Server;

public class SimpleServer
{
    public SimpleServer()
    {
        m_WebSocketServer = new WebSocketServer("ws://127.0.0.1:7890");
    }

    public void Start()
    {
        m_WebSocketServer.AddWebSocketService<Echo>("/Echo");
        m_WebSocketServer.AddWebSocketService<EchoAll>("/EchoAll");
        m_WebSocketServer.Start();
        Console.WriteLine("WS server started on ws://127.0.0.1:7890/Echo");
        Console.WriteLine("WS server started on ws://127.0.0.1:7890/EchoAll");
        Console.WriteLine("Press any button to stop");
        Console.ReadKey();
        Stop();
    }
    
    public void Stop()
    {
        m_WebSocketServer.Stop();
    }

    private WebSocketServer m_WebSocketServer;
}