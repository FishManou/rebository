using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIHandler : MonoBehaviour
{
    // Start is called before the first frame update
    public void StartNow()
    {
        SceneManager.LoadScene(1);
    }

    // Update is called once per frame
    public void ExitNow()
    {
        Application.Quit();
    }
}
