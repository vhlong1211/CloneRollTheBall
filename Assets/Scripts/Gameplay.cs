using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.SceneManagement;


public class Gameplay : MonoBehaviour
{   

    //for debug
    //public GameObject dbps;

    GameObject tempCell;
    GameObject swapCell;
    Point tempArrayPos;
    Point tempSwapPos;

    public int[,] Map ;
    public Point[][] Path ;
    public int[][] pathvalue;
    public static int chosenPath=0;

    bool clickHit = false;

    Vector3 mouseDownPos,mouseUpPos;
    Vector2 xAxis = new Vector2(1,0);

    Stack oldCellStack = new Stack();
    Stack newCellStack = new Stack();
    Stack oldCellPosStack = new Stack();
    Stack newCellPosStack = new Stack();
    
    // Start is called before the first frame update
    void Start()
    {

        int sceneIndex = SceneManager.GetActiveScene().buildIndex;
        Map = DataConfig.mapAllLevel[sceneIndex].Clone() as int[,];
        Point[][] tempPath = DataConfig.pathAllLevel[sceneIndex];
        Path = tempPath.Clone() as Point[][];
        int[][] tempPathValue = DataConfig.pathValueAllLevel[sceneIndex];
        pathvalue = tempPathValue.Clone() as int[][];
    }

    // Update is called once per frame
    void Update()
    {   
        if(BallControl.isStartMoving)   return;
        if( Input.GetMouseButtonDown(0) )
        {
            Ray ray = Camera.main.ScreenPointToRay( Input.mousePosition );
            
            RaycastHit hit;
            Debug.Log("Enter mouse down");
            if( Physics.Raycast( ray, out hit, 100 ) )
            {   
                Debug.Log("rayorigin:"+ray.origin);
                Debug.Log("position hit:"+hit.transform.position+"===name hit:"+hit.transform.name+"===tag hit:"+hit.transform.tag);
                Debug.DrawLine( ray.origin, ray.origin + ray.direction * 100, Color.green);
                Debug.Log("Check hit 0");
                if(hit.transform.gameObject.tag == "Ground" || hit.transform.gameObject.tag == "Concrete")    return;
                Debug.Log("Check hit 1");
                if(hit.transform.parent.gameObject.tag == "Concrete")    return;
                tempCell = hit.transform.parent.gameObject;
                Debug.Log( "mousePosDown:"+Input.mousePosition );
                //Debug.Log( hit.transform.gameObject.name );
                clickHit = true;
                mouseDownPos = Input.mousePosition;
                tempArrayPos = GetPosFromPoint(hit.transform.position.x,hit.transform.position.z);
                //Debug.Log("xPos:"+arrayPos.x+"/zPos:"+arrayPos.y);
            }
        }

        //check mouse length
        CheckMouseFarAway();


        if (Input.GetMouseButtonUp (0))
        {
            if(clickHit == false)   return;
            clickHit = false;
            Debug.Log("mousePosUp"+Input.mousePosition);
            mouseUpPos = Input.mousePosition;
            Vector2 direct = new Vector2(mouseUpPos.x - mouseDownPos.x,mouseUpPos.y - mouseDownPos.y);
            if(direct.magnitude == 0) return;
            float angleDiff = Vector2.Angle(xAxis,direct);
            Debug.Log("Angle:"+angleDiff);
            Direction aimTo = GetDirectionFromVector(angleDiff);
            if(aimTo == Direction.Stay)     return;
            Debug.Log(aimTo);
            SwapPosition(aimTo);
                
        }
    }

    //Check if can swapposition before mouse up
    void CheckMouseFarAway(){
        if(clickHit == false)   return;
        Vector3 currentMousePos = Input.mousePosition;
        Vector2 currentDirect = new Vector2(currentMousePos.x - mouseDownPos.x,currentMousePos.y - mouseDownPos.y);
        if(currentDirect.magnitude < 50f){
            //Debug.Log("length:"+currentDirect.magnitude);
            return;
        }    
        clickHit = false;
        mouseUpPos = Input.mousePosition;
        float angleDiff = Vector2.Angle(xAxis,currentDirect);
        Direction aimTo = GetDirectionFromVector(angleDiff);
        if(aimTo == Direction.Stay)     return;
        SwapPosition(aimTo);
    }


    Point GetPosFromPoint(float xPos , float zPos){
        int x=99,z=99;
        if (xPos < 3 && xPos>=0){
            x = 0;
        }else if(xPos < 6){
            x = 1;
        }else if(xPos < 9){
            x = 2;
        }else if(xPos < 12){
            x = 3;
        }
        if (zPos > -3 && zPos <= 0){
            z = 0;
        }else if(zPos > -6){
            z = 1;
        }else if(zPos > -9){
            z = 2;
        }else if(zPos > -12){
            z = 3;
        }
        return new Point(x,z);
    }

    //get direction from vector created by 2 point from mouse
    Direction GetDirectionFromVector(float angle){
        if(angle >= 135){
            return Direction.Left;
        }else if(angle <=45 ){
            return Direction.Right;
        }
        float heightDiff = mouseUpPos.y - mouseDownPos.y;
        if(heightDiff > 0){
            return Direction.Top;
        }else if(heightDiff < 0){
            return Direction.Down;
        }else{
            return Direction.Stay;
        }
    }

    void SwapPosition(Direction direction){
        if(tempCell.tag != "Wood"){
            Debug.Log("check wood"+tempCell.tag);
            return;
        } 
        
        bool isSwap = GetCellFromDirection(direction);
        if(!isSwap){
            Debug.Log("checkswap");
            return;
        } 
        Vector3 bufferPos = tempCell.transform.position;
        tempCell.transform.position = swapCell.transform.position;
        swapCell.transform.position = bufferPos;
        // Debug.Log("ollArrPos:"+tempArrayPos.x+"/"+tempArrayPos.y);
        // Debug.Log("newArrPos:"+tempSwapPos.x+"/"+tempSwapPos.y);
        oldCellStack.Push(tempCell);
        newCellStack.Push(swapCell);
        oldCellPosStack.Push(tempArrayPos);
        newCellPosStack.Push(tempSwapPos);
        Debug.Log("pushstack");
        int tempMapValue = Map[tempArrayPos.y,tempArrayPos.x];
        Map[tempArrayPos.y,tempArrayPos.x] = Map[tempSwapPos.y,tempSwapPos.x];
        Map[tempSwapPos.y,tempSwapPos.x] = tempMapValue;
        for (int i = 0; i < 4; i++)
        {   
            String logDegug="";
            for (int j = 0; j < 4; j++)
            {
                logDegug+=" "+Map[i,j]+" ";
            }
            Debug.Log(logDegug);
        }
        CheckFinish();

    }

    void CheckFinish(){
        //pathvalue
        //path
        bool isFinish = false;
        // for(int i = 0; i <pathvalue.Length;i++){
        //     if(Map[Path[i].x,Path[i].y] != pathvalue[i]){
        //         isFinish = false;
        //         break;
        //     }
        // }
        for(int i = 0 ; i < Path.Length ; i++){
            isFinish = true;
            for(int j = 0 ; j< Path[i].Length ; j++){
                if(Map[Path[i][j].x,Path[i][j].y] != pathvalue[i][j]){
                    isFinish = false;
                    break;
                }
            }
            if(isFinish == true){
                chosenPath = i;
                break;
            } 
        }

        if(isFinish == true){
            BallControl.isStartMoving = true;
            Debug.Log("success");
        }
    }

    //get cell to check can swap from clicked cell 
    bool GetCellFromDirection(Direction direction){
        Vector3 swapPos;
        float rangeCell = 3f;
        Point bufferSwapPos;
        if(direction == Direction.Top){
            swapPos = new Vector3(tempCell.transform.position.x,5f,tempCell.transform.position.z + rangeCell);
            bufferSwapPos.x = tempArrayPos.x ;
            bufferSwapPos.y = tempArrayPos.y -1 ;
        }else if(direction == Direction.Left){
            swapPos = new Vector3(tempCell.transform.position.x - rangeCell,5f,tempCell.transform.position.z );
            bufferSwapPos.x = tempArrayPos.x - 1;
            bufferSwapPos.y = tempArrayPos.y ;
        }else if(direction == Direction.Down){
            swapPos = new Vector3(tempCell.transform.position.x,5f,tempCell.transform.position.z - rangeCell);
            bufferSwapPos.x = tempArrayPos.x ;
            bufferSwapPos.y = tempArrayPos.y + 1;
        }else {
            swapPos = new Vector3(tempCell.transform.position.x + rangeCell,5f,tempCell.transform.position.z );
            bufferSwapPos.x = tempArrayPos.x + 1;
            bufferSwapPos.y = tempArrayPos.y ;
        }

        RaycastHit cellHit;
        if(Physics.Raycast(swapPos,-transform.up,out cellHit,10f)){
            //dbps.transform.position = swapPos;
            Debug.Log("Enter raycast");
            if(cellHit.transform.tag == "Ground" || cellHit.transform.tag == "Concrete")   return false;
            Debug.Log("After check cell");
            //if(cellHit.transform.parent.gameObject.tag == "Concrete")   return;
            if(cellHit.transform.parent.gameObject.tag == "Space"){
                //Debug.Log(cellHit.transform.parent.gameObject.name);
                tempSwapPos = bufferSwapPos;
                swapCell = cellHit.transform.parent.gameObject;
                return true;
            }
        }
        return false;
    }

    //for replay 1 move
    public void MoveBackTime(){
        if(BallControl.isStartMoving)   return;
        if(oldCellStack.Count == 0) return;
        GameObject oldCellBack = (GameObject)oldCellStack.Pop();
        GameObject newCellBack = (GameObject)newCellStack.Pop();
        Point oldPosBack =(Point) oldCellPosStack.Pop();
        Point newPosBack =(Point) newCellPosStack.Pop();
        Vector3 bufferOb;

        bufferOb = oldCellBack.transform.position;
        oldCellBack.transform.position = newCellBack.transform.position;
        newCellBack.transform.position = bufferOb;

        int tempMapValue = Map[oldPosBack.y,oldPosBack.x];
        Map[oldPosBack.y,oldPosBack.x] = Map[newPosBack.y,newPosBack.x];
        Map[newPosBack.y,newPosBack.x] = tempMapValue;

    }   

}


public enum Direction{
    Top,
    Left,
    Down,
    Right,
    Stay
}