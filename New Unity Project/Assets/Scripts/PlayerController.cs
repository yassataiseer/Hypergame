using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update
 public float speed;

    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
     if (Input.GetMouseButton(0)){
        Vector3 target = Camera.main.ScreenToWorldPoint(Input.mousePosition);//converting
         target.z = transform.position.z;
         transform.position = Vector3.MoveTowards(transform.position, target, speed);
     }
    }
}
