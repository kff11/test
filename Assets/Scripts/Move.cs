using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    float zPos = 0f;
    float zRot = 0f;

    Transform tr;
    // Start is called before the first frame update
    void Start()
    {
        tr = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        StartCoroutine(rotate());
        /*zRot += 0.001f;
        tr.localRotation = Quaternion.Euler(new Vector3(0, 0, zRot));*/
    }

    IEnumerator rotate()
    {
        zRot += 1f;
        tr.localRotation = Quaternion.Euler(new Vector3(0, 0, zRot));

        yield return null;
    }
}
