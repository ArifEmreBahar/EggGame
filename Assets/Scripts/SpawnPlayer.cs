using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPlayer : MonoBehaviour
{
    public Vector3 lastPosition;
    public SaveDatas saveData;


    void OnEnable()
    {
            saveData.GetSavedData();
            lastPosition = saveData.playerSpawnPoint;
            spawnPlayer();
    }

    public void spawnPlayer() {
        
        transform.position = lastPosition;
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.U)) {
            spawnPlayer();
        }
    }
}
