using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{

    // Awake        : ��ũ��Ʈ�� ���� ��
    // Start        : ��ũ��Ʈ�� ����
    // Update       : ��ũ��Ʈ ���� ��(�ݺ�) FPS ������ -> ��ǻ�� ���� ���� ����
    // LateUpdate   : ��ũ��Ʈ ���� ��(�ݺ�) 1�ʿ� 60�� -> �ֱⰡ ����

    void Awake() // Ư�� ������ ������ �ʿ��� ��.
    {
        int Speed = 2;
    }

    // Start is called before the first frame update
    void Start() // �ѹ��� ����� ��
    {
        int Power = 2;
    }

    // Update is called once per frame
    void Update() // ��� ����� ��
    {
        
    }

    void LateUpdate()
    {

    }
}
