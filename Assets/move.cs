using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{
    public Transform vcam;
    public float toggleAngle=30.0f;
    public float speed= 3.0f;
    public bool moveForward;

    private CharacterController cc;
    // Start is called before the first frame update
    void Start()
    {
        cc=GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        if(vcam.eulerAngles.x <= toggleAngle && vcam.eulerAngles.x< 90.0f){
            moveForward= true;
        }
        else{
            moveForward=false;
        }
        if(moveForward){
            Vector3 forward= vcam.TransformDirection(Vector3.forward);
            cc.SimpleMove(forward*speed);
        }
    }
    
}
