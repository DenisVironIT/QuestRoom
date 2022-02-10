using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BreakableItem : MonoBehaviour
{
    public TakeScript Hammer;
    public bool brokenWindow = false;  //sound street if window broken
    [SerializeField] AudioSource audioSource;
    [SerializeField] AudioSource brokenGlass;
    [SerializeField] Rigidbody rb;
    [SerializeField] GameObject hammerArm;
    [SerializeField] GameObject window;
    public Transform Player;
    private void Start()
    {

        rb = GetComponent<Rigidbody>();
    }
    IEnumerator DestroyWindow()
    {
        brokenGlass.Play();
        yield return new WaitForSeconds(0.5f);
        Destroy(window);
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
                        StartCoroutine(DestroyWindow());
                    }

                }
            }
        }
    }
}




