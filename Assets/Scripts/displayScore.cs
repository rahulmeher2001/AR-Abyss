using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class displayScore : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GameObject.FindGameObjectWithTag("Scoreboard").GetComponent<TextMeshProUGUI>().text = "Score: " + GameManager.gameScore.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
