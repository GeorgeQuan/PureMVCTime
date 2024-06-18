using PureMVC.Patterns;
using System;
public class MyTimeProxy : Proxy
{
    public const string proxyName = "MyTime";//该代理的名字
    public MyTime Time = null;
    public MyTimeProxy():base(proxyName)//调用父类保存代理名字
    {
     
        Time = new MyTime();
    }
    /// <summary>
    /// 刷新时间方法
    /// </summary>
    public void RefreshTime()
    {
        Time.TimeStirng = DateTime.Now.ToString();
        SendNotification("MyTime", Time);
    }
}
