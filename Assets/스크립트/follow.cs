using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class follow : MonoBehaviour
{
    //GameObject Ghoul = GameObject.Find("Ghoul");
    public Transform target; // ����¯
    private Transform tr; // ����
    public float ds;

    //private Transform followers = new Transform();
    private List<Vector3> followerPos = new List<Vector3>(); // Ÿ���� ��ġ�� ����Ʈ. ���󰡱�����
   
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
        float distance = ((Vector3)target.position - followerPos[0]).magnitude; //���� ��ġ�� ������ġ������ �Ÿ� 

        if (distance > ds)
        {
            //���� ���� ��ġ�� ������ġ ������ �Ÿ���, 2 ���� Ŀ���� ���
            Vector3 direction = ((Vector3)target.position - followerPos[0]).normalized; // ��������

            followerPos.Insert(0, followerPos[0] + direction * ds); //������ ���̸�ŭ ���� ��ġ ������
            followerPos.RemoveAt(followerPos.Count - 1); // ������ ��ġ���� ���ֱ� (������ ����)

            distance -= ds; // �Ÿ� �ʱ�ȭ
        }

        //follower�� ���ڸ�ŭ

        tr.position = Vector3.Lerp(followerPos[1], followerPos[0], distance / ds);


        tr.LookAt(target);
    }
    //void MakeCivilianFollow()
    //{
    //    float distance = ((Vector3)target.position - followerPos[0]).magnitude; //���� ��ġ�� ������ġ������ �Ÿ� 

    //    if (distance > 2)
    //    {
    //        //���� ���� ��ġ�� ������ġ ������ �Ÿ���, 2 ���� Ŀ���� ���
    //        Vector3 direction = ((Vector3)target.position - followerPos[0]).normalized; // ��������

    //        followerPos.Insert(0, followerPos[0] + direction * 2); //������ ���̸�ŭ ���� ��ġ ������
    //        followerPos.RemoveAt(followerPos.Count - 1); // ������ ��ġ���� ���ֱ� (������ ����)

    //        distance -= 2; // �Ÿ� �ʱ�ȭ
    //    }

    //    //follower�� ���ڸ�ŭ

    //    tr.position = Vector3.Lerp(followerPos[1], followerPos[0], distance / 2);
        
    //}
}

