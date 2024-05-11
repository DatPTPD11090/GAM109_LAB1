using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Program
{
    static void Main()
    {
        int a = 10;
        int b = 20;
        MyClass tinh = new MyClass(a, b);
        int kqcong = tinh.cong(a, b);
        System.Console.WriteLine(kqcong);
        int kqtru = tinh.tru(a, b);
        System.Console.WriteLine(kqtru);
    }
}