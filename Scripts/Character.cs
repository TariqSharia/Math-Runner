using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Character : MonoBehaviour
{

    float playerSpeed=0.2f;
    public GameObject mainCamera;
    public GameObject road;
    Text currentEquation;
    Text scoreTxt;

    int score=0;
    int bestScore;

    // Start is called before the first frame update
    void Start(){
        scoreTxt=GameObject.Find("Score").GetComponent<Text>(); 
        scoreTxt.text= ""+score;
        currentEquation=GameObject.Find("CurrentEquation").GetComponent<Text>(); 
        currentEquation.text= (string)Logic.q.Dequeue();
        bestScore=PlayerPrefs.GetInt("BestScore", 0);
    }

    // Update is called once per frame
    void Update(){
        scoreTxt.text= "Score is: "+score;
    }

    void FixedUpdate(){
        transform.Translate(0f,0f,playerSpeed);
        mainCamera.transform.Translate(0f,0f,playerSpeed);
        Moving();
        //MovingMobile();
    }

    void Moving(){
        if(Input.GetKey(KeyCode.LeftArrow)){
            if(transform.position.x>-2){
              transform.Translate(-1.1f,0f,0f);
              
            }
        }
        if(Input.GetKey(KeyCode.RightArrow)){
            if(transform.position.x<2){
              transform.Translate(0.035f,0f,0f);              
            }
        }
    }

        void MovingMobile(){
            if (Input.touchCount > 0 && Input.touches[0].phase == TouchPhase.Began)
            {
             Vector2 touch = Input.GetTouch(0).position;
             if (touch.x < Screen.width/2)
             {
                transform.position = new Vector3(-1.1f, transform.position.y, transform.position.z);
            }
             else if (touch.x > Screen.width/2)
             {
                transform.position = new Vector3(1.1f, transform.position.y, transform.position.z);
            }
            }
    }

    void OnCollisionEnter(Collision collision){
        if (collision.gameObject.name == "RoadNext")
        {
            GameObject current = GameObject.Find ("RoadCurrent");
            GameObject next = GameObject.Find ("RoadNext");
            GameObject nextP = GameObject.Find ("RoadNext+");
            if (current){
               StartCoroutine(destroyObject(current));
            }
            next.name="RoadCurrent";
            nextP.name="RoadNext";
            Vector3 position=new Vector3(0,0,nextP.transform.position.z+50);
            GameObject newRoad;
            newRoad=Instantiate(road, position, Quaternion.identity); 
            newRoad.name="RoadNext+";
        }
    }

    void OnTriggerEnter(Collider other){
        if (other.transform.gameObject.tag == "Wrong"){
            this.GetComponent<Animation>().Play("Dizzy");
            playerSpeed =0;
            currentEquation.text= "You Lose";
            if(score>bestScore){
                bestScore=score;
                PlayerPrefs.SetInt("BestScore",bestScore);
                PlayerPrefs.Save();
            }
            Logic.btn.gameObject.SetActive(true);
            Logic.q.Clear();
            Logic.qr.Clear();
            Logic.qw.Clear();
        }
        if (other.transform.gameObject.tag == "Right"){
            currentEquation.text= (string)Logic.q.Dequeue();
            StartCoroutine(destroyObject(other.transform.parent.gameObject));
            Logic.obstacleCounter--;
            score=score+(10*StartGame.levelDifficulty);            
        }
    }
    
    IEnumerator Jump()
    {
        playerSpeed = 0.1f;
        yield return new WaitForSeconds(2);        
        this.GetComponent<Animation>().Play("Run");
        playerSpeed = 0.2f;
    }

    IEnumerator destroyObject(GameObject current){
        yield return new WaitForSeconds(1);
        Destroy (current.gameObject);
    }

}
