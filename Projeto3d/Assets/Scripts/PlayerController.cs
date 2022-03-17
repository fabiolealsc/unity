using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float forceJump;
    private Animator anim;
    private float horizontalMove, verticalMove;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        horizontalMove = Input.GetAxisRaw("Horizontal");
        verticalMove = Input.GetAxisRaw("Vertical");
        anim.SetFloat("horizontalMove", horizontalMove);
        anim.SetFloat("verticalMove", verticalMove);
    }
}
