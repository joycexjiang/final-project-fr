using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Finish : MonoBehaviour
{

    // private AudioSource finishSound;
    private bool levelCompleted = false;

    // Start is called before the first frame update
    void Start()
    {
        // finishSound = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "Player" && !levelCompleted)
        {
            // finishSound.Play();
            levelCompleted = true;
            CompleteLevel();
            Debug.Log("Player has reached the finish line");
        }
    }

    private void CompleteLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        Debug.Log("Level Complete");
    }
}
