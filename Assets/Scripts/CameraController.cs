using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    [SerializeField]private Transform player;//kiểu dữ liệu là transform biến đổi toa
    // Update is called once per frame
    void Update()
    {
        transform.position=new Vector3(player.position.x,player.position.y,transform.position.z);//cập nhật vị trí của đối tg hiện tại theo đối tg player
    }
}
