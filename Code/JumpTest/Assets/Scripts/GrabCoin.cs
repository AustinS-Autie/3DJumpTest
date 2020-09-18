using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrabCoin : MonoBehaviour
{
    private bool collected = false;
    // Start is called before the first frame update
    void Start()
    {
        GameManager.managerInstance.AddCoinsRemaining(1);  
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (!collected)
        {
            GameManager.managerInstance.AddScore(1);
            GameManager.managerInstance.AddCoinsRemaining(-1);
            Debug.Log("Score is " + GameManager.managerInstance.GetScore() + " after collecting a coin" + "\n" +
            "Coins remaining on this level: " + GameManager.managerInstance.GetCoinsRemaining() );

            collected = true;
            Destroy(gameObject);
        }


    }
}
