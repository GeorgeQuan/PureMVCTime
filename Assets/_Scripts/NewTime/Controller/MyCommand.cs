using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using PureMVC.Patterns;
using PureMVC.Interfaces;
/// <summary>
///  ±º‰√¸¡Ó
/// </summary>
public class MyCommand : SimpleCommand
{
    public override void Execute(INotification notification)
    {
        MyTimeProxy myTimeProxy=Facade.RetrieveProxy("MyTime") as MyTimeProxy;
        myTimeProxy.RefreshTime();
    }
}
