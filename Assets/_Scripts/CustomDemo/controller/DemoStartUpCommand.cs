#region <<文件说明>>

/*--------------------------------------
//文件名称：StartUpCommand
// 创建者：李满堂
//创建时间：2022年09月12日 星期一 10:47
//文件版本：V1.0.0
//=======================================
//功能描述：
//
//
---------------------------------------*/

#endregion


using PureMVC.Interfaces;
using PureMVC.Patterns;
using UnityEngine;

/// <summary>
/// 启动框架命令
/// </summary>
public class DemoStartUpCommand : SimpleCommand
{
    public override void Execute(INotification notification)
    {
        this.Facade.RegisterMediator(new DemoMediator(notification.Body as GameObject));
        this.Facade.RegisterProxy(new DemoProy());
    }
}