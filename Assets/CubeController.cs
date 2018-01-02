using UnityEngine;
using System.Collections;

public class CubeController : MonoBehaviour {

        // キューブの移動速度
        private float speed = -0.2f;

        // 消滅位置
        private float deadLine = -10;
        
        // Use this for initialization
        void Start(){
        }

        // Update is called once per frame
        void Update () {
                // キューブを移動させる
                transform.Translate (this.speed, 0, 0);
                
                // 画面外に出たら破棄する
                if (transform.position.x < this.deadLine){
                        Destroy (gameObject);
                }
        }
        //キューブ同士またはキューブと地面が衝突したときに効果音を再生
        void OnCollisionEnter2D(Collision2D other){
                if(other.gameObject.tag == "blockTag" || other.gameObject.tag == "groundTag"){
                        GetComponent<AudioSource>().Play();
                }
        }
}