using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Windows;

public class Player1 : MonoBehaviour
{
    public float moveSpeed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        bool isPressingUp = UnityEngine.Input.GetKey(KeyCode.W);
        bool isPressingDown = UnityEngine.Input.GetKey(KeyCode.S);

        if (isPressingUp)
        {
            transform.Translate(Vector2.up * Time.deltaTime * moveSpeed);
        }

        if (isPressingDown)
        {
            transform.Translate(Vector2.down * Time.deltaTime * moveSpeed);
        }
        
                
    }
}
