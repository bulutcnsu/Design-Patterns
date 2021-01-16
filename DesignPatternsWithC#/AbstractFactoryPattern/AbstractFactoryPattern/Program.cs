using System;

namespace AbstractFactoryPattern
{
  public  class Program
    {
       public static void Main(string[] args)
        {

            Originator<CalenderIOSFactory> iosCalender = new Originator<CalenderIOSFactory>("A calender");
            iosCalender.create();


            Originator<CalenderWindowsFactory> wCalender = new Originator<CalenderWindowsFactory>("A calender");
            wCalender.create();

            Originator<UserInterfaceAndroidFactory> andinterface = new Originator<UserInterfaceAndroidFactory>("An user interface");
            andinterface.create();


            Originator<UserInterfaceIOSFactory> iosinterface = new Originator<UserInterfaceIOSFactory>("An interface");
            iosinterface.create();

            Console.ReadLine();


        }
    }
}
