using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class URL : MonoBehaviour
{
    public void OpenURL()
    {
        //Copy your portfolio website URL and past here

        Application.OpenURL("https://sites.google.com/bcestudent.com/raziel-thomas/home?pli=1");
        Debug.Log("is this working");
    }
}
