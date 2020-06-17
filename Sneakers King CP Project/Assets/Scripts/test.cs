using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test : MonoBehaviour
{

    Rigidbody2D rb;
    Animator anim;
   // bool facingRight = true;    //menghadap kanan
    float velX, speed = 3f;    //kecepatan jalan
  //  int health = 5;             //pengaturan jumlah darah
   // bool isHurt, isDead;        //untuk triger

    public float jumpValue;     //kekuatan lompat
    //buton
    public KeyCode leftbutton;
    public KeyCode rightbutton;
    public KeyCode jump;
    public KeyCode LeftShift;
    public KeyCode trowShoes;
    //objek dilempar dan titik lempar
   // public GameObject sepatu;
  //  public Transform atackPoint;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(LeftShift))       //lari dengan shift
            speed = 7f;
        else
        if (Input.GetKey(leftbutton))
        {
            rb.velocity = new Vector2(-speed, rb.velocity.y);
        }
        else if (Input.GetKey(rightbutton))
        {
            rb.velocity = new Vector2(speed, rb.velocity.y);
        }//jalan
        else
        {
            rb.velocity = new Vector2(0, rb.velocity.y);
        }

        //fungsi jump
        if (Input.GetKeyDown(jump) && rb.velocity.y == 0)
            rb.AddForce(Vector2.up * jumpValue);
    }
}
