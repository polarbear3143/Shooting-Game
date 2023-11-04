using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyManger : MonoBehaviour
{
    [SerializeField] GameObject [ ] enemyPrefabs;
    [SerializeField] Transform  [ ] creatPositoins;

    void Start()
    {
        StartCoroutine(CreateRoutine());
    }

    IEnumerator CreateRoutine()
    {
        yield return new WaitForSeconds(5f);

        Debug.Log("Create Enemy");                                                                                        
    }
 
}
