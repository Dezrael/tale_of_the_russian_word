using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level
{
    public string name;
    public bool isCompleted;

    public Level(string name)
    {
        this.name = name;
        isCompleted = false;
    }
}

public class LevelsController : MonoBehaviour
{
    public Dictionary<string, Level> levels;

    void Start()
    {
        initLevels();
        DontDestroyOnLoad(gameObject);
    }

    void Update()
    {
        
    }

    public void CompleteLevel(string levelName)
    {
        levels[levelName].isCompleted = true;
    }

    private void initLevels()
    {
        levels = new Dictionary<string, Level>();
        for (int i=1; i<=6; i++)
        {
            levels.Add("level" + Convert.ToString(i), new Level("level" + Convert.ToString(i)));
        }
    }
}
