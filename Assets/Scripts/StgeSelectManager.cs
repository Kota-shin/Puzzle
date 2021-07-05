using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class StgeSelectManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //ステージ選択ボタンの処理
    public void PushStageSelectButton(int stageNo)
    {
        SceneManager.LoadScene("PuzzleScene" + stageNo);    //ゲームシーンへ
    }
}
