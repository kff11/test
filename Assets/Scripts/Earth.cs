using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Earth : MonoBehaviour
{
    Transform tr;
    float yRot;
    // Start is called before the first frame update
    void Start()
    {
        tr = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        yRot += 10 * Time.deltaTime;
        transform.localRotation = Quaternion.Euler(new Vector3(0, yRot, 0));
    }
}
