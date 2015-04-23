using UnityEngine;
using System.Collections;

public class DontDestroyMusic : MonoBehaviour {

    public GameObject Music;
    void Start()
    {
        DontDestroyOnLoad(this.gameObject);
    }
 }

