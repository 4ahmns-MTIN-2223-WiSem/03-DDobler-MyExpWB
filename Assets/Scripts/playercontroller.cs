using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playercontroller : MonoBehaviour
{
    public string shootkey;
    public GameObject projectile;
    public Transform spawnPos;
    public Vector3 projectileForce;
    public SphereCollider bx;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Rigidbody rb = GetComponent<Rigidbody>();
        if (Input.GetKey(KeyCode.A))
            rb.AddForce(Vector3.left);
        if (Input.GetKey(KeyCode.D))
            rb.AddForce(Vector3.right);
        if (Input.GetKey(KeyCode.W))
            rb.AddForce(Vector3.forward);
        if (Input.GetKey(KeyCode.S))
            rb.AddForce(Vector3.back);
        if (Input.GetKey(KeyCode.Space))
            rb.AddForce(Vector3.up * 3f);
        if (Input.GetKey(KeyCode.LeftShift))
            rb.AddForce(Vector3.down);

        if (Input.GetKeyDown(shootkey))
        {
            GameObject clone = Instantiate(projectile);
            clone.transform.position = spawnPos.position;
            Rigidbody rbClone = clone.GetComponent<Rigidbody>();
            rbClone.AddForce(projectileForce);

        }
    }
}
