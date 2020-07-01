using Microsoft.CSharp.RuntimeBinder;
using System;

namespace _72_Interfaces
{
    //Define contrato implementado por classes e structs
    //Herança Multipla
    //Assinaturas de métodos

    interface IControl
    {
        void Paint();
    }

    interface IListBox
    {
        void SetText(string Text);
    }


    interface ITextBox { }

    interface IComboBox : ITextBox, IListBox { }

    interface IDataBound
    {
        void Bind(Binder b);
    }

    public class EditBox : IComboBox, IDataBound
    {
        public void Paint() { }
        void Bind(Binder b) { }
        void SetText(string Text) { }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
