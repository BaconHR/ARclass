using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeavyFighterController : MonoBehaviour
{

    public Animator animator;

    public Transform target;

    public Joystick Joystick;
    public JoyStick JS;
    public JoyButton Joybutton;
    public bool attack;
    public bool walk ;
    public float gravity = 20.0f;

    public CharacterController controller;
    public Vector3 direction;

    void Start()
    {
        controller = GetComponent<CharacterController>();

        // let the gameObject fall down
        //gameObject.transform.position = new Vector3(0, 5, 0);
    }

    void Update()
    {
            if (controller.isGrounded)
            {
                transform.LookAt(target);

                Debug.Log("isGrounded");

                // We are grounded, so recalculate
                // move direction directly from axes

                direction = (Vector3.forward * Joystick.Horizontal + Vector3.left * Joystick.Vertical);
                Debug.Log(direction);
                direction = transform.TransformDirection(direction);
                direction = direction * 50f;
            }
        
        // Apply gravity
        direction.y = direction.y - (gravity * Time.deltaTime);

        // Move the controller
        controller.Move(direction * Time.deltaTime);

        if (!attack && Joybutton.Pressed)
            {
                attack = true;
                animator.SetTrigger("PunchTrigger");
            }

            if (attack && !Joybutton.Pressed)
            {
                attack = false;
                animator.SetTrigger("Idle");
            }

        /*if (JS.Pressed)
        {
            animator.SetBool("Walk Forward",true);
        }
        else
        {
            animator.SetBool("Walk Forward", false);
        }*/

    }

    }

