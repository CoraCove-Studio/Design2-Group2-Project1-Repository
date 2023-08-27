using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpFlashlight : MonoBehaviour
{
    public GameObject FlashlightOnPlayer;
    public GameObject pickUpText;

    // Start is called before the first frame update
    void Start()
    {
        FlashlightOnPlayer.SetActive(false);
        pickUpText.SetActive(false);
    }

    private void OnTiggerStay(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            pickUpText.SetActive(true);

            if (Input.GetKey(KeyCode.E))
            {
                this.gameObject.SetActive(false);
                FlashlightOnPlayer.SetActive(true);
            }
        }
    }
}
