using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenu : MonoBehaviour
{
    //string scenceName;

    public void ChangeScene(string scenceName)
    {
        Application.LoadLevel(scenceName);
    }

    public void quitMenu()
    {
        Application.Quit();
    }
}
