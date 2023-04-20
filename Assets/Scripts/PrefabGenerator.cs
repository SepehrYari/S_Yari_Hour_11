using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrefabGenerator : MonoBehaviour
{

    [SerializeField] private GameObject prefab;

    private void Start()
    {
        for (int i = 0; i < 10; i++)
        {
            
            Instantiate(prefab, new Vector3(i * 5, 0, 3), transform.rotation);

        }
    }




    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.B))
        {
            Instantiate(prefab);
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(prefab, transform.position, transform.rotation);
        }




    }
}
