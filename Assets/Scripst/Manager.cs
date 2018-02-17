using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manager : MonoBehaviour {

    private static GameOver _gameOver;
    public static GameOver Over {
        get { return _gameOver; }
    }


    private static TextController _textControll;
    public static TextController TextControll {
        get { return _textControll; }
    }

    private static BlocksController _blockControll;
    public static BlocksController BlockControll {
        get { return _blockControll; }
    }

    void Awake()
    {
        _gameOver = GetComponent<GameOver>();
        _textControll = GetComponent<TextController>();
        _blockControll = GetComponent<BlocksController>();
      
    }
}
