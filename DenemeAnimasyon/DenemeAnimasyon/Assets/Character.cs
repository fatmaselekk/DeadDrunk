using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
    [SerializeField] private float speed = 5f;
    private float gravity = 8f;
    //[SerializeField] private ConfigurableJoint hipJoint;
    //[SerializeField] private Rigidbody hip;
    private CharacterController characterController;
    //[SerializeField] private Animator targetAnimator;
    //private ManagerJoystick managerJoystick;
    private bool walk = false;
    // Start is called before the first frame update
    void Start()
    {
       //managerJoystick = GameObject.Find("imgJoystickBg").GetComponent<ManagerJoystick>();
        characterController = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        //     float horizontal = managerJoystick.inputHorizontal();
        // float vertical = managerJoystick.inputVertical();;

        float horizontal = Input.GetAxisRaw("Horizontal");
        float vertical = Input.GetAxisRaw("Vertical");
        this.walk = true;
        Vector3 direction = new Vector3(horizontal, 0f, vertical);
        direction *= speed;
        //direction.y -=gravity; 
        characterController.Move(direction * Time.deltaTime);
        if (direction.magnitude >= 0.1f)
        {
            //   float targetAngle = Mathf.Atan2(direction.z, direction.x) * Mathf.Rad2Deg;

            // this.hipJoint.targetRotation = Quaternion.Euler(0f, targetAngle/50, 0f);

            // this.hip.AddForce(direction * (this.speed));

    //                  Vector3 tempVect = new Vector3(horizontal, 0, vertical);
    // tempVect = tempVect.normalized * speed * Time.deltaTime;
    // hip.MovePosition(transform.position + tempVect);

            //this.walk = true;
         }  
         else {
            //this.walk = false;
        }

        //this.targetAnimator.SetBool("Walking", this.walk);
    }
}
