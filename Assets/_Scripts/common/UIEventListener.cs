using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using UnityEngine.UI;
public class UIEventListener : EventTrigger
{
    public delegate void VoidDelegate(GameObject go);
    public event VoidDelegate onClick;
    public event VoidDelegate onDown;
    public event VoidDelegate onEnter;
    public event VoidDelegate onExit;
    public event VoidDelegate onUp;
    public event VoidDelegate onSelect;
    public event VoidDelegate onUpdateSelect;

    public delegate void DragDelegate(GameObject go, PointerEventData eventData);
    public DragDelegate onDrag;

    public DragDelegate onBeginDrag;
    public DragDelegate onEndDrag;

    static public UIEventListener Get(GameObject go)
    {
        UIEventListener listener = go.GetComponent<UIEventListener>();
        if (listener == null) listener = go.AddComponent<UIEventListener>();
        return listener;
    }
    public override void OnPointerClick(PointerEventData eventData)
    {
        if (onClick != null) onClick(gameObject);
    }
    public override void OnPointerDown(PointerEventData eventData)
    {
        if (onDown != null) onDown(gameObject);
    }
    public override void OnPointerEnter(PointerEventData eventData)
    {
        if (onEnter != null) onEnter(gameObject);
    }
    public override void OnPointerExit(PointerEventData eventData)
    {
        if (onExit != null) onExit(gameObject);
    }
    public override void OnPointerUp(PointerEventData eventData)
    {
        if (onUp != null) onUp(gameObject);
    }
    public override void OnSelect(BaseEventData eventData)
    {
        if (onSelect != null) onSelect(gameObject);
    }
    public override void OnUpdateSelected(BaseEventData eventData)
    {
        if (onUpdateSelect != null) onUpdateSelect(gameObject);
    }

    public override void OnBeginDrag (PointerEventData eventData)
    {
        if (onBeginDrag != null) onBeginDrag(gameObject, eventData);
    }

    public override void OnDrag(PointerEventData eventData)
    {
        if (onDrag != null) onDrag(gameObject,eventData);
    }

    public override void OnEndDrag(PointerEventData eventData)
    {
        if (onEndDrag != null) onEndDrag(gameObject, eventData);
    }
}
