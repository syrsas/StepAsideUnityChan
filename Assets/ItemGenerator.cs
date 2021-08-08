using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemGenerator : MonoBehaviour
{
    //carPrefab������
    public GameObject carPrefab;
    //coinPrefab������
    public GameObject coinPrefab;
    //cornPrefab������
    public GameObject conePrefab;
    //�X�^�[�g�n�_
    private int startPos = 80;
    //�S�[���n�_
    private int goalPos = 360;
    //�A�C�e�����o��x�����͈̔�
    private float posRange = 3.4f;
    // Unity�����̃I�u�W�F�N�g�i���W�j
    private GameObject unitychan;
    // Unity�����ƃJ�����̋����i���W�j
    private float difference;

    // Start is called before the first frame update
    void Start()
    {
        // Unity�����̃I�u�W�F�N�g���擾�i���W�j
        this.unitychan = GameObject.Find("unitychan");
        // Unity�����ƃJ�����̈ʒu�iz���W�j�̍������߂�i���W�j
        this.difference = unitychan.transform.position.z - this.transform.position.z;

        //Unity�����̐i�s�ɉ����ăA�C�e���𐶐�
        for (difference = 0.0f; difference <= 40.0f; difference += 1.5f)
        {
            
                //�ǂ̃A�C�e�����o�����������_���ɐݒ�
                int num = Random.Range(1, 11);
                if (num >= 1 && num <= 4)
                {
                    GameObject cone = Instantiate(conePrefab);
                    cone.transform.position = new Vector3(4 * cone.transform.position.x, cone.transform.position.y, cone.transform.position.z);
                }
                else if (num >= 5 && num <= 8)
                {
                    //�R�C���𐶐�
                    GameObject coin = Instantiate(coinPrefab);
                    coin.transform.position = new Vector3(coin.transform.position.x, coin.transform.position.y, coin.transform.position.z);

                }
                else if (num >= 9 && num <= 11)
                {
                    //�Ԃ𐶐�
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
