using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Goal : MonoBehaviour
{
    bool collected = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (SceneManager.GetActiveScene().buildIndex == 3)
            Debug.Log("Your final score: " + GameManager.managerInstance.GetScore() );
        else
            if (!collected && GameManager.managerInstance.GetCoinsRemaining()==0)
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
                GameManager.managerInstance.AddScore(SceneManager.GetActiveScene().buildIndex + 1);
                Debug.Log("Score is " + GameManager.managerInstance.GetScore() + " for clearing the room");
                collected = true;
            }
    }
}
