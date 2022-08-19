using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SepetMovement : MonoBehaviour
{
    private float x;
    private float hiz =6f;
    public GameManager manager;
    void Start()
    {
        
    }

    // Update is called once per frame
    private void FixedUpdate()
    {
        SepetMovementController();
    }
    #region SepetController
    public void SepetMovementController()
    {
        x = Input.GetAxis("Horizontal");
        gameObject.transform.position+=new Vector3(x*hiz*Time.deltaTime,0,0);
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("elmas"))
        {
            Destroy(collision.gameObject);
            manager.updateScore();
        }
    }
    #endregion
}
