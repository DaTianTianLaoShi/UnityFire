using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//Consot
public static class Const
{
    public static string Event_StartModel="Event_StartModel";
}
public abstract class TestEvent:MonoBehaviour
{
   //public void implement()
   //{
   //  Debug.Log("执行");
   //}
   public abstract string Name { get; } 
   public  virtual void implement()
   {
       Debug.Log("基础方法");
   }
}

public class stratTest:TestEvent
{
    public override string Name
    {
        get
        {
           //public string a="";
           return Const.Event_StartModel ;
        }
      
    }
   // public override string Name => throw new System.NotImplementedException();
    public override void implement()
    {
        Debug.Log("爬爬爬");
        Debug.Log("开始执行某些属性");
    }
}

public class Model : MonoBehaviour
{
    public static Dictionary<string, TestEvent> EventDic =  new Dictionary<string, TestEvent>(); 
    //添加事件
    public void AddEvent( TestEvent Event )
    {
        EventDic.Add(Event.Name,Event);
    }
    public void DestroyEvent(TestEvent Event )
    {
        EventDic.Remove(Event.Name);
    }
    public void SendEvent(string eventName)
    {
        if (EventDic.ContainsKey(eventName))
        {
            EventDic[eventName].implement();
        }
        else
        {   
            Debug.Log("错误没有这个事件");     
        }
    }
    void Start()
    { 
        AddEvent( new stratTest());
        SendEvent(Const.Event_StartModel);
    }
    //void Update()
    //{  
    //}
}