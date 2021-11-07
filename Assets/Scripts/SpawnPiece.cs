using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPiece : MonoBehaviour
{
    public GameObject pieceToSpawn;
    public float leftestPos = -4f;
    public float rightestPos = 4f;
    public bool moveRight = true;
    public float speed = 1f;
    Vector3 movingDirection;
    float maxRightPosition;
    float maxLeftPosition;

    public GameObject commandHelper;
    public bool showHelper = true;

    // Start is called before the first frame update
    void Start()
    {
        maxRightPosition = gameObject.transform.position.x + rightestPos;
        maxLeftPosition = gameObject.transform.position.x + leftestPos;
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && JetonManager.instance.getNbJetons() > 0)
        {
            if (showHelper)
            {
                commandHelper.SetActive(false);
                showHelper = false;
            }

            Instantiate(pieceToSpawn, gameObject.transform.position, Quaternion.Euler(120f, 120f, 120f));
            JetonManager.instance.removeJeton(1);
        }
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
    }
}
