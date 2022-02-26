using System.Collections;
using System.Collections.Generic;
using System.Net.Sockets;
using UnityEngine;
using UnityEngine.UI;

public class StartFire : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
         ButtenEvent();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void ButtenEvent()
    {
        GameObject Text= GameObject.Find("Button");
        Debug.Log(Text.name);
        Text.GetComponent<Button>().onClick.AddListener(Fire);
    }
    void Fire()
    {
        Debug.Log("发送远程事件");
        TcpClient client =new TcpClient();
        client.Connect(System.Net.IPAddress.Parse("192.168.0.154"),10015);
    }
}
