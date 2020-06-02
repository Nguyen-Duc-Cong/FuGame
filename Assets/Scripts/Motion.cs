using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Motion : MonoBehaviour
{
    enum Direction {
        Up = 0,
        Down = 1,
        Left = 2,
        Right = 3
    }

    [SerializeField]
    float speed;

    [SerializeField]
    Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        animator.SetBool("isWalking", false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void MoveUp()
    {
        transform.position += new Vector3(0.0f, speed * Time.deltaTime, 0.0f);
        animator.SetInteger("direction", (int)Direction.Up);
        animator.SetBool("isWalking", true);
    }
    public void MoveDown()
    {
        transform.position += new Vector3(0.0f, -speed * Time.deltaTime, 0.0f);
        animator.SetInteger("direction", (int)Direction.Down);
        animator.SetBool("isWalking", true);

    }
    public void MoveLeft()
    {
        transform.position += new Vector3(-speed * Time.deltaTime, 0.0f, 0.0f);
        animator.SetInteger("direction", (int)Direction.Left);
        animator.SetBool("isWalking", true);

    }
    public void MoveRight()
    {
        transform.position += new Vector3(speed * Time.deltaTime, 0.0f, 0.0f);
        animator.SetInteger("direction", (int)Direction.Right);
        animator.SetBool("isWalking", true);

    }

    public void Wait()
    {
        animator.SetBool("isWalking", false);
    }
}
