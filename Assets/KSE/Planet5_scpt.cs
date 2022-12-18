using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Planet5_scpt : MonoBehaviour
{
    private float rotateAngle = 0f;
    private float selfRotateAngle = 0f;
    public static float selfRotateSpeed = 639f; 
    private float rotateSpeed = selfRotateSpeed / 4332.71f; 
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
        //�� �޼���� �ð�������� ȸ����Ű�Ƿ� selfRotateAngle�� ������ ����
        transform.Rotate(Vector3.up, -selfRotateAngle);
    }
}
