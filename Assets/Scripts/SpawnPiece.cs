using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPiece : MonoBehaviour
{
    public GameObject pieceToSpawn;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(pieceToSpawn, gameObject.transform.position + new Vector3(Random.Range(-3f, 3f), 0f, 0f), Quaternion.identity);
        }
    }
}
