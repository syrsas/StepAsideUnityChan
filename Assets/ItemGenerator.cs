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
        
            if (this.transform.position.z >= Camera.main.transform.position.z)
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
            //どのアイテムを出すかをランダムに設定
            /*int num = Random.Range(1, 11);
            if(num <= 2)
            {
                //コーンをx軸方向に一直線に生成
                for(float j = -1; j <= 1; j += 0.4f)
                {
                    GameObject cone = Instantiate(conePrefab);
                    cone.transform.position = new Vector3(4 * j, cone.transform.position.y, i);
                }
            }*/
            /*else
            {
                //レーンごとにアイテムを生成
                for(int j = -1; j <= 1; j++)
                {
                    //アイテムの種類を決める
                    int item = Random.Range(1, 11);
                    //アイテムを置くZ座標のオフセットランダムに設定
                    int offsetZ = Random.Range(-5, 6);
                    //60%コイン配置：３０％車配置：10％何もなし
                    if(1 <= item && item <= 6)
                    {
                        //コインを生成
                        GameObject coin = Instantiate(coinPrefab);
                        coin.transform.position = new Vector3(posRange * j, coin.transform.position.y, i + offsetZ);

                    }
                    else if(7 <= item && item <= 9)
                    {
                        //車を生成
                        GameObject car = Instantiate(carPrefab);
                        car.transform.position = new Vector3(posRange * j, car.transform.position.y, i + offsetZ);
                    }
                }
            }*/
        
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
