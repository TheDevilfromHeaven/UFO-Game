using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // 放在Update()函数中的代码是以帧来执行的，因为我们需要金币的旋转是以秒来执行，所以需要乘以Time.deltaTime增量时间。
    void Update()
    {
        //调用transform下的Rotate方法按指定的角度（围绕Z轴旋转45°）旋转一个物体。
        transform.Rotate(new Vector3(0, 0, 45) * Time.deltaTime);
    }
}
