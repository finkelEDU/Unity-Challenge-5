﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DifficultyButtonX : MonoBehaviour
{
    private Button button;
    private GameManagerX gameManagerX;
    public int difficulty;

    // Start is called before the first frame update
    void Start()
    {
        gameManagerX = GameObject.Find("Game Manager").GetComponent<GameManagerX>();
        button = GetComponent<Button>();
        button.onClick.AddListener(SetDifficulty);
    }

    /* When a button is clicked, call the StartGame() method
     * and pass it the difficulty value (1, 2, 3) from the button 
    */
    void SetDifficulty()
    {
        Debug.Log(button.gameObject.name + " was clicked");

        switch(button.gameObject.name)
        {
            case "Hard Button": difficulty = 3; break;
            case "Medium Button": difficulty = 2; break;
            case "Easy Button": difficulty = 1; break;
            default: difficulty = 1; break;
        }
        Debug.Log("Difficulty number: " + difficulty);

        gameManagerX.StartGame(difficulty);
    }



}
