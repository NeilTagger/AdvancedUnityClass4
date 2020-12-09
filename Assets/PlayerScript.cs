using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    private Touch touch;
    private float speedModifier;


    public new Rigidbody rigidbody;
    protected Joystick joystick;
    // Start is called before the first frame update
    void Start()
    {
        joystick = FindObjectOfType<Joystick>();
        speedModifier = 0.005f;


    }

    // Update is called once per frame
    void Update()
    {
        rigidbody.velocity = new Vector3(joystick.Horizontal * 10f,rigidbody.velocity.y,joystick.Vertical*10f);
        if (Input.touchCount > 0)
        {
            touch = Input.GetTouch(0);
            if(touch.phase==TouchPhase.Moved)
            {
                transform.position = new Vector3(transform.position.x + touch.deltaPosition.x * speedModifier,transform.position.y, transform.position.z + touch.deltaPosition.y * speedModifier);
            }
        }
    }
}
