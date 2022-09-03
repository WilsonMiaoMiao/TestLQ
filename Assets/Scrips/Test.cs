using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
public class Test : MonoBehaviour,IBeginDragHandler,IDragHandler,IDropHandler,IEndDragHandler,IPointerEnterHandler,
    IPointerExitHandler,IPointerDownHandler,IPointerUpHandler,IPointerClickHandler
{
    //所有拖拽相关的事件都必须实现OnDrag接口，否则不会执行！
    public void OnDrag(PointerEventData eventData)
    {
        //RectTransform rect = GetComponent<RectTransform>();
        //Vector3 pos;
        //RectTransformUtility.ScreenPointToWorldPointInRectangle(rect, eventData.position, eventData.enterEventCamera, out pos);
        //rect.position = pos; 

        RectTransform rect =GetComponent<RectTransform>();
        rect.anchoredPosition += eventData.delta;
       
    }

    public void OnBeginDrag(PointerEventData eventData)
    {

    }
    //实现拖拽的物体应该始终把图层置于最高级
    public void OnDrop(PointerEventData eventData)
    {
        //Debug.Log("Drop!" + transform.name);
    }

    public void OnEndDrag(PointerEventData eventData)
    {

    }

    public void OnPointerEnter(PointerEventData eventData)
    {

    }

    public void OnPointerExit(PointerEventData eventData)
    {

    }

    public void OnPointerDown(PointerEventData eventData)
    {
        //print(eventData.clickTime);
    }
   //鼠标抬起
    public void OnPointerUp(PointerEventData eventData)
    {

    }
    //执行了Down和Up后算作是完成了一次Click
    public void OnPointerClick(PointerEventData eventData)
    {
        //print(eventData.clickTime);
        //if (eventData.clickCount == 2)
        //{
        //    Destroy(gameObject);
        //}
    }
}
