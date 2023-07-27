using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CandyDestroyer : MonoBehaviour
{
    public CandyManager candyManager;
    public int reward;
    public GameObject effectPrehab;
    public Vector3 effectRotation;

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Candy")
        {
            //�w�萔����Candy�̃X�g�b�N�𑝂₷
            candyManager.AddCandy(reward);

            //�I�u�W�F�N�g�̍폜
            Destroy(other.gameObject);

            if(effectPrehab != null)
            {
                //Candy�̃|�W�V�����ɃG�t�F�N�g�𐶐�
                Instantiate(
                    effectPrehab,
                    other.transform.position,
                    Quaternion.Euler(effectRotation)
                    );
            }
        }
    }
}
