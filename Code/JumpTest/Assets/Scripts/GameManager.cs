using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager managerInstance;
    public int score;
    public int coinsRemaining;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Collect all of the coins to advance to the next room");
        if (managerInstance == null)
        {
            managerInstance = this;
        }

        if (managerInstance != this)
            Destroy(gameObject);

        DontDestroyOnLoad(gameObject);
    }

    void OnCreate()
    {
        coinsRemaining = 0;
        score = 0;

    }
    
    // Update is called once per frame
    void Update()
    {
        
    }

    public void AddScore(int amount)
    {
        score += amount;
    }

    public void SetScore(int amount)
    {
        score = amount;
    }

    public int GetScore()
    {
        return score;
    }

    public int GetCoinsRemaining()
    {
        return coinsRemaining;
    }

    public void AddCoinsRemaining(int amount)
    {
        coinsRemaining += amount;
    }
}
