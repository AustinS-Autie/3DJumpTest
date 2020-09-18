using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartRoom : MonoBehaviour
{
    bool activated = false;
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

        if (!activated)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);

            if (GameManager.managerInstance.score >= 3)
                GameManager.managerInstance.AddScore(-3);
            else
                GameManager.managerInstance.SetScore(0);

            Debug.Log("Score reduced to " + GameManager.managerInstance.GetScore() + " for falling off");
            activated = true;
        }

    }
}
