using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ghost : MonoBehaviour
{
    public Rigidbody2D myRigidBody;
    public float FlapStength;
    // Start is called before the first frame update
    public LogicScript logic;
    public bool GhostIsAlive=true;
    
    void Start()
    {
        logic= GameObject.FindGameObjectWithTag("logic_tag").GetComponent<LogicScript>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space) && GhostIsAlive)
        {
            myRigidBody.velocity=Vector2.up*FlapStength;
        }
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        logic.gameOver();
        GhostIsAlive=false;
    }
}
