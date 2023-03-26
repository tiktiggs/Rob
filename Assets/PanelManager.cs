using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanelManager : MonoBehaviour
{
    public GameObject Menu;
    public GameObject Levels;
    public GameObject Level1;
    public GameObject Level2;
    public GameObject Level3;

    public GameObject WinScreen1;
    public GameObject WinScreen2;
    public GameObject WinScreen3;

    public GameObject hint1;
    public GameObject hint2;
    public GameObject hint3;
    public GameObject hint4;
    public GameObject hint5;
    public GameObject hint6;

    public GameObject Tutorials;
    int levelNum;
    bool gameStarted;
    // Start is called before the first frame update
    void Start()
    {
        gameStarted = false;
        levelNum = 1;
        Menu.SetActive(true);
        Levels.SetActive(false);
        Level1.SetActive(false);
        Level2.SetActive(false);
        Level3.SetActive(false);
        WinScreen1.SetActive(false);
        WinScreen2.SetActive(false);
        WinScreen3.SetActive(false);

        hint1.SetActive(false);
        hint2.SetActive(false);
        hint3.SetActive(false);
        hint4.SetActive(false);
        hint5.SetActive(false);
        hint6.SetActive(false);

        maqrich.clean = false;
        plombich.clean = false;
        sevmqrich.clean = false;
        SevMaqrich2.clean = false;
        shipci.clean = false;
        caries.clean = false;
        maqrich.cleanJur = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(maqrich.clean == true && plombich.clean == true && (sevmqrich.clean == true || SevMaqrich2.clean == true) && shipci.clean == true && maqrich.cleanJur == true && caries.clean == true)
        {
            if (levelNum == 1)
            {
                WinScreen1.SetActive(true);
            }
            if (levelNum == 2)
            {
                WinScreen2.SetActive(true);
            }
            if (levelNum == 3)
            {
                WinScreen3.SetActive(true);
            }
            hint1.SetActive(false);
            hint2.SetActive(false);
            hint3.SetActive(false);
            hint4.SetActive(false);
            hint5.SetActive(false);
            hint6.SetActive(false);
        }
        if (maqrich.clean == false && plombich.clean == false && sevmqrich.clean == false && SevMaqrich2.clean == false && shipci.clean == false && caries.clean == false && maqrich.cleanJur == false && gameStarted == true)
        {
            hint1.SetActive(true);
            hint2.SetActive(false);
            hint3.SetActive(false);
            hint4.SetActive(false);
            hint5.SetActive(false);
            hint6.SetActive(false);
        }
        if (maqrich.clean == false && plombich.clean == false && sevmqrich.clean == false && SevMaqrich2.clean == false && shipci.clean == true && caries.clean == false && maqrich.cleanJur == false)
        {
            hint1.SetActive(false);
            hint2.SetActive(true);
            hint3.SetActive(false);
            hint4.SetActive(false);
            hint5.SetActive(false);
            hint6.SetActive(false);
        }
        if (maqrich.clean == false && plombich.clean == false && (sevmqrich.clean == true || SevMaqrich2.clean == true) && shipci.clean == true && caries.clean == false && maqrich.cleanJur == false)
        {
            hint1.SetActive(false);
            hint2.SetActive(false);
            hint3.SetActive(true);
            hint4.SetActive(false);
            hint5.SetActive(false);
            hint6.SetActive(false);
        }
        if (maqrich.clean == false && plombich.clean == false && (sevmqrich.clean == true || SevMaqrich2.clean == true) && shipci.clean == true && caries.clean == true && maqrich.cleanJur == false)
        {
            hint1.SetActive(false);
            hint2.SetActive(false);
            hint3.SetActive(false);
            hint4.SetActive(true);
            hint5.SetActive(false);
            hint6.SetActive(false);
        }
        if (maqrich.clean == false && plombich.clean == true && (sevmqrich.clean == true || SevMaqrich2.clean == true) && shipci.clean == true && caries.clean == true && maqrich.cleanJur == false)
        {
            hint1.SetActive(false);
            hint2.SetActive(false);
            hint3.SetActive(false);
            hint4.SetActive(false);
            hint5.SetActive(true);
            hint6.SetActive(false);
        }
        if (maqrich.clean == true && plombich.clean == true && (sevmqrich.clean == true || SevMaqrich2.clean == true) && shipci.clean == true && caries.clean == true && maqrich.cleanJur == false)
        {
            hint1.SetActive(false);
            hint2.SetActive(false);
            hint3.SetActive(false);
            hint4.SetActive(false);
            hint5.SetActive(false);
            hint6.SetActive(true);
        }


    }
    public void GoToMenu()
    {
        Menu.SetActive(true);
        Levels.SetActive(false);
        Level1.SetActive(false);
        Level2.SetActive(false);
        Level3.SetActive(false);
        WinScreen1.SetActive(false);
        WinScreen2.SetActive(false);
        WinScreen3.SetActive(false);
        Tutorials.SetActive(false);

    }
    public void GoToLevels()
    {
        Menu.SetActive(false);
        Levels.SetActive(true);
        Level1.SetActive(false);
        Level2.SetActive(false);
        Level3.SetActive(false);
        WinScreen1.SetActive(false);
        WinScreen2.SetActive(false);
        WinScreen3.SetActive(false);
        Tutorials.SetActive(false);
    }
    public void GoToLevel1()
    {
        gameStarted = true;
        maqrich.clean = false;
        plombich.clean = false;
        sevmqrich.clean = false;
        SevMaqrich2.clean = false;
        shipci.clean = false;
        caries.clean = false;
        maqrich.cleanJur = false;
        levelNum = 1;
        Menu.SetActive(false);
        Levels.SetActive(false);
        Level1.SetActive(true);
        Level2.SetActive(false);
        Level3.SetActive(false);
        WinScreen1.SetActive(false);
        WinScreen2.SetActive(false);
        WinScreen3.SetActive(false);
        Tutorials.SetActive(true);
    }
    public void GoToLevel2()
    {
        gameStarted = true;
        maqrich.clean = false;
        plombich.clean = false;
        sevmqrich.clean = false;
        SevMaqrich2.clean = false;
        shipci.clean = false;
        caries.clean = false;
        maqrich.cleanJur = false;
        levelNum = 2;
        Menu.SetActive(false);
        Levels.SetActive(false);
        Level1.SetActive(false);
        Level2.SetActive(true);
        Level3.SetActive(false);
        WinScreen1.SetActive(false);
        WinScreen2.SetActive(false);
        WinScreen3.SetActive(false);
        Tutorials.SetActive(true);
    }
    public void GoToLevel3()
    {
        gameStarted = true;
        maqrich.clean = false;
        plombich.clean = false;
        sevmqrich.clean = false;
        SevMaqrich2.clean = false;
        shipci.clean = false;
        caries.clean = false;
        maqrich.cleanJur = false;
        levelNum = 3;
        Menu.SetActive(false);
        Levels.SetActive(false);
        Level1.SetActive(false);
        Level2.SetActive(false);
        Level3.SetActive(true);
        WinScreen1.SetActive(false);
        WinScreen2.SetActive(false);
        WinScreen3.SetActive(false);
        Tutorials.SetActive(true);
    }

}
