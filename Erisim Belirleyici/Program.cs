using System;

namespace Erisim_Belirleyici
{
    class Program
    {
        static void Main(string[] args)
        {
            A a=new A();
            a.A_sayi = 4;
            a.B_internal_sayi = 5;
            //a.B_sayi = 5;
            a.B_protected_internal_sayi=6;
            a.yaz();
            
             
        }
    }
    /*
     * Protected kullanıldığında kalıtım ile aktarıldığında diğer class ulaşır fakat ana programdan buna ulaşılamaz   
     * internal kullandığmızda sadece bulunduğu program  yada kalıtım ile aktırıldığı yerden ulaşılır
     * protected internal kullanıldığında sadece bulunduğu class içerisinden ulaşılır
     */
    class A :B
    {
        public int A_sayi;
        
        public void yaz()
        {
            Console.WriteLine(B_sayi);
            B_internal_sayi=101;
        }
    }
    class B 
    {
        protected int B_sayi=50;
        internal int B_internal_sayi;
        protected internal int B_protected_internal_sayi;
    }
}
