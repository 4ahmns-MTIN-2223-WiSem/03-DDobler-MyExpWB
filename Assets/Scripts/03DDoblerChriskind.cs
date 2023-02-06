using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chriskind : MonoBehaviour
{
    public int health = 800;
    public GameObject chrisKind;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    
            if (health == 0 )
        {
            Destroy(gameObject);
            GameObject clone = Instantiate(chrisKind);
        }
      
    }
    private void OnCollisionEnter(Collision collision)
{
    if (collision.gameObject.tag == "snowball")
    {
        health = health - 30;
    }

}
}
