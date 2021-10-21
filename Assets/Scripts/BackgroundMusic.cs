using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundMusic : MonoBehaviour
{
    private void Awake(){
        int countBackgroundObejct=FindObjectsOfType<BackgroundMusic>().Length;
        if(countBackgroundObejct>1){
            gameObject.SetActive(false);
            Destroy(gameObject);
        }else{
            DontDestroyOnLoad(gameObject);
        }
    }

    public void DestroyBackgroundMusicObject(){
        Destroy(gameObject);
    }
}
