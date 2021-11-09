using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour //initialize the class Move as a monobehavior
{
    public float speed;
    public bool colliding;
    public float direction;

    public Rigidbody2D rb;//initialize the variable speed as a float (number with decible places) and public (changeable in unity and usable by other scripts)

    
    // Start is called before the first frame update
    void Start() 
    {
        
        rb = GetComponent<Rigidbody2D>();
        
    }

    // Update is called once per frame
    void Update()
    {
        if (colliding == false)
        { 
           MoveChar();
        }


         // each frame, call the function MoveChar
    }
     
    void MoveChar() //initializes a new function MoveChar
    {
        Vector3 newPos = transform.position; //new Vector3 called newPos that contains the position of the gameobject
        if (Input.GetKey(KeyCode.UpArrow)) //if you press the up arrow, the y transform position of the object will increase by the variable speed multiplied by time
        {
            direction = 1;
            newPos.y += speed * Time.deltaTime;
        }
        else if (Input.GetKey(KeyCode.DownArrow)) //the same process but with the down arrow and the y position is decreased
        {
            direction = 2;
            newPos.y -= speed * Time.deltaTime;
        }else if (Input.GetKey(KeyCode.RightArrow)) //right arrow, x position is increased
        {
            direction = 3;
            newPos.x += speed * Time.deltaTime;
        }
        else if (Input.GetKey(KeyCode.LeftArrow)) //left arrow, x position is decreased
        {
            direction = 4;
            newPos.x -= speed * Time.deltaTime;
        }
        transform.position = newPos; // position is set to the vector3 containing x and y positions changed by the arrow keys
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.GetComponent<TileData>().tileSpeed)
        {
            
            colliding = true;
           
            Vector3 newPos = transform.position;

            if (direction == 1)
            {
                newPos.y += 6 * Time.deltaTime;
                
            }
            if (direction == 2)
            {
                newPos.y -= 6 * Time.deltaTime;
            }
            if (direction == 3)
            {
                newPos.x += 6 * Time.deltaTime;
            }
            if (direction == 4)
            {
                newPos.x -= 6 * Time.deltaTime;
                
            }
            transform.position = newPos;
        }
        else
        {
            colliding = false;
            MoveChar();
            speed = 2;
        }
    }

}
