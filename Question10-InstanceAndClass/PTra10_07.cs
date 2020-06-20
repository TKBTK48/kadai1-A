/*
 * PTra10_07.cs
 *   作成	Rhizome
 *------------------------------------------------------------
 * Copyright(c) Rhizome Inc. All Rights Reserved.
 */

using Question10_InstanceAndClass;
using System;

public class PTra10_07
{
    /*
  	 * PTra10_05で作成したCarクラスを使用します
  	 */

    public static void Main(string[] args)
    {
        // 目的地までの距離
        const int DISTANCE = 300;

        /*
    	 * TODO carインスタンスを3件作成し、それぞれの色、ガソリンを以下のように設定してください。
    	 * 1台目：colorフィールドに"赤"、gasolineフィールドに50
    	 * 2台目：colorフィールドに"青"、gasolineフィールドに60
    	 * 3台目：colorフィールドに"黄"、gasolineフィールドに70
    	 *
    	 * 各carインスタンスメソッドRunを繰り返し使って、それぞれ目的地まで進んでください
    	 * 先にガソリンがなくなった場合は、「x色の車は、目的地に到達できませんでした」を出力してください
    	 * 目的地についた時点で「x色の車は、目的地にまでy時間かかりました。残りのガソリンは、zリットルです」を出力してください
    	 * ※ xは車の色、yはRunメソッドを実行した回数, zは残りのガソリンの数です
    	 * ※ クラス型配列を利用して処理を行なってください。
    	 */
        var car1 = new Car();
        var car2 = new Car();
        var car3 = new Car();
        car1.gasoline = 50;
        car1.color = "赤";
        car2.gasoline = 60;
        car2.color = "青";
        car3.gasoline = 70;
        car3.color = "黄";

        var carlist = new Car[3];
        carlist[0] = car1;
        carlist[1] = car2;
        carlist[2] = car3;
        for (int i = 0; i < 3; i++)
        {
            int d = DISTANCE;
            int y = 0;
            while (true)
            {

                d = d - carlist[i].Run();
                y = y + 1;
                if (carlist[i].gasoline <= 0)
                {
                    Console.WriteLine($"{carlist[i].color}色の車は目的地に到達できませんでした");
                    break;
                }
                else if (d <= 0)
                {
                    Console.WriteLine($"{carlist[i].color}色の車は目的地にまで{y}時間かかりました。残りのガソリンは、{carlist[i].gasoline}リットルです");
                    break;
                }
            }
        }
    }
}
