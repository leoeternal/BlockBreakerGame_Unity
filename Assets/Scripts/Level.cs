using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level : MonoBehaviour
{
    [SerializeField] public int breakableBlocks;
    SceneLoader sceneLoader;
    

    void Start(){
        sceneLoader=FindObjectOfType<SceneLoader>();
        
    }

    public void countBreakableBlocks(){
        breakableBlocks++;
    }

    public void blockDestroyed(){
        breakableBlocks--;
        if(breakableBlocks==0)
        {
            sceneLoader.LoadNextScene();
        }
    }
}
