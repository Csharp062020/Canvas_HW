using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using Access_Modifiers;

namespace Client
{
    class Program
    {
        static void Main(string[] args)
        {
            UT();

        }

        static void UT()
        {
            Console.WriteLine($"Access_Modifiers.MyCanvas.GetMaxNumberOfButtons();{Access_Modifiers.MyCanvas.GetMaxNumberOfButtons()}");
            Console.WriteLine($"Access_Modifiers.MyCanvas.GetCurrentNumberOfButtons();{Access_Modifiers.MyCanvas.GetCurrentNumberOfButtons()}");
            Console.WriteLine($"Access_Modifiers.MyCanvas.GetTheMaxHeightOfAButtons();{Access_Modifiers.MyCanvas.GetTheMaxHeightOfAButtons()}");
            Console.WriteLine($"Access_Modifiers.MyCanvas.GetTheMaxWidthOfAButtons();{Access_Modifiers.MyCanvas.GetTheMaxWidthOfAButtons()}");
            Console.WriteLine($"Access_Modifiers.MyCanvas._MaxHeight;{Access_Modifiers.MyCanvas._MaxHeight}");
            Console.WriteLine($"Access_Modifiers.MyCanvas._maxWidth;{Access_Modifiers.MyCanvas._maxWidth}");
            Console.WriteLine();

            Console.WriteLine("-------------------------------------------");
            Console.WriteLine("Check create buttons:");
            Console.WriteLine("-------------------------------------------");
            Console.WriteLine($"MyCanvas.GetCurrentNumberOfButtons() {MyCanvas.GetCurrentNumberOfButtons()}");
            Access_Modifiers.MyCanvas.CreateNewButton(6, 12, 9, 7);
            Console.WriteLine($"MyCanvas.GetCurrentNumberOfButtons() {MyCanvas.GetCurrentNumberOfButtons()}");
            Access_Modifiers.MyCanvas.CreateNewButton(3, 9, 8, 6);
            Console.WriteLine($"MyCanvas.GetCurrentNumberOfButtons() {MyCanvas.GetCurrentNumberOfButtons()}");
            Access_Modifiers.MyCanvas.CreateNewButton(10, 20, 25, 10);
            Console.WriteLine($"MyCanvas.GetCurrentNumberOfButtons() {MyCanvas.GetCurrentNumberOfButtons()}");
            Console.WriteLine();

            Console.WriteLine("-------------------------------------------");
            Console.WriteLine("print all buttons:");
            Console.WriteLine("-------------------------------------------");
            Access_Modifiers.MyCanvas.Print();
            Console.WriteLine();


            //Access_Modifiers.MyCanvas.CreateNewButton(200, 200, 5, 50);
            Console.WriteLine("-------------------------------------------");
            Console.WriteLine("Check If Any Button Is Over Tapping");
            Console.WriteLine("-------------------------------------------");
            Console.WriteLine($"CheckIfAnyButtonIsOverTapping: {MyCanvas.CheckIfAnyButtonIsOverTapping()}");

            Console.WriteLine("-------------------------------------------");
            Console.WriteLine("check Delete Last Button");
            Console.WriteLine("-------------------------------------------");
            Access_Modifiers.MyCanvas.DeleteLastButton();
            Access_Modifiers.MyCanvas.Print();
            Console.WriteLine();

            Console.WriteLine("-------------------------------------------");
            Console.WriteLine("check move Button:");
            Console.WriteLine("-------------------------------------------");
            Console.WriteLine("values before Move:");
            Access_Modifiers.MyCanvas.Print(0);
            Console.WriteLine($"move has done ? :{Access_Modifiers.MyCanvas.MoveButton(0, 5, 10)} x move: 5 , y move:10 new parameter: ");
            Access_Modifiers.MyCanvas.Print(0);
            Console.WriteLine();

            //Access_Modifiers.MyCanvas.CreateNewButton(200, 200, 5, 50);
            Console.WriteLine("-------------------------------------------");
            Console.WriteLine("Check If Any Button Is Over Tapping");
            Console.WriteLine("-------------------------------------------");
            Console.WriteLine($"CheckIfAnyButtonIsOverTapping: {MyCanvas.CheckIfAnyButtonIsOverTapping()}");


            Console.WriteLine("-------------------------------------------");
            Console.WriteLine("check with wong parameter more then canvas area: ");
            Console.WriteLine("-------------------------------------------");
            Console.WriteLine("check move Button:");
            Console.WriteLine("values before Move:");
            Access_Modifiers.MyCanvas.Print(0);
            int xMove = 50;
            int yMove = 790;
            bool hasMoved = Access_Modifiers.MyCanvas.MoveButton(0, xMove, yMove);
            Console.WriteLine();
            Console.WriteLine($"move has done ? :{hasMoved} : values of point is:");
            Access_Modifiers.MyCanvas.Print(0);
            Console.WriteLine();

            Console.WriteLine("values before Move:");
            Access_Modifiers.MyCanvas.Print(0);
            xMove = 50;
            yMove = 780;
            hasMoved = Access_Modifiers.MyCanvas.MoveButton(0, xMove, yMove);
            Console.WriteLine();

            Console.WriteLine($"move has done ? :{hasMoved} : values of point is:");
            Access_Modifiers.MyCanvas.Print(0);
            Console.WriteLine();


            Console.WriteLine("-------------------------------------------");
            Console.WriteLine("print all buttons:");
            Console.WriteLine("-------------------------------------------");
            Access_Modifiers.MyCanvas.Print();
            Console.WriteLine();

            Console.WriteLine("-------------------------------------------");
            Console.WriteLine("check ClearAllButtons");
            Console.WriteLine("-------------------------------------------");
            Access_Modifiers.MyCanvas.ClearAllButtons();
            Access_Modifiers.MyCanvas.Print();
            Console.WriteLine();
        }
}
}
