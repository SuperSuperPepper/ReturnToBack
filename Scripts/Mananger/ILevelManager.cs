using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface ILevelManager {
    Transform checkPositon { set; get; }
    void StartGame();



    void GameOver();


    void ReturnCheck();
  
}
