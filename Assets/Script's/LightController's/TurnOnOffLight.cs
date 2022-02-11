using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnOnOffLight : MonoBehaviour
{
    [SerializeField] Animator animator;
    public bool play;
    [SerializeField] GameObject light;
    public Transform Player;

    void Start()
    {
        play = false;
    }

    void OnMouseOver()
    {
        {
            if (Player)
            {
                float dist = Vector3.Distance(Player.position, transform.position);
                if (dist < 5)
                {
                    if (play == false)
                    {
                        if (Input.GetKeyDown(KeyCode.E))
                        {
                            StartCoroutine(on());
                        }
                    }
                    else
                    {
                        if (play == true)
                        {
                            if (Input.GetKeyDown(KeyCode.E))
                            {
                                StartCoroutine(off());
                            }
                        }

                    }

                }
            }

        }

    }

    IEnumerator on()
    {
        print("you are turn on Light");
        light.SetActive(true);
        animator.Play("TurnOnLight");
        play = true;
        yield return new WaitForSeconds(.5f);
    }

    IEnumerator off()
    {
        print("you are turn off Light");
        light.SetActive(false);
        animator.Play("TurnOffLight");
        play = false;
        yield return new WaitForSeconds(.5f);
    }

}
