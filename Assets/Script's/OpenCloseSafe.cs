using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenCloseSafe : MonoBehaviour
{
    public Animator openandclose;
    public AudioSource soundSafe;
    public bool open;
    [SerializeField] TakeKeyScript key;
    public Transform Player;
    void Start()
    {
        open = false;
    }

    void OnMouseOver()
    {

        if (Player)
        {
            float dist = Vector3.Distance(Player.position, transform.position);
            if (dist < 3)
            {
                if (key.keyCard == true)
                {
                    if (open == false)
                    {
                        if (Input.GetKeyDown(KeyCode.E))
                        {
                            StartCoroutine(opening());
                        }
                    }

                    else
                    {
                        if (open == true)
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
        print("you are opening the safe");
        openandclose.Play("OpenSafeDoor");
        soundSafe.Play();
        open = true;
        yield return new WaitForSeconds(.5f);
    }

    IEnumerator closing()
    {
        print("you are closing the safe");
        openandclose.Play("CloseSafeDoor");
        soundSafe.Play();
        open = false;
        yield return new WaitForSeconds(.5f);
    }
}






