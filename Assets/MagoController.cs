// using System.Collections;
// using System.Collections.Generic;
// using UnityEngine;
 
// public class MagoController : MonoBehaviour
// {
//     public Vector3 nextDir;
//     public float jumpForce = 100;
//     public float speed = 5;
//     public float speedRoot = 100;

//     Rigidbody rb;
//     public Vector3 curPosition;
// // Use this for initialization
//     void Start () {
//         rb = GetComponent<Rigidbody> ();
//     }

//     void Update () {
//         if (transform.position!=new Vector3(curPosition.x, transform.position.z, curPosition.y) + nextDir)
//         {
//             transform.position=Vector3.MoveTowards (transform.position,new Vector3 (curPosition.x, transform.position.z, curPosition.y) + nextDir, speed * Time.deltaTime);
//             transform.rotation=Quaternion.RotateTowards (transform.rotation, Quaternion.LookRotation (nextDir), speedRoot * Time.deltaTime);
//         } else {
//             nextDir = Vector3.zero;
//             curPosition=transform.position;
//             curPosition.x = Mathf.Round (curPosition.x);
//             curPosition.z = Mathf.Round (curPosition.z);
    
//             if (Input.GetAxisRaw ("Horizontal") != 0) {
//                 nextDir.y = Input.GetAxisRaw ("Horizontal");
//             } else if(Input.GetAxisRaw ("Vertical") != 0) {
//                 nextDir.x = Input.GetAxisRaw ("Vertical");
//                 Move();
//             }
//         }
//     }

//     void Move () {
//         rb.AddForce(0, jumpForce, 0);
//     }
// }

using System.Collections;  
using System.Collections.Generic;  
using UnityEngine;  
  
public class MagoController : MonoBehaviour  
{  
    Vector3 Vec;  
    // Start is called before the first frame update  
    void Start()  
    {  
          
    }  
  
    // Update is called once per frame  
    void Update()  
    {  
  
        Vec = transform.localPosition;  
        Vec.y += Input.GetAxis("Jump") * Time.deltaTime * 20;  
        Vec.x += Input.GetAxis("Horizontal") * Time.deltaTime * 20;  
        Vec.z += Input.GetAxis("Vertical") * Time.deltaTime * 20;  
        transform.localPosition = Vec;  
    }  
}  