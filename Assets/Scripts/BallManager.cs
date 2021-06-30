using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter2D(Collision2D coll)       //ボールが衝突した処理
    {
        if(coll.gameObject.tag == "OutArea")        //タグ「OutArea」の処理
        {
            GameObject gameManager = GameObject.Find("GameManager");
            gameManager.GetComponent<GameManager>().PushRetryButton();
        }
    }

    void OnTriggerEnter2D(Collider2D other)         //ボールが衝突した処理
    {
        if(other.gameObject.tag == "ClearArea")     //タグ「ClearArea」の処理
        {
            GameObject gameManager = GameObject.Find("GameManager");
            gameManager.GetComponent<GameManager>().StageClear();
        }
    }

}
