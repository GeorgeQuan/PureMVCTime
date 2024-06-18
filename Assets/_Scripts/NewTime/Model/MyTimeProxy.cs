using PureMVC.Patterns;
using System;
public class MyTimeProxy : Proxy
{
    public const string proxyName = "MyTime";//�ô��������
    public MyTime Time = null;
    public MyTimeProxy():base(proxyName)//���ø��ౣ���������
    {
     
        Time = new MyTime();
    }
    /// <summary>
    /// ˢ��ʱ�䷽��
    /// </summary>
    public void RefreshTime()
    {
        Time.TimeStirng = DateTime.Now.ToString();
        SendNotification("MyTime", Time);
    }
}
