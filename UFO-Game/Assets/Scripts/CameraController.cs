using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    //首先定义了一个public的GameObject变量player，这个变量是用来告诉程序，摄像机会跟随哪个GameObject来移动
    public GameObject player;

    //然后定义一个private的Vector3变量offset，这个变量用来记录游戏初始化的时候，摄像机和UFO之间的距离
    private Vector3 offset;

    // 在Start方法中，摄像机和UFO的位置差赋值给offset变量，有了这个固定值才能在后续UFO移动的过程中，UFO和摄像机的距离保持不变
    void Start()
    {
        offset = transform.position - player.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //最后在LateUpdate方法中，把摄像机的新位置变更为球体的新位置加上固定的offset偏移位置
    private void LateUpdate()
    {
        transform.position = offset + player.transform.position;
    }
}
