using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    private Rigidbody2D rb2D;
    public float speed;
    private int count;
    public Text countText;
    public Text winText;

    // Start is called before the first frame update
    void Start()
    {
        rb2D = GetComponent<Rigidbody2D>();
        count = 0;
        setCountText();
        winText.text = "";
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");
        Vector2 movement = new Vector2(moveHorizontal, moveVertical);
        rb2D.AddForce(movement * speed);
    }

    //OnTriggerEnter方法是检测物理发生碰撞的时候调用执行里面的代码，参数other变量表示UFO碰到的其他2D碰撞器
    private void OnTriggerEnter2D(Collider2D other)
    {
        //先调用CompareTag方法判断碰到的这个对象是否被标记了Tag"PickUp"，如果是的话则调用SetActive把这个对象设置为未激活状态（不显示），也就是false。
        if (other.gameObject.CompareTag("PickUp"))
        {
            other.gameObject.SetActive(false);
            count++;
            setCountText();
        }
    }

    void setCountText()
    {
        countText.text = "Count : " + count.ToString();
        if(count >= 6)
        {
            winText.text = "You win !";
        }
    }
}
