using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIControl : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadScene("sahne");
    }

    public void YenidenBasla()
    {
        SceneManager.LoadScene("sahne");
    }

}
