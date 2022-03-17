using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Animator anime;
    public Rigidbody2D  playerRigidbody;
    public int forceJump;

    public bool jump;
    public bool slide;

    public Transform groundCheck;
    public bool grounded;
    public LayerMask whatIsGround;

    public float slideTemp;
    public float timeTemp;

    public Transform collider2d;

    public AudioSource som;
    public AudioClip soundJump;
    public AudioClip soundSlide;

    public static int point;
    public UnityEngine.UI.Text txtPontos;


    // Start is called before the first frame update
    void Start()
    {
        point = 0;
    }

    // Update is called once per frame
    void Update()
    {
        txtPontos.text = point.ToString();

        if (Input.GetButtonDown("Jump") && grounded)
        {
            playerRigidbody.AddForce(new Vector2(0, forceJump));
            som.PlayOneShot(soundJump);
            som.volume = 1;
            jump = true;
            if (slide)
            {
                collider2d.position = new Vector3(collider2d.position.x, collider2d.position.y + 0.3f, collider2d.position.z);
            }
            slide = false;
            
        }
        if (Input.GetButtonDown("Slide") && grounded && !slide)
        {
            collider2d.position = new Vector3(collider2d.position.x, collider2d.position.y - 0.3f, collider2d.position.z);
            som.PlayOneShot(soundSlide);
            som.volume = 0.5f;
            
            slide = true;
            timeTemp = 0;
            
        }
        grounded = Physics2D.OverlapCircle(groundCheck.position, 0.2f, whatIsGround);

        if (slide)
        {
            timeTemp += Time.deltaTime;
            if(timeTemp >= slideTemp)
            {
                collider2d.position = new Vector3(collider2d.position.x, collider2d.position.y + 0.3f, collider2d.position.z);
                slide = false;
            }
        }

        anime.SetBool("jump", !grounded);
        anime.SetBool("slide", slide);
       
    }

    [System.Obsolete]
    private void OnTriggerEnter2D() 
    {
        PlayerPrefs.SetInt("point", point);
        if(point > PlayerPrefs.GetInt("recorde"))
        {
            PlayerPrefs.SetInt("recorde", point);
        }
        Application.LoadLevel("gameover");
            
    }
}
