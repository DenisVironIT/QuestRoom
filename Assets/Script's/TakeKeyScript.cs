using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TakeKeyScript : MonoBehaviour
{
    public bool keyCard = false;
    [SerializeField] GameObject card;
    [SerializeField] GameObject iconCard;
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
                    keyCard = true;
                    Destroy(card);
                    iconCard.SetActive(true);


                }


            }

        }


    }
}
