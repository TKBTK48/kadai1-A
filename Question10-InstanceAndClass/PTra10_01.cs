/*
 * PTra10_01.cs
 *   作成	Rhizome
 *------------------------------------------------------------
 * Copyright(c) Rhizome Inc. All Rights Reserved.
 */

using System;

public class PTra10_01
{
    public static void Main(string[] args)
    {
        // TODO User型変数 user を宣言してください。
        User user;

        // TODO 変数 user に Userインスタンスを代入してください。
        user = new User();


        // TODO 変数 userのidフィールドに 1000 を代入してください。
        user.id = 1000;

        // TODO 変数 userのnameフィールドに 山田太郎 を代入してください。
        user.name = "山田太郎";

        // TODO 変数 userの idフィールド を出力してください。
        Console.WriteLine(user.id);

        // TODO 変数 userの nameフィールド を出力してください。
        Console.WriteLine(user.name);
    }
}
