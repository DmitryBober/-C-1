﻿int a = 89;
int b = 42;
int c = 99;
int max = a;

if (a > max) max = a;
if (b > max) max = b;
if (c > max) max = c;

Console.Write ("max = ");
Console.WriteLine (max);