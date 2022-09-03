using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
public class TestSelect : MonoBehaviour, ISelectHandler, IUpdateSelectedHandler, IDeselectHandler,IMoveHandler,ISubmitHandler,ICancelHandler,IScrollHandler
{

    //Select�ӿ���Ҫ����Selectable������������������󲿷ֽӿ�ֻ��Ҫ�̳�
    public void OnDeselect(BaseEventData eventData)
    {
        Debug.Log("Deselect");
    }

    public void OnSelect(BaseEventData eventData)
    {
        Debug.Log("Select");
    }

    //��ѡ�к�,��û�е����һ������֮ǰ������ʹ���̧�𣩣�Ҳ��Ȼ����ø÷���
    public void OnUpdateSelected(BaseEventData eventData)
    {
        Debug.Log("Update");
    }

    //�����ӿڶ�ӦEvenSystem���ĸ����ⰴ��
    //�����ĸ��������Selectable����������屻ѡ��
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
