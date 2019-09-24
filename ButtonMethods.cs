using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; 

public class ButtonMethods : MonoBehaviour
{
    [SerializeField] GameObject MainMenu;
    [SerializeField] GameObject HowToPlayMenu;
    [SerializeField] GameObject BasicInfoMenu;
    [SerializeField] GameObject BasicInfoNextButton; 
    [SerializeField] GameObject PowerUpInfoMenu;
    [SerializeField] GameObject ControlsMenu; 
    [SerializeField] GameObject BasicInfoMenuTextOneA;
    [SerializeField] GameObject BasicInfoMenuTextOneB;
    [SerializeField] GameObject BasicInfoMenuTextTwoA;
    [SerializeField] GameObject BasicInfoMenuTextTwoB;
    [SerializeField] GameObject BasicInfoMenuTextTwoC;
    [SerializeField] GameObject BasicInfoMenuTextTwoD;
    [SerializeField] GameObject BasicInfoMenuTextTwoE;

    public void CloseGame()
    {
        //closes app. 
        Application.Quit(); 
    }

    public void LoadLevelOne()
    {
        //loads scene "levelOne". 
        SceneManager.LoadScene("LevelOne"); 
    }

    public void HowToPlay()
    {
        MainMenu.SetActive(false);
        HowToPlayMenu.SetActive(true); 
    }

    public void BasicInfo()
    {
        HowToPlayMenu.SetActive(false);
        BasicInfoMenu.SetActive(true);
        BasicInfoNextButton.SetActive(true); 
        BasicInfoMenuTextOneA.SetActive(true);
        BasicInfoMenuTextOneB.SetActive(true);
        BasicInfoMenuTextTwoA.SetActive(false);
        BasicInfoMenuTextTwoB.SetActive(false);
        BasicInfoMenuTextTwoC.SetActive(false);
        BasicInfoMenuTextTwoD.SetActive(false);
        BasicInfoMenuTextTwoE.SetActive(false); 
    }

    public void BasicInfoTwo()
    {
        BasicInfoMenuTextOneA.SetActive(false);
        BasicInfoMenuTextOneB.SetActive(false);
        BasicInfoNextButton.SetActive(false); 
        BasicInfoMenuTextTwoA.SetActive(true);
        BasicInfoMenuTextTwoB.SetActive(true);
        BasicInfoMenuTextTwoC.SetActive(true);
        BasicInfoMenuTextTwoD.SetActive(true);
        BasicInfoMenuTextTwoE.SetActive(true);
    }

    public void BackToMainMenu()
    {
        MainMenu.SetActive(true); 
        HowToPlayMenu.SetActive(false);
        BasicInfoMenu.SetActive(false);
        PowerUpInfoMenu.SetActive(false);
        ControlsMenu.SetActive(false); 
    }

    public void PowerUpInfoMenuStart()
    {
        HowToPlayMenu.SetActive(false);
        PowerUpInfoMenu.SetActive(true); 
    }

    public void Controls()
    {
        HowToPlayMenu.SetActive(false);
        ControlsMenu.SetActive(true); 
    }
}
