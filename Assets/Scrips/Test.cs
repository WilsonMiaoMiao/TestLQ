using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
public class Test : MonoBehaviour,IBeginDragHandler,IDragHandler,IDropHandler,IEndDragHandler,IPointerEnterHandler,
    IPointerExitHandler,IPointerDownHandler,IPointerUpHandler,IPointerClickHandler
{
    //������ק��ص��¼�������ʵ��OnDrag�ӿڣ����򲻻�ִ�У�
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
    //ʵ����ק������Ӧ��ʼ�հ�ͼ��������߼�
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
   //���̧��
    public void OnPointerUp(PointerEventData eventData)
    {

    }
    //ִ����Down��Up�������������һ��Click
    public void OnPointerClick(PointerEventData eventData)
    {
        //print(eventData.clickTime);
        //if (eventData.clickCount == 2)
        //{
        //    Destroy(gameObject);
        //}
    }
}
