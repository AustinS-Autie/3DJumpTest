using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundInfo : MonoBehaviour
{
    int colDist = 5;
    int jump = 10;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Ray r = new Ray(transform.position, Vector3.down);

        Debug.DrawLine(r.origin, r.origin + (Vector3.down * colDist));

        RaycastHit hit;

        if (Physics.Raycast(r, out hit, colDist))
        {
            Debug.Log(hit.transform.name);

            if (hit.transform.GetComponent<GroundInfo>() != null)
            {
                jump = 0;
            }
        }
    }
}
