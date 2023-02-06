using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeihnachtsMann : MonoBehaviour
{
    public int health = 230;  
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
        }

        if (health < 0)
        {
            Destroy(gameObject);
        }

    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "snowball" )
        {
            health = health - 10;
        }

        if (collision.gameObject.tag == "axt")
        {
            health = health - 40;
        }

        if (collision.gameObject.tag == "granate")
        {
            health = health - 25;
        }

    }
}
