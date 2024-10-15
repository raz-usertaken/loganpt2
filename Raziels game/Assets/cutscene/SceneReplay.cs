using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneReplay : MonoBehaviour
{
    public void LoadScene()
    {
        SceneManager.LoadScene("Exit cut");
    }
}
