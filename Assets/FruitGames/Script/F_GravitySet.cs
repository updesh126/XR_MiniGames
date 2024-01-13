using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class F_GravitySet : MonoBehaviour
{
    [SerializeField] F_ScoreSystem scoreSystem;

    bool isactive;
    private void Start()
    {
        isactive = false;
    }

    Rigidbody rb;
    void OnTriggerEnter(Collider other)
    {
        if (!isactive && other.gameObject.tag =="Apple")
        {
            //isactive = true;
            Debug.Log("Collid A");
            scoreSystem.Apple();
            rb =other.gameObject.GetComponent<Rigidbody>();
            rb.useGravity = true;
           

        }
        if (!isactive&& other.gameObject.tag == "Orange")
        {
            Debug.Log("Collid O");
            scoreSystem.Orange();
            rb =other.gameObject.GetComponent<Rigidbody>();
            rb.useGravity = true;
            //isactive = true;
        }
        if (!isactive && other.gameObject.tag == "Mango")
        {
            Debug.Log("Collid M");
            scoreSystem.Mango();
            rb =other.gameObject.GetComponent<Rigidbody>();
            rb.useGravity = true;
            //isactive = true;
        }
        isactive = true;
        /*else
        {
            Debug.Log("Nothing check tag");
        }*/
    }
    private void OnTriggerExit(Collider other)
    {
        isactive = false;
    }
}
