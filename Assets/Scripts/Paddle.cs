using System.Collections;
using System.Collections.Generic;
using UnityEditor.UI;
using UnityEngine;

public class Paddle : MonoBehaviour
{
    protected Rigidbody2D _rigidbody;
    private Vector2 _direction;
    [SerializeField] private float speed = 10.0f;

    private void Awake()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
    }

    public void ResetPosition(){
        _rigidbody.position = new Vector2(0, _rigidbody.position.y);
        _rigidbody.velocity = Vector2.zero;
    }


    private void Update(){
        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow)){
            _direction = Vector2.left;
        }
        else if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow)){
            _direction = Vector2.right;
        }
        else {
            _direction = Vector2.zero;
        }
    }

    private void FixedUpdate() {
        if (_direction.sqrMagnitude > 0){
            _rigidbody.AddForce(_direction * this.speed);
        }
    }
}
