using System.Collections;
using System.Collections.Generic;
using UnityEditor.Rendering;
using UnityEngine;

public class B_cubePunch : MonoBehaviour
{
    [SerializeField]
    public static float speed = 1.0f;
    
    void Start()
    {
        
    }
    void Update()
    {
        transform.position -= Time.deltaTime * transform.forward * 3 *speed;
    }
    
    public void speedrate(float rate)
    {
        speed += rate;
        Debug.Log("Speed increase:" +speed);
    }
    public void speedReset()
    {
        speed = 1.0f;
    }
}
