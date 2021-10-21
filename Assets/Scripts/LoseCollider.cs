using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoseCollider : MonoBehaviour
{

    SceneLoader sceneLoader;
    GameStatus gameStatus;
    BackgroundMusic backgroundMusic;

    // Start is called before the first frame update
    void Start()
    {
        sceneLoader=FindObjectOfType<SceneLoader>();
        gameStatus=FindObjectOfType<GameStatus>();
        backgroundMusic=FindObjectOfType<BackgroundMusic>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision){
        gameStatus.DestroyGameObject();
        sceneLoader.LoadGameOverScene();
        backgroundMusic.DestroyBackgroundMusicObject();
    }
}
