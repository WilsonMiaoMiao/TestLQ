using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ColdCotroller : MonoBehaviour
{
    public KeyCode keyCode = KeyCode.Alpha1;
    public Image ColdingMask;
    public float coldTime=1;
    private float timer=0;
    bool isCold = false;
    // Start is called before the first frame update
    void Awake()
    {
        ColdingMask = transform.Find("ColdingMask").GetComponent<Image>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(keyCode))
        {
            ReleaseSkill();
        }
        if(isCold)
        {
            timer += Time.deltaTime;
            ColdingMask.fillAmount = (coldTime - timer) / 2;
            if(timer>=coldTime)
            {
                isCold = false;
                timer = 0;
                ColdingMask.fillAmount = 0;
            }
        }
    }
    public void OnSkillClick()
    {
        ReleaseSkill();
    }
    private void ReleaseSkill()
    {
        if (isCold == false)
        {
            isCold = true;
            ColdingMask.fillAmount = 1;
        }
    }

}
