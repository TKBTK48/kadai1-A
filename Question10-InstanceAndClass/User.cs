/*
* User.cs
*   作成	Rhizome
*------------------------------------------------------------
* Copyright(c) Rhizome Inc. All Rights Reserved.
*/

using System;

public class User
{
    internal int id;
    internal string name;

    /**
  	 * IDと名前を出力する挨拶メソッド
  	 */
    internal void PrintProfile()
    {
        Console.WriteLine("ID" + this.id + ":" + this.name);
    }
}