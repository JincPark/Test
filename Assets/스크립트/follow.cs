using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class follow : MonoBehaviour
{
    //GameObject Ghoul = GameObject.Find("Ghoul");
    public Transform target; // 유니짱
    private Transform tr; // 좀비
    public float ds;

    //private Transform followers = new Transform();
    private List<Vector3> followerPos = new List<Vector3>(); // 타겟의 위치값 리스트. 따라가기위해
   
    public float speed = 2f;

    void Start()
    {
        tr = GetComponent<Transform>();
        followerPos.Add(target.position);
    }

    // Update is called once per frame
    void Update()
    {
        //tr.position = new Vector3(target.position.x - 0.52f, tr.position.y, target.position.z - 6.56f);
        float distance = ((Vector3)target.position - followerPos[0]).magnitude; //이전 위치와 현재위치사이의 거리 

        if (distance > ds)
        {
            //만약 이전 위치와 현재위치 사이의 거리가, 2 보다 커졌을 경우
            Vector3 direction = ((Vector3)target.position - followerPos[0]).normalized; // 방향정보

            followerPos.Insert(0, followerPos[0] + direction * ds); //반지름 길이만큼 다음 위치 재조정
            followerPos.RemoveAt(followerPos.Count - 1); // 마지막 위치정보 없애기 (뒤쳐짐 방지)

            distance -= ds; // 거리 초기화
        }

        //follower의 숫자만큼

        tr.position = Vector3.Lerp(followerPos[1], followerPos[0], distance / ds);


        tr.LookAt(target);
    }
    //void MakeCivilianFollow()
    //{
    //    float distance = ((Vector3)target.position - followerPos[0]).magnitude; //이전 위치와 현재위치사이의 거리 

    //    if (distance > 2)
    //    {
    //        //만약 이전 위치와 현재위치 사이의 거리가, 2 보다 커졌을 경우
    //        Vector3 direction = ((Vector3)target.position - followerPos[0]).normalized; // 방향정보

    //        followerPos.Insert(0, followerPos[0] + direction * 2); //반지름 길이만큼 다음 위치 재조정
    //        followerPos.RemoveAt(followerPos.Count - 1); // 마지막 위치정보 없애기 (뒤쳐짐 방지)

    //        distance -= 2; // 거리 초기화
    //    }

    //    //follower의 숫자만큼

    //    tr.position = Vector3.Lerp(followerPos[1], followerPos[0], distance / 2);
        
    //}
}

