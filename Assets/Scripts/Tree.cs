using UnityEngine;

public class Tree : MonoBehaviour
{

    public float timer;
    public bool timeractive;

    public GameObject FullTree;

    void Update()
    {
        if (timeractive)
        {
            timer = timer + 1 * Time.deltaTime;
        }

        if (timer > 10)
        {
            FullTree.SetActive(true);
            gameObject.SetActive(false);

        }

        if (timer == 10)
        {
            FullTree.SetActive(true);
            gameObject.SetActive(false);

        }
    }

    private void OnEnable()
    {
        timeractive = true;
    }

    private void OnDisable()
    {
        timeractive = false;
        timer = 0;
    }

}
