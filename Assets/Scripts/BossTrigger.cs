using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossTrigger : MonoBehaviour
{
    public AIAgent boss;
    private void OnTriggerEnter(Collider other) {
        if(other.CompareTag("Player")){
            GameLogic.instance.inBossBattle = true;
            boss.ResetEnergy();
            GameLogic.instance.BossBattle();
            GameLogic.instance.ShowMessageBox("Your shock and drain abilities have been disabled by the Tower Unit HIR#M#! Defeat it to enable them again!");
            this.gameObject.SetActive(false);
        }
    }
}
