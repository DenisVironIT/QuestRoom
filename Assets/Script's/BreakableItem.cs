using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BreakableItem : MonoBehaviour
{
    public TakeScript Hammer;
    public bool brokenWindow = false;
    [SerializeField] AudioSource audioSource;
    [SerializeField] Rigidbody rb;
    [SerializeField] GameObject hammerArm;
    public Transform Player;
    private void Start()
    {

        rb = GetComponent<Rigidbody>();
    }


    void OnMouseOver()
    {
        if (Player)
        {
            float dist = Vector3.Distance(Player.position, transform.position);
            if (dist < 3)
            {

                if (Hammer.hammerCreate == true)
                {
                    print("Destroy");
                    if (Input.GetKeyDown(KeyCode.Mouse0))
                    {
                        print("Window broken");
                        Destroy(hammerArm);
                        Hammer.hammerCreate = false;
                        brokenWindow = true;
                        rb.isKinematic = false;
                        audioSource.Play();
                    }

                }
            }
        }
    }
}




