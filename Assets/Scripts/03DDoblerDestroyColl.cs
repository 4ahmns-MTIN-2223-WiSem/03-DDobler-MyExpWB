using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyColl : MonoBehaviour
{
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision x)
    {
        Debug.Log("Projetil trifft etwas!");
        
        Debug.Log("ich: " +gameObject.name+"mein collision object " + x.gameObject.name);
        
            Destroy(gameObject);
        
    }

}
