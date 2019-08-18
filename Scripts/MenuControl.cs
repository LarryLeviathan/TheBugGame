using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuControl : MonoBehaviour {
    public int Lev;
    public Renderer rend;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (GameControl.Level < Lev)
        {
            rend = GetComponent<Renderer>();
            rend.enabled = false;
        }
        else
        {
            rend = GetComponent<Renderer>();
            rend.enabled = true;
        }
    }
    public void OnMouseDown()
    {
        if (Lev == -1)
        {
        Destroy (gameObject);
            print("Menu");

        }
        if (Lev == 0)
        {
            SceneManager.LoadScene("Menu", LoadSceneMode.Single);
            print("Menu");

        }
        if (Lev == 1)
        {
            SceneManager.LoadScene("Level1", LoadSceneMode.Single);

        }
        if (Lev == 2)
        {
            SceneManager.LoadScene("Level2", LoadSceneMode.Single);

        }
        if (Lev == 3)
        {
            SceneManager.LoadScene("Level3", LoadSceneMode.Single);

        }
        if (Lev == 4)
        {
           SceneManager.LoadScene("Level4", LoadSceneMode.Single);

        }
        if (Lev == 5)
        {
           SceneManager.LoadScene("Level5", LoadSceneMode.Single);

        }
        if (Lev == 6)
        {
            SceneManager.LoadScene("Level6", LoadSceneMode.Single);

        }
        if (Lev == 7)
        {
            SceneManager.LoadScene("Level7", LoadSceneMode.Single);

        }
        if (Lev == 8)
        {
            SceneManager.LoadScene("Level8", LoadSceneMode.Single);

        }
        if (Lev == 9)
        {
            SceneManager.LoadScene("Level9", LoadSceneMode.Single);

        }
        if (Lev == 10)
        {
            SceneManager.LoadScene("Level10", LoadSceneMode.Single);

        }
    }
}

