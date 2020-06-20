/*
 * PTra10_03.cs
 *   作成	Rhizome
 *------------------------------------------------------------
 * Copyright(c) Rhizome Inc. All Rights Reserved.
 */

/*
 * TODO 以下の仕様のクラスを作成してください
 * （このファイルとは別に、新しくcsファイルを作成してください）
 *
 * クラス名
 * 		Student
 * フィールド
 * 		studentId	:	int型
 * 		name		:	string型
 * 		mail		:	string型
 * 		password	:	string型
 * メソッド
 * 		なし
 */

using Question10_InstanceAndClass;
using System;

public class PTra10_03
{
    public static void Main(string[] args)
    {
        // 以下の問題はStudentクラスを作成してから解いてください

        // TODO Student型変数 student をStudent型のインスタンスで初期化してください。
        Student student = new Student();

        // TODO 変数 studentの studentIdフィールドに 10 を代入してください。
        student.studentId = 10;

        // TODO 変数 studentの nameフィールドに 田中二郎 を代入してください。
        student.name = "田中二郎";

        // TODO 変数 studentの mailフィールドに test@mail.com を代入してください。
        student.mail = "test@mail.com";

        // TODO 変数 studentの passwordフィールドに pass を代入してください。
        student.password = "pass";

        // TODO studentの全てのフィールド(studentId, name, mail, password)それぞれを出力してください
        Console.WriteLine($"{student.studentId} {student.name} {student.mail} {student.password}");
    }
}
