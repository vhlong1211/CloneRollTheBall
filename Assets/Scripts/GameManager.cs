using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{   
    [SerializeField] GameObject gameOverMenu;
    
    // Start is called before the first frame update
    void Start()
    {
        gameOverMenu.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public static void ReloadScene(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public static void NextScene(){
        int nextScene = SceneManager.GetActiveScene().buildIndex+1;
        if(nextScene == 30){
            nextScene = 0;
        }      
        SceneManager.LoadScene(nextScene);
    }

}
