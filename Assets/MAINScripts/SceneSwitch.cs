//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwitch : MonoBehaviour
{
    public Raycast left_cast;
   // public Raycast right_cast;
    //Buttons on top of each text, on trigger button switch scene

    // Start is called before the first frame update
    void Start()
    {
        
    }
    public void SwitchingScene() {
        if (left_cast.TouchingTravel()&& SceneManager.GetActiveScene().name == "Beach1")
        {
            SceneManager.LoadScene("Bamboo1", LoadSceneMode.Single);
        }
        if (left_cast.TouchingTravel() && SceneManager.GetActiveScene().name == "Bamboo1")
        {
            SceneManager.LoadScene("Beach1", LoadSceneMode.Single);
        }
    }

    // Update is called once per frame
    void Update()
    {
      
    }
}
