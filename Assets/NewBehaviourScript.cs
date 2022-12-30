using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{

    // Awake        : 스크립트의 수행 전
    // Start        : 스크립트의 시작
    // Update       : 스크립트 수행 중(반복) FPS 프레임 -> 컴퓨터 성능 별로 상이
    // LateUpdate   : 스크립트 수행 중(반복) 1초에 60번 -> 주기가 일정

    void Awake() // 특정 변수의 셋팅이 필요할 때.
    {
        int Speed = 2;
    }

    // Start is called before the first frame update
    void Start() // 한번만 써야할 떄
    {
        int Power = 2;
    }

    // Update is called once per frame
    void Update() // 계속 써야할 때
    {
        
    }

    void LateUpdate()
    {

    }
}
