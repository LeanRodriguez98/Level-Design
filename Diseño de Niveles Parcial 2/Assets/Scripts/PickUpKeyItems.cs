using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpKeyItems : MonoBehaviour
{
    public GameObject[] keyItems;
    private GameObject[] AuxKeyItems;
    public GameObject ObjetivePoint;
    private bool[] keyItemsBool;

    // Use this for initialization
    void Start()
    {
        AuxKeyItems = keyItems;
        for (int i = 0; i < AuxKeyItems.Length; i++)
        {
            AuxKeyItems[i].tag = "Untagged";
        }
        keyItemsBool = new bool[keyItems.Length];
        for (int i = 0; i < keyItems.Length; i++)
        {
            keyItemsBool[i] = false;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        for (int i = 0; i < keyItems.Length; i++)
        {
            if (keyItems[i] != null)
            {
                if (collision.gameObject.tag == keyItems[i].tag)
                {
                    keyItemsBool[i] = true;
                }
            }
            
        }
    }


    void OnTriggerEnter(Collider collision)
    {
        bool Check = true;

        if (collision.gameObject.tag == ObjetivePoint.tag)
        {
            for (int i = 0; i < keyItemsBool.Length; i++)
            {
                if (keyItemsBool[i] == false)
                {
                    Check = false;
                }
                if (Check == true)
                {
                    for (int j = 0; j < AuxKeyItems.Length; j++)
                    {
                        Instantiate(AuxKeyItems[i], 
                            new Vector3(ObjetivePoint.transform.position.x, ObjetivePoint.transform.position.y - 3, ObjetivePoint.transform.position.z + 20 +(5 * i)), Quaternion.identity);
                    }
                    this.tag = "Untagged";
                }
            }
        }
    }
}