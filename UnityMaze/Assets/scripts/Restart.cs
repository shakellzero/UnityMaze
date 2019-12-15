using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Restart : MonoBehaviour
{
    // Start is called before the first frame update
    public void restart()
    {
        Application.LoadLevel(Application.loadedLevel);
    }
}
