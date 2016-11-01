using UnityEngine;
using System.Collections;

public class PlayerBlack : MonoBehaviour {

    public float speed = 1f;
    private bool IsMoving = false;
    private Animator animator;
    private int direction = 0; //0 is none, 1 is left, 2 is right, 3 is down, 4 is up


    void Start()
    {
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftArrow))
            direction = 1;
        if (Input.GetKeyDown(KeyCode.RightArrow))
            direction = 2;
        if (Input.GetKeyDown(KeyCode.DownArrow))
            direction = 3;
        if (Input.GetKeyDown(KeyCode.UpArrow))
            direction = 4;

        if (Input.GetKey(KeyCode.LeftArrow) && direction == 1 && gameObject.transform.position.x >= -8f) 
        {
            gameObject.transform.position += new Vector3(-0.1f * speed, 0);
            animator.SetBool("IsMovingLeft", true);
            animator.SetBool("IsMovingRight", false);
            animator.SetBool("IsMovingUp", false);
            animator.SetBool("IsMovingDown", false);
        }
        if (Input.GetKey(KeyCode.RightArrow) &&  direction == 2 && gameObject.transform.position.x <= 8f)
        {
            gameObject.transform.position += new Vector3(0.1f * speed, 0);
            animator.SetBool("IsMovingRight", true);
            animator.SetBool("IsMovingLeft", false);
            animator.SetBool("IsMovingUp", false);
            animator.SetBool("IsMovingDown", false);
        }
        if (Input.GetKey(KeyCode.DownArrow) && direction == 3 && gameObject.transform.position.y >= -6.5f)
        {
            gameObject.transform.position += new Vector3(0, -0.1f * speed);
            animator.SetBool("IsMovingDown", true);
            animator.SetBool("IsMovingRight", false);
            animator.SetBool("IsMovingUp", false);
            animator.SetBool("IsMovingLeft", false);
        }
        if (Input.GetKey(KeyCode.UpArrow) && direction == 4 && gameObject.transform.position.y <= 6.5f)
        {
            gameObject.transform.position += new Vector3(0, 0.1f * speed);
            animator.SetBool("IsMovingUp", true);
            animator.SetBool("IsMovingRight", false);
            animator.SetBool("IsMovingLeft", false);
            animator.SetBool("IsMovingDown", false);
        }

        if (Input.GetKeyDown(KeyCode.Space))
            animator.SetTrigger("IsAtacking");

        if (Input.GetKeyUp(KeyCode.LeftArrow))
            animator.SetBool("IsMovingLeft", false);
        if (Input.GetKeyUp(KeyCode.RightArrow))
            animator.SetBool("IsMovingRight", false);
        if (Input.GetKeyUp(KeyCode.DownArrow))
            animator.SetBool("IsMovingDown", false);
        if (Input.GetKeyUp(KeyCode.UpArrow))
            animator.SetBool("IsMovingUp", false);
    }

    

}
