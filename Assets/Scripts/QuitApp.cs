using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuitApp : MonoBehaviour
{
    [SerializeField] GameObject panelGo;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Escape))
        {
            panelGo.SetActive(true);
        }
        // OpenPanel();
    }
    public void OpenPanel()
    {
        panelGo.SetActive(true);
    }
    public void YesButton()
    {
        Application.Quit();
    }
    public void NoButton()
    {
        panelGo.SetActive(false);
    }
}
