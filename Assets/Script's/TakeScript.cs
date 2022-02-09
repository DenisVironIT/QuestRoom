using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TakeScript : MonoBehaviour
{
    public bool hammerCreate = false;
    [SerializeField] GameObject hammerFloor;
    [SerializeField] GameObject hammerArm;

    public Transform Player;
    void OnMouseOver()
    {

        if (Player)
        {
            float dist = Vector3.Distance(Player.position, transform.position);
            if (dist < 3)
            {


                if (Input.GetKeyDown(KeyCode.E))
                {
                    hammerCreate = true;
                    Destroy(hammerFloor);
                    hammerArm.SetActive(true);
                    

                }


            }

        }


    }

}




