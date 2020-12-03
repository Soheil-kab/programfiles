using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Sohei Kaburaki

public class cubecontroller : MonoBehaviour
{
    float speed = 0;
    Vector2 firstPosition;
    void Start()
    {

    }

    void Update()
    {
        if(Input.GetMouseButtonDown(0))//マウスクリック
        {
            this.firstPosition=Input.mousePosition;//クリックした時の座標
        }else if(Input.GetMouseButtonUp(0)){//マウスを離す
            Vector2 lastPosition=Input.mousePosition;//マウスを離した時の座標
            float Length=lastPosition.x-this.firstPosition.x;//２つの座標のxを比べてその時の差を代入
            this.speed=Length/1000.0f;//長さ（座標の差）を初速に代入
            /*/ボールのバウンド
            var material = GetComponent<Rigidbody2D>().sharedMaterial;
            material.friction = 0.3f;//摩擦係数
            material.bounciness = 0.7f;//反発係数*/
        }
        transform.Translate(this.speed,this.speed,0);//移動
        this.speed*=0.99f;//減速
    }
}
