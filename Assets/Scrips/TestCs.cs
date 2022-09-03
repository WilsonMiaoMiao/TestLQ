using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TestCs : MonoBehaviour
{
    public Image Mask;
    public bool isCold;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    // Update is called once per frame
    void Update()
    {
        if(isCold&&Mask.fillAmount>0)
       Mask.fillAmount -= Time.deltaTime;
       else
        {
            Mask.fillAmount = 0;
            isCold = false;
        }


    }
    public void OnClick()
    {
        if(!isCold)
        {
            isCold = true;
            Mask.fillAmount = 1;
        }
    }
}
