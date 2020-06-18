using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TheoryUI : MonoBehaviour
{
    [SerializeField]
    private GameObject theoryPanel;
    [SerializeField]
    private GameObject practicePanel;

    void Start()
    {
        ShowTheory();
    }

    public void ShowTheory()
    {
        theoryPanel.SetActive(true);
        practicePanel.SetActive(false);
    }

    public void ShowPractice()
    {
        theoryPanel.SetActive(false);
        practicePanel.SetActive(true);
    }

}
