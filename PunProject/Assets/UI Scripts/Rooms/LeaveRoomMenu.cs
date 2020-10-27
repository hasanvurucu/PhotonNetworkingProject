using Photon.Pun;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeaveRoomMenu : MonoBehaviour
{
    private RoomsCanvases _roomsCanvas;
    public void OnClick_LeaveRoom()
    {
        PhotonNetwork.LeaveRoom(true);
        _roomsCanvas.CurrentRoomCanvas.Hide();
    }

    public void FirstInitialize(RoomsCanvases canvases)
    {
        _roomsCanvas = canvases;
    }
}
