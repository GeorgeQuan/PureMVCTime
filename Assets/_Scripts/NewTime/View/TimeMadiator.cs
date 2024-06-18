using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using PureMVC.Patterns;
using UnityEngine.UI;
using PureMVC.Interfaces;
public class TimeMadiator : Mediator
{
    public const string mediatorName = "myMediator";//�н�������
    public Text TimeText;
    public Button TimeButton;
    public TimeMadiator(GameObject root) : base(mediatorName)//���캯����������
    {
        TimeText = root.transform.Find("TimeText").GetComponent<Text>();
        TimeButton = root.transform.Find("TimeButton").GetComponent<Button>();
        TimeButton.onClick.AddListener(() => { SendNotification("TimeRefresh"); });//������Ϣ

    }
    /// <summary>
    ///  ��ʼ��ʱ���� ���յ�ʲô��Ϣ
    /// </summary>
    /// <returns></returns>
    public override IList<string> ListNotificationInterests()
    {
        string[] list = new string[1];
        list[0] = "MyTime";//��������Ϣ����
        return list;
    }
    /// <summary>
    /// ���յ���Ϣִ��ʲô
    /// </summary>
    /// <param name="notification"></param>
    public override void HandleNotification(INotification notification)
    {
        switch (notification.Name)
        {
            case "MyTime":   //�ж���Ϣ����
                RefreshTime(notification.Body as MyTime);//����ˢ��ʱ�䷽��
                break;
            default:
                break;
        }
    }
    /// <summary>
    /// ���ݴ�������������޸���ʾ�ķ���
    /// </summary>
    /// <param name="time"></param>
    public void RefreshTime(MyTime time)
    {
        TimeText.text = time.TimeStirng.ToString();
    }


}
