using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveObjects : MonoBehaviour
{
    public float speed;
    private float x;
    public GameObject Player;
    private bool pontuado;
    // Start is called before the first frame update
    void Start()
    {
        Player = GameObject.Find("Player") as GameObject;
    }

    // Update is called once per frame
    void Update()
    {
        x = transform.position.x;
        x += speed * Time.deltaTime;
        transform.position = new Vector3(x, transform.position.y, transform.position.z);
        if (x < Player.transform.position.x && pontuado == false)
        {
            pontuado = true;
            PlayerController.point++;
        }

        if (x <= -6)
        {
            Destroy(transform.gameObject);
        }
    }
}
