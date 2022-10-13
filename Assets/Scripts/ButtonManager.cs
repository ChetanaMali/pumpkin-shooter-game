using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonManager : MonoBehaviour
{
    public void PlayButton()
    {
        SceneManager.LoadScene(1);
        //GameManager.instance.fpsmovementScript.enabled = true;
    }
    public void CreditButton()
    {
        SceneManager.LoadScene(2);
    }
    public void QuitApplicationButton()
    {
        Application.Quit();
    }
    public void BackButton()
    {
        SceneManager.LoadScene(0);
    }
}
