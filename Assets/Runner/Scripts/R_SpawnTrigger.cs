using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class R_SpawnTrigger : MonoBehaviour
{
    public R_SpawnManager spawnManager;
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "SpawnTrigger")
            spawnManager.spawnTriggerEntered();
    }
}
