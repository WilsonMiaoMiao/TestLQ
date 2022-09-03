using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
public class ScrollCotroller : MonoBehaviour, IBeginDragHandler, IEndDragHandler
{
    public float[] page = new float[4];
    public ScrollRect scrollRect;
    // Start is called before the first frame update
    void Awake()
    {
        scrollRect = GetComponent<ScrollRect>();  
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    //public void OnValueChange(Vector2 v)
    //{
    //    Debug.Log(v);
    //}
    public void OnEndDrag(PointerEventData eventData)
    {
        float curremtPosition = scrollRect.horizontalNormalizedPosition;
        float offset = Mathf.Abs(curremtPosition - page[0]);
        int index= 0 ;
        for(int i=1;i<=3 ;i++ )
        {
            if(offset > Mathf.Abs(curremtPosition - page[i]))
            {
                offset = Mathf.Abs(curremtPosition - page[i]);
                index = i;
            }
        }
        scrollRect.horizontalNormalizedPosition = page[index];
        Debug.Log(scrollRect.horizontalNormalizedPosition);
    }

    public void OnBeginDrag(PointerEventData eventData)
    {
     
        //暂时不需要
    }
}
