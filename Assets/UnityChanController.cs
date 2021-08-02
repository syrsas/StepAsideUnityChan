using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnityChanController : MonoBehaviour
{
    // �A�j���[�V�������邽�߂̃R���|�[�l���g������
    private Animator myAnimator;
    // Unity�������ړ�������R���|�[�l���g������i�ǉ��j
    private Rigidbody myRigidbody;
    // �O�����̑��x�i�ǉ��j
    private float velocityZ = 16f;

    // Start is called before the first frame update
    void Start()
    {
        // Animator�R���|�[�l���g���擾
        this.myAnimator = GetComponent<Animator>();

        // ����A�j���[�V�������J�n
        this.myAnimator.SetFloat("Speed", 1);

        // Rigidbody�R���|�[�l���g���擾�i�ǉ��j
        this.myRigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        //Unity�����ɑ��x��^����i�ǉ��j
        this.myRigidbody.velocity = new Vector3(0, 0, this.velocityZ);
    }
}
