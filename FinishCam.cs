using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinishCam : MonoBehaviour
{
    public Transform cam;
    public Transform Player;



    void Start()
    {


    }
    private void Update()
    {



    }
    public void CamAnim()
    {
     
        cam.transform.DOMove(new Vector3(0, cam.transform.position.y-3,cam.transform.position.z), 3.5f);
        cam.transform.DORotate(new Vector3(0, 0, 0), 3, RotateMode.Fast);
        Player.transform.DORotate(new Vector3(0, 180, 0), 2, RotateMode.Fast).OnComplete(() => SorunCozumu());
    }

    public void SorunCozumu()
    {
        cam.transform.DOMove(new Vector3(0, cam.transform.position.y, cam.transform.position.z), 10f);
    }


}
