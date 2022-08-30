using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camerascript : MonoBehaviour
{
    public Camera mainCamera;
    public GameObject player; 
    private  float cameraOffset;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        mainCamera.transform.position = new Vector3(player.transform.position.x, cameraOffset, -10);
        if(player.transform.position.y < 2)
        {
            cameraOffset = 0;
        }
        else
        {
            cameraOffset = player.transform.position.y -2;
        }
    }
}
