using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using TMPro;

public class PongManager : MonoBehaviour
{

    [SerializeField] GameObject ball;
    [SerializeField] GameObject ballPrefab;
    [SerializeField] float speed;

    [SerializeField] TMP_Text scoreLeft;
    [SerializeField] TMP_Text scoreRight;

    public int pointsLeft;
    public int pointsRight;

    // Start is called before the first frame update
    void Start()
    {
        InitGame();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.R) && ball != null){
            Reset();
        }
    }

        public void Reset(){
        if(ball != null){
            Destroy(ball);
            InitGame();
        }
    }

    //Start a new game
    void InitGame(){
        StartCoroutine(ServeBall());
    }

    
    IEnumerator ServeBall(){
        yield return new WaitForSeconds(1.0f);
        ball = Instantiate(ballPrefab);
        ball.GetComponent<Rigidbody2D>().velocity = Random.insideUnitCircle.normalized * speed;
    }

    public void Score(string side){
        if(side == "left"){
            pointsLeft ++;
            scoreLeft.text = pointsLeft.ToString();
            InitGame();
        }
        else if (side == "right"){
            pointsRight++;
            scoreRight.text = pointsRight.ToString();
            InitGame();
        }
    }
}
