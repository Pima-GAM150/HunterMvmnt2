using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.SceneManagement;

public class Pointer : MonoBehaviour
{
    public Transform center;

    // Update is called once per frame
    void Update()
    {
        transform.LookAt(center);
        transform.position = Vector3.Slerp(transform.position,rotateSphereXAxis.find.GetCameraX() /2 + rotateSphereZAxis.find.GetCameraZ() / 2,Time.deltaTime);

        RaycastHit currentHit;
        if (Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out currentHit, Mathf.Infinity, LayerMask.GetMask("Default")))
        {
            if (currentHit.collider.gameObject.tag == "Win") Debug.Log("Win");
            //if (gameObject.tag == "Win") SceneManager.LoadScene(LevelLoader.find.levelIndex + 1);
        }
    }
}
