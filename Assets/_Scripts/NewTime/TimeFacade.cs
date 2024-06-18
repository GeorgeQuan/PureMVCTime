using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using PureMVC.Patterns;
public class TimeFacade : Facade
{
    public TimeFacade(GameObject root) : base()
    {
        //��ʼ��MVC
        RegisterCommand("TimeRefresh", new MyCommand().GetType());//ע����Ϣ


        RegisterMediator(new TimeMadiator(root));//�����߰���Ϸ���󴫽���,�ٰѶ����Mediator


        RegisterProxy(new MyTimeProxy());



    }
}
