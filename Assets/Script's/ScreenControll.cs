
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;


public class ScreenControll : MonoBehaviour
{
    [SerializeField] private TMP_InputField input;
    public Animator giveKey;
    [SerializeField] GameObject cameraPlayer;
    [SerializeField] GameObject cameraNotebook;
    [SerializeField] GameObject monitor;
    [SerializeField] GameObject playControl;
    public bool turn;
    public Transform Player;

    void Start()
    {
        turn = false;
    }


    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
            monitor.SetActive(true);
      
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
            monitor.SetActive(false);
    }

    void OnMouseOver()
    {
        {

            if (input.text == "1234")
            {
                print("Unlock");
                giveKey.Play("Open");
            }
            if (Player)
            {
                float dist = Vector3.Distance(Player.position, transform.position);
                if (dist < 1.2)
                {
                    if (turn == false)
                    {
                        if (Input.GetKeyDown(KeyCode.E))
                        {
                            StartCoroutine(opening());
                        }
                    }
                    else
                    {
                        if (turn == true)
                        {
                            if (Input.GetKeyDown(KeyCode.E))
                            {
                                StartCoroutine(closing());
                            }
                        }

                    }

                }
            }

        }

    }

    IEnumerator opening()
    {
        print("nootebook turn on");

        playControl.GetComponent<FirstPersonController>().enabled = false;
        cameraPlayer.SetActive(false);
        cameraNotebook.SetActive(true);
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;


        turn = true;
        yield return new WaitForSeconds(.5f);
    }

    IEnumerator closing()
    {
        print("nootebook turn off");

        playControl.GetComponent<FirstPersonController>().enabled = true;
        cameraPlayer.SetActive(true);
        cameraNotebook.SetActive(false);
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
        turn = false;
        yield return new WaitForSeconds(.5f);
    }


}



