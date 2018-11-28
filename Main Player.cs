using UnityEngine;
using System.Collections;

public class MainPlayer : MonoBehavior {

    // Use this for initilalization
    void Start () {
        GameObject frog = (GameObject)Instantiate(Resources.Load("frog"));
    }

    //Update is called once per frame
    void Update () {

    }
}
