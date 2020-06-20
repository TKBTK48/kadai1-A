/*
 * PTra10_06.cs
 *   作成	Rhizome
 *------------------------------------------------------------
 * Copyright(c) Rhizome Inc. All Rights Reserved.
 */

using System;
using System.Linq;

public class PTra10_06
{
    /**
  	 * @param args
  	 */
    public static void Main(string[] args)
    {
        // TODO User型の変数が3つ入る配列userListを宣言・確保してください
        var userList = new User[3];

        // TODO User型変数のインスタンスをuser1, user2, user3という名前で3つ作成してください。
        var user1 = new User();
        var user2 = new User();
        var user3 = new User();

        /*
    	 *  TODO 作成した3つのインスタンスのフィールドにそれぞれ以下を代入してください。
    	 *  user1	: idフィールドに 1、nameフィールドに 一郎
    	 *  user2	: idフィールドに 2、nameフィールドに 二郎
    	 *  user3	: idフィールドに 3、nameフィールドに 三郎
    	 */
        user1.id = 1;
        user1.name = "一郎";
        user2.id = 2;
        user2.name = "二郎";
        user3.id = 3;
        user3.name = "三郎";

        // TODO userListに作成したuser1, user2, user3を追加してください。
        userList[0] = user1;
        userList[1] = user2;
        userList[2] = user3;

        // TODO 繰り返しを使ってuserListの中身を順番に取り出してPrintProfileメソッドを実行してください。
        for (int i = 0; i < 3; i++)
        {
            userList[i].PrintProfile();
        }

    }
}
