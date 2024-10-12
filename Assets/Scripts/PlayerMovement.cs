using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 10f; //Controls velocity multiplier

    Rigidbody2D rb; //Tells script there is a rigidbody, we can use variable rb to reference it in further script

    public AudioSource DamBuilding;
    public AudioSource TreeDestroy;

    public bool DestroyingTree;
    public bool BuildingDam;

    public Animator PlayerAnims;

    public int WoodCount = 0;
    public int WaterCount = 10;

    public TextMeshProUGUI WoodCountText;
    public TextMeshProUGUI WaterCountText;

    public Slider AngerMeter;
    public float AngerValue;


    public bool timeractive = true;
    public float timer;

    public bool timeractive1;
    public float timer1;

    public bool timeractive2;
    public float timer2;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>(); //rb equals the rigidbody on the player
        PlayerAnims = GetComponent<Animator>();
    }


    // Update is called once per frame
    void Update()
    {
        if(!DestroyingTree && !BuildingDam)
        {
            float xMove = Input.GetAxisRaw("Horizontal"); // d key changes value to 1, a key changes value to -1

            rb.velocity = new Vector3(xMove, 0, 0) * speed;
        }
        else
        {
            rb.velocity = new Vector3(0, 0, 0); //if building or destorying tree, don't move
        }

        if (!DestroyingTree && !BuildingDam && !Input.GetKey(KeyCode.A) && !Input.GetKey(KeyCode.D))
        {
            PlayerAnims.Play("BeaverIdle"); //if not building/destroying or moving, play idle anim
        }
        
        if(Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.D) && !DestroyingTree && !BuildingDam)
        {
            PlayerAnims.Play("BeaverWalk"); //if walking, play walking anim
        }

        if(Input.GetKey(KeyCode.A) && !DestroyingTree && !BuildingDam)
        {
            transform.localScale = new Vector3(-10, 10, 10);
        }

        if (Input.GetKey(KeyCode.D) && !DestroyingTree && !BuildingDam)
        {
            transform.localScale = new Vector3(10, 10, 10);
        }

        if(timeractive)
        {
            timer = timer + 1 * Time.deltaTime;
        }

        if (timeractive1)
        {
            timer1 = timer1 + 1 * Time.deltaTime;
        }

        if (timeractive2)
        {
            PlayerAnims.Play("BeaverBuild");
            timer2 = timer2 + 1 * Time.deltaTime;
        }

        if (timer1 > 2f)
        {
            WoodCount++;
            DestroyingTree = false;
            timer1 = 0;
            timeractive1 = false;
        }

        if (timer2 > 3f)
        {
            BuildingDam = false;
            timer2 = 0;
            timeractive2 = false;

            AngerValue = AngerValue - 0.40f;
            WaterCount--;
        }

        if (timer > 2f)
        {
            AngerValue = AngerValue + 0.03f;
            timer = 0;
        }

        AngerMeter.value = AngerValue;
        WoodCountText.text = WoodCount.ToString();
        WaterCountText.text = WaterCount.ToString();

        if(WaterCount == 0)
        {
            SceneManager.LoadScene("WinScene");
        }

        if (AngerValue == 1 || AngerValue > 1)
        {
            SceneManager.LoadScene("LoseScene");
        }
    }


    public void OnTriggerStay2D(Collider2D other)
    {
        if(other.tag == "Tree" && Input.GetKey(KeyCode.E))
        {
            timeractive1 = true;
            DestroyingTree = true;
            PlayerAnims.Play("BeaverDestroy");
            TreeDestroy.Play();
            PlayerAnims.Play("BeaverDestroy");

        }

        if (other.tag == "Water1" && Input.GetKey(KeyCode.R))
        {
            if (WoodCount == 1 || WoodCount > 1)
            {
                WoodCount -= 1;
                BuildingDam = true;
                timeractive2 = true;
                DamBuilding.Play();
                PlayerAnims.Play("BeaverBuild");
            }
        }

        if (other.tag == "Water2" && Input.GetKey(KeyCode.R))
        {
            if (WoodCount == 2 || WoodCount > 2)
            {
                WoodCount -= 2;
                BuildingDam = true;
                timeractive2 = true;
                DamBuilding.Play();
                PlayerAnims.Play("BeaverBuild");
            }
        }

        if (other.tag == "Water3" && Input.GetKey(KeyCode.R))
        {
            if (WoodCount == 3 || WoodCount > 3)
            {
                WoodCount -= 3;
                BuildingDam = true;
                timeractive2 = true;
                DamBuilding.Play();
                PlayerAnims.Play("BeaverBuild");
            }
        }

        if (other.tag == "Water4" && Input.GetKey(KeyCode.R))
        {
            if (WoodCount == 4 || WoodCount > 4)
            {
                WoodCount -= 4;
                BuildingDam = true;
                timeractive2 = true;
                DamBuilding.Play();
                PlayerAnims.Play("BeaverBuild");
            }
        }

        if (other.tag == "Water5" && Input.GetKey(KeyCode.R))
        {
            if (WoodCount == 5 || WoodCount > 5)
            {
                WoodCount -= 5;
                BuildingDam = true;
                timeractive2 = true;
                DamBuilding.Play();
                PlayerAnims.Play("BeaverBuild");
            }
        }

        if (other.tag == "Water6" && Input.GetKey(KeyCode.R))
        {
            if (WoodCount == 6 || WoodCount > 6)
            {
                WoodCount -= 6;
                BuildingDam = true;
                timeractive2 = true;
                DamBuilding.Play();
                PlayerAnims.Play("BeaverBuild");
            }
        }

        if (other.tag == "Water7" && Input.GetKey(KeyCode.R))
        {
            if (WoodCount == 7 || WoodCount > 7)
            {
                WoodCount -= 7;
                BuildingDam = true;
                timeractive2 = true;
                DamBuilding.Play();
                PlayerAnims.Play("BeaverBuild");
            }
        }

        if (other.tag == "Water8" && Input.GetKey(KeyCode.R))
        {
            if (WoodCount == 8 || WoodCount > 8)
            {
                WoodCount -= 8;
                BuildingDam = true;
                timeractive2 = true;
                DamBuilding.Play();
                PlayerAnims.Play("BeaverBuild");
            }
        }

        if (other.tag == "Water9" && Input.GetKey(KeyCode.R))
        {
            if (WoodCount == 9 || WoodCount > 9)
            {
                WoodCount -= 9;
                BuildingDam = true;
                timeractive2 = true;
                DamBuilding.Play();
                PlayerAnims.Play("BeaverBuild");
            }
        }

        if (other.tag == "Water10" && Input.GetKey(KeyCode.R))
        {
            if (WoodCount == 10 || WoodCount > 10)
            {
                WoodCount -= 10;
                BuildingDam = true;
                timeractive2 = true;
                DamBuilding.Play();
                PlayerAnims.Play("BeaverBuild");
            }
        }
    }

}
