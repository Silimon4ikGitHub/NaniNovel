using DTT.MinigameMemory;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MemoryFinisher : MonoBehaviour
{
    [SerializeField] MemoryGameManager _gameManager;
    [SerializeField] GameObject _button;

    private void OnEnable()
    {
        _gameManager.Finish += MyFinishedMethod;
    }
    private void MyFinishedMethod (MemoryGameResults results)
    {
        _button.SetActive(true);
        Debug.Log(results.ToString());
        Debug.Log("GamePassed");
    }
}
