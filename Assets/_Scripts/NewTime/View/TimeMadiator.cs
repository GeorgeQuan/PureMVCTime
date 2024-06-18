using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using PureMVC.Patterns;
using UnityEngine.UI;
using PureMVC.Interfaces;
public class TimeMadiator : Mediator
{
    public const string mediatorName = "myMediator";//中介者名字
    public Text TimeText;
    public Button TimeButton;
    public TimeMadiator(GameObject root) : base(mediatorName)//构造函数保存名字
    {
        TimeText = root.transform.Find("TimeText").GetComponent<Text>();
        TimeButton = root.transform.Find("TimeButton").GetComponent<Button>();
        TimeButton.onClick.AddListener(() => { SendNotification("TimeRefresh"); });//发送消息

    }
    /// <summary>
    ///  初始化时调用 接收到什么消息
    /// </summary>
    /// <returns></returns>
    public override IList<string> ListNotificationInterests()
    {
        string[] list = new string[1];
        list[0] = "MyTime";//监听的消息名字
        return list;
    }
    /// <summary>
    /// 接收到消息执行什么
    /// </summary>
    /// <param name="notification"></param>
    public override void HandleNotification(INotification notification)
    {
        switch (notification.Name)
        {
            case "MyTime":   //判断消息名字
                RefreshTime(notification.Body as MyTime);//调用刷新时间方法
                break;
            default:
                break;
        }
    }
    /// <summary>
    /// 根据传输过来的数据修改显示的方法
    /// </summary>
    /// <param name="time"></param>
    public void RefreshTime(MyTime time)
    {
        TimeText.text = time.TimeStirng.ToString();
    }


}
