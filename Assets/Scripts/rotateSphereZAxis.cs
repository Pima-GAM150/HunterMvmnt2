using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotateSphereZAxis : MonoBehaviour
{
    public float cameraSpeed = 10f;

    public Transform cameraPos;

    public static rotateSphereZAxis find;

    private void Awake()
    {
        find = this;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow)) transform.Rotate(new Vector3(0f, 0f, Time.deltaTime * -cameraSpeed));
        if (Input.GetKey(KeyCode.DownArrow)) transform.Rotate(new Vector3(0f, 0f, Time.deltaTime * cameraSpeed));
    }

    public Vector3 GetCameraZ()
    {
        return cameraPos.position;
    }
}
