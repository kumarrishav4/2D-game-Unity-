using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pipe_middle_script : MonoBehaviour
{
    // Start is called before the first frame update
    public LogicScript logic;
    void Start()
    {
        logic= GameObject.FindGameObjectWithTag("logic_tag").GetComponent<LogicScript>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
       logic.addScore();
    }
}
