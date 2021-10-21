using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Block : MonoBehaviour
{
    [SerializeField] AudioClip breakSound;
    [SerializeField] GameObject particleEffect;
    [SerializeField] int maxHits=2;
    [SerializeField] int timesHit=0;
    [SerializeField] Sprite[] sprites;
    Level level;
    GameStatus gameStatus;
    void Start()
    {
        level=FindObjectOfType<Level>();
        gameStatus=FindObjectOfType<GameStatus>();
        if(tag=="breakable"){
        level.countBreakableBlocks();
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void TriggerSparklesEffect(){
        GameObject sparkle=Instantiate(particleEffect,transform.position,transform.rotation);
        Destroy(sparkle,1f);
    }

    private void OnCollisionEnter2D(Collision2D collision){
        if(tag=="breakable"){
            timesHit++;
            if(timesHit>maxHits){
                AudioSource.PlayClipAtPoint(breakSound,Camera.main.transform.position);
                TriggerSparklesEffect();
                level.blockDestroyed();
                gameStatus.increaseScore();
                Destroy(gameObject);
            }
            else
            {
                int indxOfDamagedBlock=timesHit-1;
                GetComponent<SpriteRenderer>().sprite=sprites[indxOfDamagedBlock];
            }
        }
    }
}
