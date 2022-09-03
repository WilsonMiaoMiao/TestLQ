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
            Messange.text = "登入成功！";
            Messange.enabled = true;
            Invoke("Close", 1.5f);
        }
        else
        {
            Messange.text = "您的密码或用户名输入有误，请重新输入！";
            Messange.enabled = true;
            Invoke("Close", 3f);
        }
    }
    public void Close()
    {
        Messange.enabled = false;
    }
}
