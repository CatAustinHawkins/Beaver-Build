using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FullTree : MonoBehaviour
{
    public float timer;
    public bool timeractive;

    public GameObject DestoryedTree;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (timeractive)
        {
            timer = timer + 1 * Time.deltaTime;
        }

        if (timer > 2)
        {
            gameObject.SetActive(false);
            DestoryedTree.SetActive(true);
            timer = 0;
        }
    }

    public void OnTriggerStay2D(Collider2D collision)
    {
        if(Input.GetKey(KeyCode.E))
        {
            timeractive = true;
        }
    }

    public void OnTriggerExit2D(Collider2D collision)
    {
        timeractive = false;
    }
}
