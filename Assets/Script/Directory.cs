using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Directory : MonoBehaviour
{
    
    public GameObject mine;
    public GameObject home;
    public GameObject bank;
    public GameObject outHouse;
    public GameObject kitchen;

    public static Directory instance;
    // Start is called before the first frame update
    void Awake()
    {
        instance = this;
    }

    // Update is called once per frame
    void Update()
    {
        
    }


}
