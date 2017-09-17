using System.Collections;
using System.Collections.Generic;
using System.Net.Sockets;
using UnityEngine;

public class TCPClient : MonoBehaviour {
    System.Net.Sockets.TcpClient clientSocket = new System.Net.Sockets.TcpClient();
    public string hostname;
    NetworkStream stream;
    public int port;
    // Use this for initialization
    void Start () {
        clientSocket.Connect(hostname, port);
    }

    // Update is called once per frame
    void Update () {
        //reads bytes
        stream = clientSocket.GetStream();
        byte[] bytes = new byte[10000];
        Debug.Log(clientSocket.ReceiveBufferSize);
        stream.Read(bytes, 0, (int)clientSocket.ReceiveBufferSize);
        // Parse bytes into vector

	}
}
