using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEditor.Experimental.GraphView;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameControl : MonoBehaviour
{
    public static GameControl instance;
    public GameObject gameOverTextTMPro;
    public TextMeshProUGUI ScoreText;
    public GameObject DeathText;
    public bool gameOver = false;
    public float scrollSpeed = -1.5f;

    private int score = 0;
    // Start is called before the first frame update
    void Awake()
    {
        if (instance == null)
        {
            instance = this;
        } else if (instance != this)
        {
            Destroy (gameObject);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (gameOver == true && Input.GetMouseButtonDown (0))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene ().buildIndex);
        }
    }
    public void BirdScored()
    {
        if (gameOver)
        {
            return;
        }
        score++;
        ScoreText.text = "Score: " + score.ToString (); 
    }
    public void BridDied()
    {
        gameOverTextTMPro.SetActive (true);
        DeathText.SetActive(true);
        gameOver = true;
    }
}