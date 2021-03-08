using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public float cameraPanSpeed = 10;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        Vector3 cameraPos = transform.position;

        if (Input.GetKey("w")) {
            cameraPos.z += Time.deltaTime * cameraPanSpeed;
        }
        if (Input.GetKey("s"))
        {
            cameraPos.z -= Time.deltaTime * cameraPanSpeed;
        }
        if (Input.GetKey("d"))
        {
            cameraPos.x += Time.deltaTime * cameraPanSpeed;
        }
        if (Input.GetKey("a"))
        {
            cameraPos.x -= Time.deltaTime * cameraPanSpeed;
        }
        if (Input.GetAxis("Mouse ScrollWheel") >0){//checks to see if scrolling down
            GetComponent<Camera> ().fieldOfView--;//lowers view
        }
        if (Input.GetAxis("Mouse ScrollWheel") <0){//sees if scrolling up
            GetComponent<Camera> ().fieldOfView++;//makes vision better
        }
        transform.position = cameraPos;
    }
}
