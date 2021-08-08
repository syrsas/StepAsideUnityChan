using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemGenerator : MonoBehaviour
{
    //carPrefabを入れる
    public GameObject carPrefab;
    //coinPrefabを入れる
    public GameObject coinPrefab;
    //cornPrefabを入れる
    public GameObject conePrefab;
    //スタート地点
    private int startPos = 80;
    //ゴール地点
    private int goalPos = 360;
    //アイテムを出すx方向の範囲
    private float posRange = 3.4f;
    // Unityちゃんのオブジェクト（発展）
    private GameObject unitychan;
    // Unityちゃんとカメラの距離（発展）
    private float difference;

    // Start is called before the first frame update
    void Start()
    {
        // Unityちゃんのオブジェクトを取得（発展）
        this.unitychan = GameObject.Find("unitychan");
        // Unityちゃんとカメラの位置（z座標）の差を求める（発展）
        this.difference = unitychan.transform.position.z - this.transform.position.z;

        //Unityちゃんの進行に応じてアイテムを生成
        for (difference = 0.0f; difference <= 40.0f; difference += 1.5f)
        {
            
                //どのアイテムを出すかをランダムに設定
                int num = Random.Range(1, 11);
                if (num >= 1 && num <= 4)
                {
                    GameObject cone = Instantiate(conePrefab);
                    cone.transform.position = new Vector3(4 * cone.transform.position.x, cone.transform.position.y, cone.transform.position.z);
                }
                else if (num >= 5 && num <= 8)
                {
                    //コインを生成
                    GameObject coin = Instantiate(coinPrefab);
                    coin.transform.position = new Vector3(coin.transform.position.x, coin.transform.position.y, coin.transform.position.z);

                }
                else if (num >= 9 && num <= 11)
                {
                    //車を生成
                    GameObject car = Instantiate(carPrefab);
                    car.transform.position = new Vector3(car.transform.position.x, car.transform.position.y, car.transform.position.z);

                }
        
        }        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
