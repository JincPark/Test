using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndingFlow : MonoBehaviour
{
    public float moveSpeed = -0.1f;
    public float moveTime = 0.3f;
    public Vector3 StartPosition = new Vector3(0, 700, 0);
    public GameObject button;

    private void Awake()
    {
        transform.position += StartPosition;
        button.SetActive(false);
    }
    // Start is called before the first frame update
    //void Start()
    //{
    //    StartCoroutine(flowEndingCredit());
    //}

    //IEnumerator flowEndingCredit()
    //{
    //    while (transform.position.y >  -2000.0f)
    //    {
    //    yield return new WaitForSeconds(moveTime);

    //    }
    //}
    private void Update()
    {

        Vector3 move = new Vector3(0, moveSpeed, 0);

        transform.Translate(move);

        if (transform.position.y <= -100)
        {
            button.SetActive(true);
        }
    }
}
