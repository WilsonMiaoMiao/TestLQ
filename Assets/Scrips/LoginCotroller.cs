using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LoginCotroller : MonoBehaviour
{
    public InputField UserName;
    public InputField Password;
    public Text Messange; 
    void Start()
    {
      
    }
  public void OnButtonCLick()
    {
        if(UserName.text =="wyf"&&Password.text=="7870468")
        {
            Messange.text = "����ɹ���";
            Messange.enabled = true;
            Invoke("Close", 1.5f);
        }
        else
        {
            Messange.text = "����������û��������������������룡";
            Messange.enabled = true;
            Invoke("Close", 3f);
        }
    }
    public void Close()
    {
        Messange.enabled = false;
    }
}
