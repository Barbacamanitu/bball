using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharControl : MonoBehaviour
{
    public float WalkSpeed;
    private float cSpeed;
    // Start is called before the first frame update
    void Start()
    {
        cSpeed = 0;
    }

    // Update is called once per frame
    void Update()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");
        float wSpeed = v * WalkSpeed;
        if (Input.GetKey(KeyCode.LeftShift))
        {
            wSpeed *= 2.0f;
        }
        if (wSpeed > cSpeed)
        {
            cSpeed = wSpeed;
            
        }
        if (cSpeed > 0.01f)
        {
            cSpeed *= 0.9f;
            GetComponent<Animator>().SetFloat("WalkSpeed", cSpeed);
        }
        
    }
}
