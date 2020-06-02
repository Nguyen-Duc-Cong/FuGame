using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Motion motion;
    // Start is called before the first frame update
    void Start()
    {
        motion = GetComponent<Motion>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            motion.MoveUp();
        }
        else if (Input.GetKey(KeyCode.DownArrow))
        {
            motion.MoveDown();
        }
        else if (Input.GetKey(KeyCode.LeftArrow))
        {
            motion.MoveLeft();
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            motion.MoveRight();
        }
        else
        {
            motion.Wait();
        }
    }
}
