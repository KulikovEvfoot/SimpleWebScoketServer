using WebSocketSharp;
using WebSocketSharp.Server;

namespace SimpleWebSocketServer.Server;

public class EchoAll : WebSocketBehavior
{
    protected override void OnMessage(MessageEventArgs e)
    {
        Console.WriteLine("Received message from EchoAll client: " + e.Data);
        Sessions.Broadcast(e.Data);
    }
}