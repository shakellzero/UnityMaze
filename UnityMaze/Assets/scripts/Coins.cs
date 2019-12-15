using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

//<summary>
//Ball movement controlls and simple third-person-style camera
//</summary>
public class Coins : MonoBehaviour
{
    public GameObject[] coin;
    private AudioSource mAudioSource;

    void Start()
    {
        mAudioSource = GetComponent<AudioSource>();
    }
    void Update()
    {
        coin = GameObject.FindGameObjectsWithTag("Coin");
        if (coin.Length == 0)
        {
            Application.LoadLevel(Application.loadedLevel);
        }
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag.Equals("Coin"))
        {
            mAudioSource.Play();
            Destroy(other.gameObject);
        }
    }
}