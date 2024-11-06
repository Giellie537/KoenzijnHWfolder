using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OnTrigger : MonoBehaviour

{
    

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("car"))
        {
            SceneManager.LoadScene("supermaketnaauto", LoadSceneMode.Single);
            
            Debug.Log ("Trigger");
    }
        }

    }


  

