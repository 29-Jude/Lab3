using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class BasketMovementScript : MonoBehaviour
{
    public float speed;
    public float Points;
    public float ScoreToWin;
    public string SceneToLoad;

    public Text Pointsystem;

    public AudioClip[] audios;

    public float Timer;
    public Text TimerText;
   
    // Start is called before the first frame update
    void Start()
    {
        Pointsystem.text = "Points: " + Points;
        TimerText.text = "Time Taken: " + Timer;
    }

    // Update is called once per frame
    void Update()
    {
      float horizontalInput = Input.GetAxis("Horizontal");
      transform.position = transform.position + new Vector3(horizontalInput * speed * Time.deltaTime, 0, 0);

      Pointsystem.text = "Points: " + Points;

      if(Points >= ScoreToWin)
      {
            SceneManager.LoadScene(SceneToLoad);
      }

        TimerText.text = "Time Taken: " + Timer;
        Timer += Time.deltaTime;
    }

    void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Healthy")
        {
            Destroy(collision.gameObject);
            Points += 10;
        }

        else if (collision.gameObject.tag == "Unhealthy")
        {
            Destroy(collision.gameObject);
            SceneManager.LoadScene("Lose");
        }
    }
}
