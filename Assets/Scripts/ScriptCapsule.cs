using UnityEngine;
using System.Collections;

public class ScriptCapsule : MonoBehaviour
{
    [SerializeField]

    private float Speed = 10.0f;
    private Vector3 direction;
    private Vector3 tourner;
    


    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        // en avant
        direction = Vector3.zero;
        if (Input.GetKey(KeyCode.X))
            transform.Rotate(Vector3.up * Time.deltaTime * 45);
        Debug.Log("Toto");
        if (Input.GetKey(KeyCode.W))
        {
            transform.Rotate(Vector3.down * Time.deltaTime * 45);
        }

        if (Input.GetKey(KeyCode.Q))
        {
           direction += -transform.right;
        }
        if (Input.GetKey(KeyCode.D))
        {
            direction += transform.right;
      }
        if (Input.GetKey(KeyCode.Z)){
            direction += transform.forward;
        }
        if (Input.GetKey(KeyCode.S))
        {
            direction += -transform.forward;
        }
           gameObject.transform.position += direction * Speed * Time.deltaTime;
           

    }
}