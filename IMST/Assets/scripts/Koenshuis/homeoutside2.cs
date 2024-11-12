using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;



public class homeoutside2 : MonoBehaviour
{
    void OnTriggerEnter() {
        SceneManager.LoadScene("outsidesunday1.1", LoadSceneMode.Single);
        Debug.Log ("Trigger");
    }

}
