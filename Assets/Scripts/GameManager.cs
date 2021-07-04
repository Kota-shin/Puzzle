using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public int StageNum;
    public bool isBallMoving;
    public GameObject ballPrefab;
    public GameObject ball;
    public GameObject goButton;
    public GameObject retryButton;
    public GameObject clearText;



    // Start is called before the first frame update
    void Start()
    {
        retryButton.SetActive(false);           //リトライボタン非表示
        isBallMoving = false;                   //ボールが移動中
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PushGoButton()                  //「Go]ボタンの押下処理
    {
        Rigidbody2D rd = ball.GetComponent<Rigidbody2D>();
        rd.isKinematic = false;                 //物理エンジンのオフ

        retryButton.SetActive(true);            //リトライボタンの表示
        goButton.SetActive(false);              //Goボタンの非表示
        isBallMoving = true;                    //ボールが移動中
    }

    public void PushRetryButton()               //「Retry」ボタンの押下処理
    {
        Destroy(ball);

        ball = (GameObject)Instantiate(ballPrefab);
        retryButton.SetActive(false);           //リトライボタン非表示
        goButton.SetActive(true);               //Goボタンの表示
        isBallMoving = false;                   //ボールが移動中ではない
    }

    public void StageClear()                    //ステージクリアの処理
    {
        clearText.SetActive(true);
        retryButton.SetActive(false);
    }

    public void PushBackButton()
    {

    }

}
