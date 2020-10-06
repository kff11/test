using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moon : MonoBehaviour
{
    int angle = 0;

    int distance = 8; // 지구와 달의 거리
    int moonSpeed = 1; // 달 회전 속도
    float time = 0f; // 시간 측정

    Transform tr;
    // Start is called before the first frame update
    void Start()
    {
        tr = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime; // 현재 시간 측정

        StartCoroutine(moveMoon());

        if(time > 3) // 3초마다 add 함수 실행 
        {
            add();
        }
    }

    IEnumerator moveMoon()
    {
        angle += 1 * moonSpeed;
        float x = Mathf.Cos(Mathf.Deg2Rad * angle) * distance;
        float z = Mathf.Sin(Mathf.Deg2Rad * angle) * distance;

        tr.position = new Vector3(x, 0, z);
        yield return null;
    }
    
    void add()
    {
        moonSpeed++; // 달의 회전 속도 변화
        distance++; // 달의 거리 증가
        time = 0; // 시간 초기화
    }
}
