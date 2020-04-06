using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameCamera : MonoBehaviour
{
    //Variables
    public Transform player;
    public PlayerController controller;
    public float smooth = 0.3f;
    public float height;

    private Vector3 velocity = Vector3.zero;

    private void Start()
    {
        controller.MovedCallback += UpdateCameraPos;
    }

    //Methods
    //Changed Update to a method that is invoked when the player moves to avoid updating the position when there is no update
    private void UpdateCameraPos()
    {
        Vector3 pos = new Vector3();
        pos.x = player.position.x;
        pos.z = player.position.z - 7f; //offset
        pos.y = player.position.y + height;
        transform.position = Vector3.SmoothDamp(transform.position, pos, ref velocity, smooth);
    }
}
