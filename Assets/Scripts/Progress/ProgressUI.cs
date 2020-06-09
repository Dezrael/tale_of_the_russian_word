using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProgressUI : MonoBehaviour
{
    [SerializeField]
    private GameObject statsPanel;
    [SerializeField]
    private GameObject achievementsPanel;

    void Start()
    {
        ShowStat();
    }

    public void ShowStat()
    {
        statsPanel.SetActive(true);
        achievementsPanel.SetActive(false);
    }

    public void ShowAchievements()
    {
        statsPanel.SetActive(false);
        achievementsPanel.SetActive(true);
    }

}
