/*
 * PTra10_04.cs
 *   作成	Rhizome
 *------------------------------------------------------------
 * Copyright(c) Rhizome Inc. All Rights Reserved.
 */

/*
 * TODO 以下の仕様のクラスを作成してください
 * （このファイルとは別に、新しくcsファイルを作成してください）
 *
 * クラス名
 * 		Calculation
 * フィールド
 * 		baseNum		:	int型
 * メソッド
 * 		戻り値(なし)、メソッド名(Add)、引数(int num)
 * 		フィールドbaseNum に引数num を加える
 */
using Question10_InstanceAndClass;
using System;
using System.Runtime.CompilerServices;

public class PTra10_04
{
    public static void Main(string[] args)
    {
        // 以下の問題はCalculationクラスを作成してから解いてください

        // TODO Calculation型変数 cal をCalculation型のインスタンスで初期化してください。
        var cal = new Calculation();

        // TODO 変数 calの baseNumフィールドに 100 を代入してください。
        cal.baseNum = 100;

        // TODO 変数 calの Addメソッドを引数に100を渡して呼び出してください。
        cal.Add(100);

        // TODO 変数 calの baseNumフィールドを出力してください。
        // ※ 200 と出力されれば正解
        Console.WriteLine($"{cal.baseNum}");

    }
}
