using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveOffset : MonoBehaviour
{
    private Material currentMaterial;
    public float speed;
    private float offSet;
    // Start is called before the first frame update
    void Start()
    {
        currentMaterial = GetComponent<Renderer>().material;
    }

    // Update is called once per frame
    void Update()
    {
        offSet += speed * Time.deltaTime;
        currentMaterial.SetTextureOffset("_MainTex", new Vector2(offSet, 0));
    }
}
