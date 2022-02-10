
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


    void OnTriggerStay(Collider other)
    {
        if (other.tag == "Player")
            monitor.SetActive(true);
        if (input.text.Length > 3)
        {
            input.DeactivateInputField(true);
        }
            
        if (input.text == "5511")
        {
            print("Unlock");
            giveKey.Play("Open");
        }

    }
    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
            monitor.SetActive(false);
    }

    void OnMouseOver()
    {
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
            }
        }
    }
    public void DeleteText()
    {
        input.text = null;
        input.ActivateInputField();
    }
    public void ExitPC()
    {
        StartCoroutine(closing());
    }

    IEnumerator opening()
    {
        print("nootebook turn on");

        playControl.GetComponent<FirstPersonController>().enabled = false;
        cameraPlayer.SetActive(false);
        cameraNotebook.SetActive(true);
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.Confined;


        turn = true;
        print(turn);
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



