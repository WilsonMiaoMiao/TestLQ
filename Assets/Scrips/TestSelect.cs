using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
public class TestSelect : MonoBehaviour, ISelectHandler, IUpdateSelectedHandler, IDeselectHandler,IMoveHandler,ISubmitHandler,ICancelHandler,IScrollHandler
{

    //Select接口需要挂载Selectable组件，而不是像其他大部分接口只需要继承
    public void OnDeselect(BaseEventData eventData)
    {
        Debug.Log("Deselect");
    }

    public void OnSelect(BaseEventData eventData)
    {
        Debug.Log("Select");
    }

    //当选中后,在没有点击另一个物体之前，（即使鼠标抬起），也仍然会调用该方法
    public void OnUpdateSelected(BaseEventData eventData)
    {
        Debug.Log("Update");
    }

    //三个接口对应EvenSystem的四个虚拟按键
    //以下四个必须挂载Selectable组件，且物体被选中
    public void OnMove(AxisEventData eventData)
    {

    }

    public void OnSubmit(BaseEventData eventData)
    {
        Debug.Log("Space and enter are clicked!");
    }

    public void OnCancel(BaseEventData eventData)
    {
        Debug.Log("Escape key are clicked!");
    }

    public void OnScroll(PointerEventData eventData)
    {

    }

}
