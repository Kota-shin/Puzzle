using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnmovableBoxCtr : MonoBehaviour
{
    float rotSpeed;             //障害物の回転速度

    // Start is called before the first frame update
    void Start()
    {
        rotSpeed = -2.0f;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, 0, rotSpeed);
    }
}
