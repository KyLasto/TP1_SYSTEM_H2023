using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float playerSpeed = 5f;

    private Animator anim;

    void Start()
    {
        anim = GetComponent<Animator>();
    }
    void Update()
    {
        anim.SetBool("IsRunning",false);
        var movement = Input.GetAxis("Horizontal");
        Running();
        transform.position += new Vector3(movement, 0, 0) * Time.deltaTime * playerSpeed;

        if (!Mathf.Approximately(0, movement))
            transform.rotation = movement < 0 ? Quaternion.Euler(0, 180, 0) : Quaternion.identity;
    }

    private void Running()
    {
        if (Input.GetKey(KeyCode.A))
        {
            anim.SetBool("IsRunning", true);
        }
        
        if (Input.GetKey(KeyCode.D))
        {
            anim.SetBool("IsRunning", true);
        }
    }
}