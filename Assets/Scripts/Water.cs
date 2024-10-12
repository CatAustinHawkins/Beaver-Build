using UnityEngine;

public class Water : MonoBehaviour
{
    public float timer;
    public bool timeractive;

    public GameObject WaterWithDam;

    // Update is called once per frame
    void Update()
    {
        if (timeractive)
        {
            timer = timer + 1 * Time.deltaTime;
        }

        if (timer > 3)
        {
            WaterWithDam.SetActive(true);
            Destroy(gameObject);
        }
    }

    public void OnTriggerStay2D(Collider2D collision)
    {
        if (Input.GetKey(KeyCode.R))
        {
            timeractive = true;
        }
    }
}
