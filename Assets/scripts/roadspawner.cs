using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class roadspawner : MonoBehaviour
{
    spawn spawn;
    // Start is called before the first frame update
    void Start()
    {
        spawn = GameObject.FindObjectOfType<spawn>();
        
    }
    private void OnTriggerExit(Collider other)
    {
       
            spawn.spawnroad();
            Destroy(gameObject, 2);
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
