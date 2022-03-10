using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class KeepingScore : MonoBehaviour
{
    public static int Score = 0;
    //public Text
    public GameObject changingText;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        changingText.GetComponent<Text>().text = Score.ToString();
        //Score.ToString();
    }
}
