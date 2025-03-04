using Erisim_Belirleyiciler_Ve_Degiskenler;
using System;


    class Program
{
    static void Main()
    {
        IAracHareketleri Bmw = new Bmw();
        IAracHareketleri Mercedes = new Mercedes();
        IAracHareketleri Porsche = new Porsche();

        Console.WriteLine("bmw'nin hareketleri");
        Bmw.Git();
        Bmw.Yuz();
        Bmw.Uc();

        Console.WriteLine("mercedes'in hareketleri");
        Mercedes.Git();
        Mercedes.Yuz();
        Mercedes.Uc();

        Console.WriteLine("porsche'nin hareketleri");
        Porsche.Git();
        Porsche.Yuz();
        Porsche.Uc();

    }


}