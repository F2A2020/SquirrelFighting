using System;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private bool isGround;

    private Animator anim;

    public float speed = 4f;

    public float gravity = -50f;

    private void Awake()
    {
        anim = GetComponent<Animator>();
        Physics.gravity = new Vector3(0, gravity, 0);
    }


    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");

        if (Math.Abs(horizontal) > 0.1f)
        {
            anim.SetBool("isRun", true);
            // 控制转向
            transform.localScale = new Vector3(horizontal > 0 ? 1 : -1, 1, 1);
            // 控制移动
            transform.Translate(Vector2.right * horizontal * speed * Time.deltaTime);
        }
        else
        {
            anim.SetBool("isRun", false);
        }

        // 向上跳
        if (Input.GetKeyDown(KeyCode.Space) && isGround)
        {
            GetComponent<Rigidbody2D>().AddForce(Vector2.up * 300f);
        }
        
        // 攻击
        if (Input.GetKeyDown(KeyCode.Space))
        {
            
        }
    }


    /// <summary>
    /// 碰到地面
    /// </summary>
    /// <param name="other"></param>
    private void OnCollisionEnter2D(Collision2D other)
    {
        // 向下或静止
        bool fall = GetComponent<Rigidbody2D>().velocity.y <= 0;
        if (other.collider.CompareTag("Ground") && fall)
        {
            isGround = true;
            anim.SetBool("isJump", false);
            AudioManager.Instance.PlayerSound("jumpend");
        }
    }

    /// <summary>
    /// 离开地面
    /// </summary>
    /// <param name="other"></param>
    private void OnCollisionExit2D(Collision2D other)
    {
        if (other.collider.CompareTag("Ground"))
        {
            isGround = false;
            anim.SetBool("isJump", true);
        }
    }
}
