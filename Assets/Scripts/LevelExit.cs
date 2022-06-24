using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelExit : MonoBehaviour {

    [SerializeField] float delayBeforeTheLeveLoad = 2f;
    [SerializeField] float slowMotionEffect = 0.2f;

    void OnTriggerEnter2D(Collider2D other)
    {
        StartCoroutine(LoadNextLevel());
    }
    //co-routineß
    IEnumerator LoadNextLevel()
    {
        Time.timeScale = slowMotionEffect;
        yield return new WaitForSecondsRealtime(delayBeforeTheLeveLoad);
        Time.timeScale = 1f;
        
        var currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(currentSceneIndex + 1);
    }

}
