using System;

namespace Program {
    class test1 {
        static void Main() {

int n;
    int a;
    int sum=0;


    Console.WriteLine("enter 4digit num: ");
    n = Convert.ToInt32(Console.ReadLine());

        if(n>=1000&&n<=9999){

        while(n>0){
        a=n%10;
        sum=sum+a;
        n=n/10;

    }
    Console.WriteLine(sum);
    }


        else {
            Console.WriteLine("error");
        }
        }
    }
}