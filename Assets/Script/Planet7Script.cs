using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Planet7Script : MonoBehaviour
{
    private float rotateAngle = 0f;
    private float selfRotateAngle = 0f;
    public static float selfRotateSpeed = 409f;
    private float rotateSpeed = selfRotateSpeed / 30689.88f;
    private float rotateRadius = 1.0f;

    void Start()
    {
        rotateRadius = transform.localPosition.x;
        Debug.Log(rotateRadius);
    }

    // Update is called once per frame
    void Update()
    {
        // get desired position
        float xPos = rotateRadius * Mathf.Cos(rotateAngle);
        float zPos = rotateRadius * Mathf.Sin(rotateAngle);

        transform.localPosition = new Vector3(xPos, 0f, zPos);

        rotateAngle += rotateSpeed * Time.deltaTime;

        selfRotateAngle = selfRotateSpeed * Time.deltaTime;
        //transform.Rotate(Vector3.up, selfRotateAngle)
        //이 메서드는 시계방향으로 회전시키므로 selfRotateAngle을 음수로 설정
        transform.Rotate(Vector3.up, -selfRotateAngle);
    }
}
