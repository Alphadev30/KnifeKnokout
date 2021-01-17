using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class KnifeSpawnner : MonoBehaviour
{
    public Transform spawnPoint;
    public GameObject KnifePrefab;

    private Text scoreText;
    private int score;

    void Awake()
    {
        scoreText = GameObject.Find("ScoreText").GetComponent<Text>();
    }

    public void SpawnKnife()
    {
        GameObject go = Instantiate(KnifePrefab, spawnPoint.position, spawnPoint.rotation);
        go.transform.parent = spawnPoint;
    }

    public void IncrementScore()
    {
        score++;
        scoreText.text = score.ToString();
    }
}
