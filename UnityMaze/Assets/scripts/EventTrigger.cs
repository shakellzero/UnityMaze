using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class EventTrigger : MonoBehaviour
{
    public GameObject kotak;
    public GameObject[] kotakLokasi;
    private int x;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    private void OnTriggerEnter(Collider apapa)
    {
        Debug.Log(apapa.name);
        if(apapa.name == "chan")
        {
            x = Random.Range(0, kotakLokasi.Length);
            Vector3 newLoc = new Vector3(kotakLokasi[x].transform.position.x, kotakLokasi[x].transform.position.y, kotakLokasi[x].transform.position.z);
            gameObject.transform.position = newLoc;
        }
    }

    void Update()
    {

    }
}
