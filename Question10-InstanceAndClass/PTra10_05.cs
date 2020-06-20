/*
 * PTra10_05.cs
 *   作成	Rhizome
 *------------------------------------------------------------
 * Copyright(c) Rhizome Inc. All Rights Reserved.
 */

/*
 * TODO 以下の仕様のクラスを作成してください（新しくcsファイルを作成してください）
 *
 * クラス名
 * 		Car
 * フィールド
 * 		color			:	string型
 * 		gasoline		:	int型
 * メソッド
 * 		戻り値(int)、メソッド名(Run)、引数(なし)
 * 			gasolineフィールドの値を1減らして、ランダムな距離(1～15)進む（戻り値が進んだ距離）
 * 			gasolineフィールドが負の数になった場合（もう進めない）は-1を返します。
 */

using Question10_InstanceAndClass;
using System;

public class PTra10_05
{
    public static void Main(string[] args)
    {
        // 以下の問題はCarクラスを作成してから解いてください

        // TODO Car型変数 car をCar型のインスタンスで初期化してください。
        var car = new Car();

        // TODO 変数 carの colorフィールドに 赤 を代入してください。
        car.color = "赤";

        // TODO 変数 carの gasolineフィールドに 50 を代入してください。
        car.gasoline = 50;

        // 目的地までの距離
        const int DISTANCE = 300;

        /*
    	 * TODO 変数carに格納されているインスタンスメソッドRunを繰り返し使って、目的地まで進んでください
    	 * 先にガソリンがなくなった場合は、「x色の車は目的地に到達できませんでした」を出力してください
    	 * 目的地についた時点で「x色の車は目的地にまでy時間かかりました。残りのガソリンは、zリットルです」を出力してください
    	 * xは車の色、yはRunメソッドを実行した回数, zは残りのガソリンの数です
    	 */
        int d = DISTANCE;
        int y = 0;
        while (true)
        {

            d = d - car.Run();
            y = y + 1;
            if (car.gasoline <= 0)
            {
                Console.WriteLine($"{car.color}色の車は目的地に到達できませんでした");
                break;
            }
            else if (d <= 0)
            {
                Console.WriteLine($"{car.color}色の車は目的地にまで{y}時間かかりました。残りのガソリンは、{car.gasoline}リットルです");
                break;
            }
        }

    }
}
