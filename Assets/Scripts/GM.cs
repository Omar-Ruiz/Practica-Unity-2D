using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class GM : MonoBehaviour
{
    [SerializeField] GameObject panelGameOver;

    [SerializeField] Player player;

    public bool gameOver = false;

    float score = -1, scoreOffset = 0;

    [SerializeField] TextMeshProUGUI scoreText;

    
    void Awake()
    {
        scoreOffset = (int)player.gameObject.transform.position.x;
        
    }

    // Update is called once per frame
    void Update()
    {
        if (gameOver)
        {
            panelGameOver.SetActive(true);
        }
        else
        {
            score = (int)(player.transform.position.x - scoreOffset);
            scoreText.text ="" + score;
        }
        
    }
    public void Reset()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name); //Obtiene nombre actual
    }
}
