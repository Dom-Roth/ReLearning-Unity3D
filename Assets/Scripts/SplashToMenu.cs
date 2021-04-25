using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SplashToMenu : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(ProceedToMenu());
    }

    IEnumerator ProceedToMenu()
    {
        yield return new WaitForSeconds(4.5f);
        SceneManager.LoadScene(1);
    }
}
