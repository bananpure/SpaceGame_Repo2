using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed;
    public GameObject blockObject;
    public GameObject attackObject;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        var move = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
        transform.position += move * speed * Time.deltaTime;

        if(Input.GetKeyDown(KeyCode.E))
        {
            attackObject.SetActive(true);
            
        }
        else if(Input.GetKeyUp(KeyCode.E))
        {
            attackObject.SetActive(false);
        }

        if(Input.GetKeyDown(KeyCode.Q))
        {
            blockObject.SetActive(true);
        }
        else if(Input.GetKeyUp(KeyCode.Q))
        {
            blockObject.SetActive(false);
        }
    }
}
