using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstProgram : MonoBehaviour
{
    // 変数の形
    // データ型

    // 定数
    //                                 0    1    2
    int[] stage_points = new int[3] {1000,1200,1300};

    List<int> stage_pointList = new List<int>();

    int mario_point = 0;

    int stage = 1;

    void Start()
    {

        stage_pointList.Add(1000);
        stage_pointList.Add(1200);
        stage_pointList.Add(1300);
        //3つのリスト

        stage_pointList.Remove(1200);
        //2つのリスト

        stage_pointList.Clear();
        //0つのリスト

    }
}