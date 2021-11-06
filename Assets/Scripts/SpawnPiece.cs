using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPiece : MonoBehaviour
{
    public GameObject pieceToSpawn;
    public bool posAleatoire = false;

    public float leftestPos = -4f;
    public float rightestPos = 4f;
    public bool moveRight = true;
    public float speed = 1f;
    Vector3 movingDirection;
    float maxRightPosition;
    float maxLeftPosition;

    // Start is called before the first frame update
    void Start()
    {
        maxRightPosition = gameObject.transform.position.x + rightestPos;
        maxLeftPosition = gameObject.transform.position.x + leftestPos;
    }

    // Update is called once per frame
    void FixedUpdate()
    {

        if (moveRight)
        {
            movingDirection = Vector3.right;
        }
        else
        {
            movingDirection = Vector3.left;
        }

        gameObject.transform.Translate(movingDirection * speed * Time.deltaTime);
        if (gameObject.transform.position.x > maxRightPosition && moveRight)
        {
            moveRight = false;
        }

        if (gameObject.transform.position.x < maxLeftPosition && !moveRight)
        {
            moveRight = true;
        }

        if (Input.GetKeyDown(KeyCode.Space) && JetonManager.instance.getNbJetons() > 0)
        {
            Debug.Log("space");
            if (posAleatoire)
            {
                Debug.Log("instance alea");
                Instantiate(pieceToSpawn, gameObject.transform.position + new Vector3(Random.Range(leftestPos, rightestPos), 0f, 0f), Quaternion.identity);
            }
            else
            {
                Debug.Log("instance non alea");
                Instantiate(pieceToSpawn, gameObject.transform.position, pieceToSpawn.transform.rotation);
            }

            JetonManager.instance.removeJeton(1);
        }
    }
}
