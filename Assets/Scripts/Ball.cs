using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{

    [SerializeField] Paddle paddle1;
    [SerializeField] float ballSpeedX=2f;
    [SerializeField] float ballSpeedY=15f;
    [SerializeField] AudioClip[] sounds;
    Vector2 offSetBallAndPaddle;
    bool gameStarted=false;

    
    void Start()
    {
        offSetBallAndPaddle= transform.position-paddle1.transform.position;
    }

    
    void Update()
    {
        if(!gameStarted){
            ballStickToPaddle();
            shootBall();
        }
    }

    private void ballStickToPaddle(){
        Vector2 paddlePos=new Vector2(paddle1.transform.position.x,paddle1.transform.position.y);
        transform.position=paddlePos+offSetBallAndPaddle;
    }

    private void shootBall(){
        if(Input.GetMouseButtonDown(0)){
            gameStarted=true;
            GetComponent<Rigidbody2D>().velocity=new Vector2(ballSpeedX,ballSpeedY);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision){
        if(gameStarted==true){
            AudioClip clip=sounds[UnityEngine.Random.Range(0,sounds.Length)];
            GetComponent<AudioSource>().PlayOneShot(clip);
        }
    }
}
