using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Program
{
    //public Program()
    //{
    //    //나는 Print1를 실행하고 Print2를 실행한다.
    //    Executer(1);
    //    //나는 Print2를 실행하고 Print1를 실행한다.
    //    Executer(2);
    //}
    //private void Executer(int type)
    //{
    //    if (type == 1)
    //    {
    //        Print1();
    //        Print2();
    //    }
    //    else if (type == 2)
    //    {
    //        Print2();
    //        Print1();
    //    }
    //}
    //private void Print1()
    //{
    //    Debug.Log("Print1");
    //}
    //private void Print2()
    //{
    //    Debug.Log("Print2");
    //}

    public Program()
    {
        //    Action print1 = delegate ()
        //    {
        //        Debug.Log("Print1");
        //    };
        //    Action print2 = delegate ()
        //    {
        //        Debug.Log("Print2");
        //    };

        //    //나는 Print1를 실행하고 Print2를 실행한다.
        //    Executer(print1, print2);
        //    //나는 Print2를 실행하고 Print1를 실행한다.
        //    Executer(print2, print1);

        //    //그냥 추가하고 싶으면 아래와 같이 해도..
        //    Executer(print1, print2, delegate ()
        //    {
        //        Debug.Log("Print3");
        //    });
        //}

        //private void Executer(params Action[] exec)
        //{
        //    foreach (var e in exec)
        //    {
        //        e();
        //    }
        //}



        //파라미터 1번째 string, 파라미터 2번째 string
    //    Action<string, string> action = delegate (string a, string b)
    //{
    //    Debug.Log(a + " " + b);
    //};
    //    //파라미터 첫 번째 string, 파라미터 두 번째 string, return 값 bool
    //    Func<string, string, bool> func = delegate (string a, string b)
    //    {
    //        if (a != null && b != null)
    //        {
    //            return true;
    //        }
    //        return false;
    //    };

    //    var hello = "hello";
    //    var world = "world";
    //    if (func(hello, world))
    //    {
    //        action(hello, world);
    //    }


        // 파라미터 1번째 string, 파라미터 2번째 string
        //Action<string, string> action = (a,b) =>
        //    {
        //        Debug.Log(a + " " + b);
        //    };
        //    //파라미터 첫 번째 string, 파라미터 두 번째 string, return 값 bool
        //    Func<string, string, bool> func = (a, b) =>
        //    {
        //        if (a != null && b != null)
        //        {
        //            return true;
        //        }
        //        return false;
        //    };
        //    var hello = "Hello";
        //    var world = "World";
        //    if (func(hello, world))
        //    {
        //        action(hello, world);
        //    }
        //}
    }
}