using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OpenMenuScript : MonoBehaviour
{
    [SerializeField] GameObject panelMenu;
    [SerializeField] GameObject playControl;
    private bool controlMenu = false;
    private void Update()
    {
        MenuControl();
    }
    public void MenuControl()
    {

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (!controlMenu)
            {
                Cursor.visible = true;
                Cursor.lockState = CursorLockMode.Confined;
                controlMenu = true;
                panelMenu.SetActive(true);
                Time.timeScale = 0;
                playControl.GetComponent<FirstPersonController>().enabled = false;
            }
            else
            {
                Cursor.visible = false;
                Cursor.lockState = CursorLockMode.Locked;
                controlMenu = false;
                panelMenu.SetActive(false);
                Time.timeScale = 1;
                playControl.GetComponent<FirstPersonController>().enabled = true;
            }
        }
    }
}
