using System;

namespace _45_Lidando_com_variáveis__var__dynamic__object_
{
    class Program
    {
        static void Main(string[] args)
        {
            var myVar = "hello";        //early binding + can not be null
            dynamic myDynamic = null;   //late binding  + can be null


            string age = "90";
            object tempObject = age;
            int newAge = (int)tempObject;
        }
    }
}
