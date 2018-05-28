using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class carMove : MonoBehaviour {

    float speed = 0;
    Vector2 startPos;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetMouseButtonDown(0))
        {
            //マウスをクリックした座標
            this.startPos = Input.mousePosition;
            this.speed = 0.2f;
        }
        else if (Input.GetMouseButtonUp(0))
        {
            Vector2 endPos = Input.mousePosition;
            float swipeLength = endPos.x - this.startPos.x;

            //スワイプの長さを初速度に変換する
            this.speed = swipeLength / 500.0f;

            //効果音再生
            GetComponent<AudioSource>().Play();
        }

        transform.Translate(this.speed, 0, 0);
        this.speed *= 0.98f;
	}
}
