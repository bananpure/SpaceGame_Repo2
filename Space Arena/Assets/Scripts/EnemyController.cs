using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public Collider attackCollider;
    public GameObject attackObject;
    BoxCollider enemyCollider;

    // Start is called before the first frame update
    void Start()
    {
        enemyCollider = GetComponent<BoxCollider>();
    }

    // Update is called once per frame
    void Update()
    {
        if (enemyCollider.bounds.Intersects(attackCollider.bounds) && attackObject.activeInHierarchy == true)
        {
            //Takedamage
            Debug.Log("Enemy hit.");
        }
    }
    private void TakeDamage()
    {

    }
}
