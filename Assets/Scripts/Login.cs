using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Login : MonoBehaviour
{

    public TMP_InputField usernameInput;
    public TMP_InputField passwordInput;



    public void Submit()
    {
        StartCoroutine(Main.instance.web.Login(usernameInput.text, passwordInput.text));
    }
}
