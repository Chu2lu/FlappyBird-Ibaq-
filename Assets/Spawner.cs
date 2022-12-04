using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public Bird bird;
    public GameObject Pipes;
    public float height;
    public float time;
    void Start()
    {
        StartCoroutine(spawn(time));
    }
    public IEnumerator spawn(float time)
    {
        while (!bird.dead)
        {
            Instantiate(Pipes,new Vector3(3,Random.Range(-height,height),0),Quaternion.identity); 
            yield return new WaitForSeconds(time);
        }  
    }
}
