using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainChar_Controller : MonoBehaviour
{
    private CharacterController cc;
    public float Speed;
    public float Strafe;
    public float RotateSpeed;
    // Start is called before the first frame update
    void Start()
    {
        cc = GetComponent<CharacterController>(); 
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 lStick = new Vector2(Input.GetAxis("LStickX"), Input.GetAxis("LStickY"));
        if (lStick.magnitude > 0.0f)
        {
            Vector3 movement = transform.forward * Speed * lStick.y;
            Vector3 strafe = transform.right * Strafe * lStick.x;

          
            cc.SimpleMove(movement + strafe);

        }
        Vector2 rStick = new Vector2(Input.GetAxis("RStickX"), Input.GetAxis("RStickY"));
        if (rStick.magnitude > 0.0f)
        {
            transform.Rotate(new Vector3(0.0f, 1.0f, 0.0f), rStick.x * RotateSpeed);
        }

       
    }
}
