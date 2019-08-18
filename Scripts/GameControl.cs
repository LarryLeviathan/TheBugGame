using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

[RequireComponent(typeof(AudioSource))]
public class GameControl : MonoBehaviour
{
    public static int lives = 10;
    public int Life = lives;
    public static int Level = 1;
    public AudioClip DeadFly;
    AudioSource audioSource;
    //  public static int Money;
    // Use this for initialization
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }


    // Update is called once per frame
    void Update()
    {
        if(BeetleControl.Die == true)
        {
            audioSource.PlayOneShot(DeadFly, 1F);
            BeetleControl.Die = false;
        }
        int BugsLeft = GameObject.FindGameObjectsWithTag("EnemyBug").Length;
        Scene currentScence = SceneManager.GetActiveScene();
        string sceneName = currentScence.name;
        Life = lives;
        lives = Life;
        if (lives > 10)
        {

            lives = 9;
            lives++;
            lives++;




        }
        if (lives <= 0)
        {
            lives = 10;
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            print("reset");
            lives = 10;

        }
        if (sceneName == "Level1")
        {
            /* if (lives <= 0)
             {
                 SceneManager.LoadScene(SceneManager.GetActiveScene().name);
             }
             */
            if (BugsLeft == 0)
            {
                SceneManager.LoadScene("Level2", LoadSceneMode.Single);
                lives = 10;
                if (Level < 2)
                {
                    Level = 2;
                    print("Next");

                }
            }
        }
        if (sceneName == "Level2")
        {

            if (BugsLeft == 0)
            {
                lives = 10;

                SceneManager.LoadScene("Level3", LoadSceneMode.Single);
                if (Level < 3)
                {
                    print("Next");

                    Level = 3;
                }
            }
        }
        if (sceneName == "Level3")
        {

            if (BugsLeft == 0)
            {
                if (Level < 4)
                    Level = 4;
                print("Level4");
                lives = 10;

                SceneManager.LoadScene("Level4", LoadSceneMode.Single);
            }
        }
        if (sceneName == "Level4")
        {

            if (BugsLeft == 0)
            {
                if (Level < 5)
                    Level = 5;
                print("Level5");
                lives = 10;

                SceneManager.LoadScene("Level5", LoadSceneMode.Single);
            }

        }
        if (sceneName == "Level5")
        {

            if (BugsLeft == 0)
            {
                if (Level < 5)
                    Level = 5;
                print("Level6");
                lives = 10;

                SceneManager.LoadScene("Level6", LoadSceneMode.Single);
            }

        }
    }
}

    

        
	

