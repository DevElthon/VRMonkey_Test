using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BatteryPickup : MonoBehaviour {

    public float val = 20;



    public void OnTriggerEnter(Collider col)
    {
        StealthPlayerController player = StealthPlayerController.getInstance();
        if (col.gameObject == player.gameObject)
        {
            if(GameLogic.instance.inBossBattle){
                GameLogic.instance.batteryCount -= 1;
                if(GameLogic.instance.batteryCount == 0)
                    GameLogic.instance.BossBattle();
            }
            ConsoleText.getInstance().ShowMessage("Battery acquired");
            player.AddEnergy(val);
            GameObject.Instantiate(EffectsManager.getInstance().itemEffect, transform.position,Quaternion.identity);
            gameObject.SetActive(false);
        }
    }
}
