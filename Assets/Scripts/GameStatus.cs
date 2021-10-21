using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GameStatus : MonoBehaviour
{

    [SerializeField] float gameSpeed=1f;
    [SerializeField] float pointsOnBreak=27f;
    float currentScore=0f;
    [SerializeField] TextMeshProUGUI scoreComponent;

    private void Awake(){
        int gameStatusCount=FindObjectsOfType<GameStatus>().Length;
        if(gameStatusCount>1){
            gameObject.SetActive(false);
            Destroy(gameObject);
        }else{
            DontDestroyOnLoad(gameObject);
        }
    }

    void Start()
    {
        scoreComponent.text="Score: "+currentScore;
    }

    public void DestroyGameObject(){
        Destroy(gameObject);
    }


    void Update()
    {
        Time.timeScale=gameSpeed;
    }

    public void increaseScore(){
        currentScore+=pointsOnBreak;
        scoreComponent.text="Score: "+currentScore;
    }
}
