using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class BallControl : MonoBehaviour
{   
    [SerializeField] GameObject gameOverMenu;
    //Transform carModel;
    Point[][] tempPath;
    RaycastHit hit;
    public static bool isStartMoving = false;
    int indexDes = 0;
    float threshold = 0.1f;
    void Start()
    {   
        // carModel = gameObject.transform.GetChild(0);
        int sceneIndex = SceneManager.GetActiveScene().buildIndex;
        isStartMoving = false;
        tempPath = DataConfig.pathAllLevel[sceneIndex];
        if( Physics.Raycast( gameObject.transform.position,-transform.up, out hit, 10f ) ){
            //Debug.Log(gameObject.transform.GetChild(0).name);
            gameObject.transform.eulerAngles = new Vector3(0, hit.transform.eulerAngles.y+180, 0);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if(!isStartMoving)  return;
        MoveToNewFormation();

    }

    private void MoveToNewFormation()
    {
        float step = 5f * Time.deltaTime;
        Vector3 currentDes = new Vector3(1.5f+3f*tempPath[Gameplay.chosenPath][indexDes].y,0.5f,-1.5f-3f*tempPath[Gameplay.chosenPath][indexDes].x);
        gameObject.transform.position = 
        Vector3.MoveTowards(gameObject.transform.position, currentDes, step);
        gameObject.transform.LookAt(currentDes);
        if(Vector3.Distance(gameObject.transform.position,currentDes)<threshold){
            if(indexDes<tempPath[Gameplay.chosenPath].Length-1){
                indexDes++;
            }else{
                gameOverMenu.SetActive(true);
                //isStartMoving = false;
            }
        }
    }
}
