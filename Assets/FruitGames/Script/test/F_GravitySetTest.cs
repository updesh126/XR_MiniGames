using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class GravitySetTest : MonoBehaviour
{
    [SerializeField] F_ScoreSystem scoreSystem;
    Rigidbody rb;
    bool isactive;
    private void Start()
    {
        isactive = false;
    }
    void ActiveGravity()
    {
        rb = GetComponent<Rigidbody>();
        rb.useGravity = true;
        scoreSystem.Apple();
    }
    
    
    
}
