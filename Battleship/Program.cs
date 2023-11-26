using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using Battleship;

var User = new User();
var Bot = new Bot();
bool Continue = true;
while (Continue)
{
    while (true)
    {
        User.Output(User.Field1);
        User.Strike();
        if (User.Win()) { break; }
        Bot.Strike();
        if (Bot.Win()) { break; }
    }
    Console.SetCursorPosition(30, 1);
    Console.WriteLine("Спасибо за игру! Хотите сыграть еще раз? ");
    if (Console.ReadLine() != "да")
    {
        Console.Clear();
        Continue = false;
    }
}