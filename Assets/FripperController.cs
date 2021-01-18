using UnityEngine;
using System.Collections;
public class FripperController : MonoBehaviour
{
    //HingeJointコンポーネントを入れる
    private HingeJoint myHingeJoint;
    //初期の傾き
    private float defaultAngle = 20;
    //弾いた時の傾き
    private float flickAngle = -20;
    

    void Start()
    {
        //HingeJointコンポーネント取得
        this.myHingeJoint = GetComponent<HingeJoint>();
        //フリッパーの傾きを設定
        SetAngle(this.defaultAngle);

    }
    // Update is called once per frame
    void Update()
    {
        //左矢印あるいはAキーを押した時左フリッパーを動かす
        if ((Input.GetKeyDown(KeyCode.LeftArrow) || Input.GetKeyDown(KeyCode.A)) && tag == "LeftFripperTag")
        {
            SetAngle(this.flickAngle);
        }
        //右矢印あるいはDキーを押した時右フリッパーを動かす
        if ((Input.GetKeyDown(KeyCode.RightArrow) || Input.GetKeyDown(KeyCode.D)) && tag == "RightFripperTag")
        {
            SetAngle(this.flickAngle);
        }
        //Sまたは下矢印キーを押した時両フリッパーを動かす
        if ((Input.GetKeyDown(KeyCode.S) || Input.GetKeyDown(KeyCode.DownArrow)) && tag == "LeftFripperTag")
        {
            SetAngle(this.flickAngle);
        }
        if ((Input.GetKeyDown(KeyCode.S) || Input.GetKeyDown(KeyCode.DownArrow)) && tag == "RightFripperTag")
        {
            SetAngle(this.flickAngle);
        }
        //左あるいは右矢印キーが離された時フリッパーを元に戻す
        if (Input.GetKeyUp(KeyCode.LeftArrow) || Input.GetKeyUp(KeyCode.RightArrow))
        {
            SetAngle(this.defaultAngle);
        }
        //AあるいはDキーが離された時フリッパーを元に戻す
        if (Input.GetKeyUp(KeyCode.A) || Input.GetKeyUp(KeyCode.D))
        {
            SetAngle(this.defaultAngle);
        }
        //Sまたは下矢印キーが離された時両フリッパーを元に戻す
        if (Input.GetKeyUp(KeyCode.S) || Input.GetKeyUp(KeyCode.DownArrow))
        {
            SetAngle(this.defaultAngle);
        }

    }
    //フリッパーの傾きを設定
    public void SetAngle(float angle)
    {
        JointSpring jointSpr = this.myHingeJoint.spring;
        jointSpr.targetPosition = angle;
        this.myHingeJoint.spring = jointSpr;
    }

}