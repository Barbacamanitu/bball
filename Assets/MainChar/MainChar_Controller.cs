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

    }
}
