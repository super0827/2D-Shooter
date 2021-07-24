using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class positionchecker : MonoBehaviour
{
    public UIManager uiManager = null;
    public int gameVictoryPageIndex = 0;
    public GameObject victoryEffect;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
         if (transform.position.x < -25 && transform.position.y > 7) 
        {
             uiManager.GoToPage(gameVictoryPageIndex);
            if (victoryEffect != null)
            {
                Instantiate(victoryEffect, transform.position, transform.rotation, null);
            }

        }
    }
}
