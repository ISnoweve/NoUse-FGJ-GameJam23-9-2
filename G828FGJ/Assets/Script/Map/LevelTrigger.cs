using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelTrigger : MonoBehaviour
{

    [SerializeField] private Transform portalTrans;


    void OnCollisionEnter2D(Collision2D other)
    {

        if (other.gameObject.CompareTag("Player"))
        {
            GameObject PressUI = GameObject.Find("PressUI");
            PressUI.SetActive(true);
            GameObject player = GameObject.FindGameObjectWithTag("Player");
            if (Input.GetKey(KeyCode.E))
            {
                player.transform.position = portalTrans.transform.position;

            }


        }
    }
    void OnCollisionExit2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            GameObject PressUI = GameObject.Find("PressUI");
            PressUI.SetActive(false);

        }
    }
}
