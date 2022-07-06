using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainManager1 : MonoBehaviour
{
    public static MainManager1 Instance;

    private void Awake()
    {
        Instance = this;
        DontDestroyOnLoad(gameObject);
    }
}
