using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

namespace SojaExiles

{
    public class VideoController : MonoBehaviour
    {

        public VideoPlayer video;
        public AudioSource audioSource;
        public bool play;
        [SerializeField] GameObject screen;
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
                                StartCoroutine(playing());
                            }
                        }
                        else
                        {
                            if (play == true)
                            {
                                if (Input.GetKeyDown(KeyCode.E))
                                {
                                    StartCoroutine(pausing());
                                }
                            }

                        }

                    }
                }

            }

        }

        IEnumerator playing()
        {
            print("you are playing video");
            audioSource.Pause();
            screen.SetActive(true);
            video.Play();
            play = true;
            yield return new WaitForSeconds(.5f);
        }

        IEnumerator pausing()
        {
            print("you are pause video");
            audioSource.Play();
            screen.SetActive(false);
            video.Stop();
            play = false;
            yield return new WaitForSeconds(.5f);
        }


    }
}