/*
SEUIF97 Library:
    1 Windows: C:/Windows/system/libseuif97.dll
    2 seuif97.cs

you may use the C# compiler and set the Platform target of application to the same as the dynamic library to build the demo applocation

1  choose the C# compiler

    1.1 The C#5 compiler in Windows 
       
        Add the path of C#5 compiler C:\Windows\Microsoft.NET\Framework64\v4.0.30319\ to the system environment variables Path 

    1.2 The latest C#compiler on x64 libseuif97.dll：

       1.2.1 Using nuget to install the latest version of  C# compiler (https://github.com/dotnet/roslyn)

       1.2.2 mkdir C:\csharp\ for the latest version of  C# compiler,then download nuget to the path

       1.2.3 In the path C:\csharp\, install the latest release without Visual Studio, run one of the following `nuget` command lines:

           >nuget install Microsoft.Net.Compilers   # Install C# and VB compilers
           >nuget install Microsoft.CodeAnalysis    # Install Language APIs and Services

           then the compiler is installed in the path  C:\csharp\Microsoft.Net.Compilers.2.10.0\tools\

       1.2.4 add the path C:\csharp\Microsoft.Net.Compilers.2.10.0\tools\ to the system environment variables Path  

2. Build:
     
 >csc -out:demo.exe demo_seuif97.cs seuif97.cs /platform:"x64"

Run:
./demo

License: this code is in the public domain

Author:   Cheng Maohua
Email:    cmh@seu.edu.cn

Last modified: 2019.01.05

*/
using System;

using seuif97;

namespace demo_seuif97
{
    class demo_seuif97
    {

        static void Main(string[] args)
        {
            double p = 16.13;
            double t = 535.0;
            double h, s, v;
            h = seuif97.Seuif97.seupt(p, t, 4);
            s = seuif97.Seuif97.seupt(p, t, 5);
            v = seuif97.Seuif97.seupt(p, t, 3);
            Console.WriteLine("(p,t) h,s,v {0 :.00} {1:.0} {2:.000} {3:.000} {4:.000}", p, t, h, s, v);

            t = seuif97.Seuif97.seuph(p, h, 1);
            s = seuif97.Seuif97.seuph(p, h, 5);
            v = seuif97.Seuif97.seuph(p, h, 3);
            Console.WriteLine("(p,h) t,s,v {0 :.00} {1:.0} {2:.000} {3:.000} {4:.000}", p, h, t, s, v);
        }
    }
}