using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PusherMoves : MonoBehaviour
{
    [SerializeField]
    bool advance = true;
    Rigidbody rigidbody;
    public float baseChrono = 20;
    float chrono;
    public float speed = 1.0f;

    private void Awake()
    {
        rigidbody = gameObject.GetComponent<Rigidbody>();
        chrono = baseChrono;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float direction = (advance) ? 1f : -1f;
        rigidbody.AddForce(new Vector3(0f, 0f, (direction * speed * rigidbody.mass)));
        chrono -= Time.deltaTime;
        if (gameObject.transform.position.z > -8 && advance)
        {
            advance = false;
            rigidbody.velocity = Vector3.zero;
            rigidbody.angularVelocity = Vector3.zero;
            chrono = baseChrono;
        }
        if (gameObject.transform.position.z < -13 && !advance)
        {
            advance = true;
            rigidbody.velocity = Vector3.zero;
            rigidbody.angularVelocity = Vector3.zero;
            chrono = baseChrono;
        }
    }
}
