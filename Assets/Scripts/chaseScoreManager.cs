using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class chaseScoreManager : MonoBehaviour
{
    [SerializeField] private float timer = 0.0f;
    [SerializeField] private int score = 0;
    public GameObject scoreboard;

    // Start is called before the first frame update
    void Start()
    {
        if (GameObject.FindGameObjectWithTag("Scoreboard"))
        {
            scoreboard = GameObject.FindGameObjectWithTag("Scoreboard");
        }
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        score = (int)(timer % 60);
        GameManager.gameScore = score;
        scoreboard.GetComponent<TextMeshProUGUI>().text = "Score: " + score.ToString();
    }
}
