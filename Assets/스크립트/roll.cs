using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class roll : MonoBehaviour
{
    public float Speed = 5f;
    Vector3 ps;
    Vector3 initPs;
    public string dir;
    void Start()
    {
        //transform.position = new Vector3(4.5f, 1f, 4.5f);
        ps = transform.position;
        initPs = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        switch (dir)
        {
            case "N":
                ps.z += Speed * Time.deltaTime;
                transform.Rotate(new Vector3(Speed, 0, 0));
                if (ps.z - initPs.z >= 32.5)
                {
                    transform.position = initPs;
                    ps = initPs;
                }
                break;
            case "S":
                ps.z -= Speed * Time.deltaTime;
                transform.Rotate(new Vector3(-Speed, 0, 0));
                if (ps.z - initPs.z <= -32.5)
                {
                    transform.position = initPs; ps = initPs;
                }
                break;
            case "W":
                ps.x -= Speed * Time.deltaTime;
                transform.Rotate(new Vector3(0, 0, Speed));
                if (ps.x - initPs.x <= -32.5) 
                {
                    transform.position = initPs;
                    ps = initPs;
                }
                break;
            case "E":
                ps.x += Speed * Time.deltaTime;
                transform.Rotate(new Vector3(0, 0, -Speed));
                if (ps.x - initPs.x >= 32.5)
                {
                    transform.position = initPs;
                    ps = initPs;
                }
                break;
        }
        transform.position = ps;


    }
}
