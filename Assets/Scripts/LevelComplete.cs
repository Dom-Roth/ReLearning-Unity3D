using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelComplete : MonoBehaviour
{
    public int importedCoins;
    
    public GameObject completedText;
    public GameObject fadeOut;
    public GameObject player;
    
    void Update()
    {
        importedCoins = GlobalCoins.coinCount;
        if (importedCoins == 5)
        {
            StartCoroutine(LevelCompleted());
        }
    }

    IEnumerator LevelCompleted()
    {
        yield return new WaitForSeconds(0.2f);
        completedText.SetActive(true);
        fadeOut.SetActive(true);
        player.GetComponent<PlayerControls>().enabled = false;
        yield return new WaitForSeconds(3);
        
    }
}
