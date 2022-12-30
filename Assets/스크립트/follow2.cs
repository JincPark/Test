using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class follow2 : MonoBehaviour
{
    public float smooth = 3f;
    Transform standardPos;
    public Transform target;

    // Start is called before the first frame update
    void Start()
    {
        //standardPos = GameObject.Find("unitychan").transform; // 이름을 유니티짱으로 바꾸고
        transform.position = standardPos.position;
        transform.forward = standardPos.forward;
    }

    // Update is called once per frame
    //void Update()
    //{
    //    //transform.position = Vector3.Lerp(transform.position, standardPos.position, Time.deltaTime * smooth);
    //    //transform.forward = Vector3.Lerp(transform.forward, standardPos.forward, Time.deltaTime * smooth);

    //    //transform.position = Vector3.Lerp(transform.position, target.position, Time.deltaTime * smooth);
    //    //transform.forward = Vector3.Lerp(transform.forward, target.forward, Time.deltaTime * smooth);
    //}
    void FixedUpdate()
    {
        transform.position = Vector3.Lerp(transform.position, target.position, Time.fixedDeltaTime * smooth);
        transform.forward = Vector3.Lerp(transform.forward, target.forward, Time.fixedDeltaTime * smooth);
        transform.LookAt(target);
    }
}
