using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameOver : MonoBehaviour
{
    public UnityEngine.UI.Text pontos;
    public UnityEngine.UI.Text recordes;
    // Start is called before the first frame update
    void Start()
    {
        pontos.text = PlayerPrefs.GetInt("point").ToString();
        recordes.text = PlayerPrefs.GetInt("recorde").ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
