using WebSocketSharp;
using WebSocketSharp.Server;

namespace SimpleWebSocketServer.Server;

public class Echo : WebSocketBehavior
{
    protected override void OnMessage(MessageEventArgs e)
    {
        Console.WriteLine("Received message from Echo client: " + e.Data);
        Send(e.Data);
    }
}