using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Escapemenu : MonoBehaviour
{
    //[SerializeField] GameObject Escapemenupanel;
    //[SerializeField] GameObject Quitpanel;
    
  
    void Update()
    {
        
        if (Input.GetKey(KeyCode.Escape))
        {

            Time.timeScale = 0;
            Cursor.visible = true;
            Cursor.lockState = CursorLockMode.None;
            GameManager.instance.Escapemenupanel.SetActive(true);
            GameManager.instance.gameoverpanel.SetActive(false);
        }
        
    }
    public void resume()
    {
        Time.timeScale = 1;
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
        GameManager.instance.Escapemenupanel.SetActive(false);
    }
   
    public void BacktoMenu()
    {
        SceneManager.LoadScene(0);
    }
    
}
