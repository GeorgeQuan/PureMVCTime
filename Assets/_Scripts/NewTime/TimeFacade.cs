using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using PureMVC.Patterns;
public class TimeFacade : Facade
{
    public TimeFacade(GameObject root) : base()
    {
        //初始化MVC
        RegisterCommand("TimeRefresh", new MyCommand().GetType());//注册消息


        RegisterMediator(new TimeMadiator(root));//入口外边把游戏对象传进来,再把对象给Mediator


        RegisterProxy(new MyTimeProxy());



    }
}
