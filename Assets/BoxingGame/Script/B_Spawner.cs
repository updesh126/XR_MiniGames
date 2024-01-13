using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class B_Spawner : MonoBehaviour
{
    B_cubePunch cube= new B_cubePunch();
    public GameObject[] cubes;
    public Transform[] Lpoints;
    public Transform[] Rpoints;
    public float speedrate = 0.25f;
    public Transform LC_Point;
    //public Transform RC_Point;
    public float beat= (20/130)*2;
    private float timer;
    int count = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (timer > beat)
        {
            
            GameObject Lcube = new GameObject();
            GameObject Rcube = new GameObject();
            if (count < 10)
            {
                switch (Random.Range(0, 3))
                {
                    case 0:
                        Lcube = Instantiate(cubes[0], Lpoints[Random.Range(0, 4)]);
                        break;
                    case 1:
                        Rcube = Instantiate(cubes[1], Rpoints[Random.Range(0, 4)]);
                        break;
                    case 2:
                        Lcube = Instantiate(cubes[0], Lpoints[Random.Range(0, 4)]);
                        Rcube = Instantiate(cubes[1], Rpoints[Random.Range(0, 4)]);
                        break;
                }
                count++;
                Debug.Log(count);
            }
            if(count == 10)
            {
                Lcube = Instantiate(cubes[2], LC_Point);
                count = 0;
                cube.speedrate(speedrate);
            }
            
            
            Lcube.transform.localPosition = Vector3.zero;
            Rcube.transform.localPosition = Vector3.zero;
            timer -= beat;

        }
        timer += Time.deltaTime;
        Debug.Log(timer.ToString());
    }
}
