using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using HTC.UnityPlugin.ColliderEvent;

public class ThTouch : MonoBehaviour,IColliderEventHoverEnterHandler,IColliderEventPressDownHandler,IColliderEventClickHandler,IColliderEventDragEndHandler,IColliderEventDropHandler,IColliderEventAxisChangedHandler
{
  
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnColliderEventHoverEnter(ColliderHoverEventData eventData)
    {
        Debug.Log("  hover " +"射线进入");
    }

    void IColliderEventPressDownHandler.OnColliderEventPressDown(ColliderButtonEventData eventData)
    {
        throw new System.NotImplementedException();
    }

    void IColliderEventClickHandler.OnColliderEventClick(ColliderButtonEventData eventData)
    {
        throw new System.NotImplementedException();
    }

    public void OnColliderEventDragEnd(ColliderButtonEventData eventData)
    {
        throw new System.NotImplementedException();
    }

    void IColliderEventDropHandler.OnColliderEventDrop(ColliderButtonEventData eventData)
    {
        throw new System.NotImplementedException();
    }

    public void OnColliderEventAxisChanged(ColliderAxisEventData eventData)
    {
        throw new System.NotImplementedException();
    }
}
