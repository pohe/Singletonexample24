﻿// See https://aka.ms/new-console-template for more information
class InsertCodeHere
{
    public void MyCode()
    {
        MySingleton ms1 = new MySingleton();
        MySingleton ms2 = new MySingleton();
        MySingleton ms3 = new MySingleton();

        Console.WriteLine("Instance number for ms1 : " + ms1.getInstanceNo());
        Console.WriteLine("Instance number for ms2 : " + ms2.getInstanceNo());
        Console.WriteLine("Instance number for ms3 : " + ms3.getInstanceNo());
        Console.WriteLine("Instance count is : " + MySingleton.getInstanceCount());
    }
}