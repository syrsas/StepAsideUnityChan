using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnityChanController : MonoBehaviour
{
    // �A�j���[�V�������邽�߂̃R���|�[�l���g������
    private Animator myAnimator;

    // Start is called before the first frame update
    void Start()
    {
        // Animator�R���|�[�l���g���擾
        this.myAnimator = GetComponent<Animator>();

        // ����A�j���[�V�������J�n
        this.myAnimator.SetFloat("Speed", 1);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
