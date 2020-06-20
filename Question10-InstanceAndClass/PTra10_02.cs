/*
 * PTra10_02.cs
 *   作成	Rhizome
 *------------------------------------------------------------
 * Copyright(c) Rhizome Inc. All Rights Reserved.
 */

using System;

public class PTra10_02
{
    public static void Main(string[] args)
    {
        // TODO User型変数 user を宣言してください。
        User user;

        // TODO 変数 user に Userインスタンスを代入してください。
        user = new User();

        // TODO 変数 userのidフィールドに 2000 を代入してください。
        user.id = 2000;

        // TODO 変数 userのnameフィールドに 佐藤二郎 を代入してください。
        user.name = "佐藤二郎";

        // TODO 変数 userの PrintProfileメソッド を呼び出してください。
        user.PrintProfile();
    }
}
