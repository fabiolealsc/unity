using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnController : MonoBehaviour
{

    public GameObject blockPrefab; //Objeto a ser spawnado
    public float rateSpawn;
    private float currentTime;
    private int position;
    private float y;
    public float posA;
    public float posB;

    // Start is called before the first frame update
    void Start()
    {
        currentTime = 0;
    }

    // Update is called once per frame
    void Update()
    {
        currentTime += Time.deltaTime;
        if (currentTime > rateSpawn)
        {
            currentTime = 0;
            position = Random.Range(1, 100);
            if (position > 50)
            {
                y = posA;
            }
            else
            {
                y = posB;
            }
            GameObject temPrefab = Instantiate(blockPrefab) as GameObject;
            temPrefab.transform.position = new Vector3(transform.position.x, y, temPrefab.transform.position.z);
        }
    }
}
