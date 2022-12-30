using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class MessageMove : MonoBehaviour
{
    public float Speed = 1.0f;
    public float xSpeed = 0f;
    public float ySpeed = 0f;
    public float zSpeed = 0f;

    public float xPosition = -8.1f;
    public float yPosition = -11.2f;
    public float zPosition = 3.6f;

    //GameObject msg = GameObject.Find("FlowText");
    // Start is called before the first frame update
    void Start()
    {
        //transform.position = new Vector3(xPosition, yPosition, zPosition);
        //Vector3 Pose = this.GameObject.transform.position;
    }

    // Update is called once per frame
    void Update()
    {

        Vector3 vector3 = new Vector3(xSpeed, ySpeed, zSpeed);
        transform.Translate(vector3 * Time.deltaTime*Speed);

        //if(yPosition > 10 ) transform.position = new Vector3(xPosition, yPosition, zPosition);
    }
}
