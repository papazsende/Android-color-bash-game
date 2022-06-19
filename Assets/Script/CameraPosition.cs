using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraPosition : MonoBehaviour
{
    public Transform Ball;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void LateUpdate()
    {
       
        transform.position = Ball.position+ new Vector3(0.15f,1f,-4f);
    }
}
/* (x,y,z) + (1,0,5) = x + 1 , y + 0 , z + 5 */