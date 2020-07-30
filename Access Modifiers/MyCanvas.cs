//

using System;

namespace Access_Modifiers
{
    public class MyCanvas
    {
        public static int _maxWidth = 800;
        public static int _MaxHeight = 800;
        public static int _minWidth = 0;
        public static int _minHight = 0;

        static int _buttonIndex = 0;
        static int _MaxButtons = 3;
        static MyButton[] _buttons = new MyButton[_MaxButtons];


       public static bool CreateNewButton(int xTopLeft, int yTopleft, int xBRight, int yBRight)
        {
            if (_buttonIndex< _MaxButtons)
            {
                _buttons[_buttonIndex] = new MyButton(new Point(xTopLeft, yTopleft), new Point(xBRight, yBRight));
                _buttonIndex++;
                return true;
            }

            return false;
        }


       public static bool MoveButton(int buttonNumber, int x, int y)
        {

            if (Point.CheckThatThereIsNoException(_buttons[buttonNumber], x, y))
            {
                // get old values and add them the x,y 
                int x1 = _buttons[buttonNumber].GetTopLeft().GetX() + x;
                int y1 = _buttons[buttonNumber].GetTopLeft().GetY() + y;
                int x2 = _buttons[buttonNumber].GetBottomRight().GetX() + x;
                int y2 = _buttons[buttonNumber].GetBottomRight().GetY() + y;

                // set the new values 
                _buttons[buttonNumber].GetTopLeft().SetX(x1);
                _buttons[buttonNumber].GetTopLeft().SetY(y1);
                _buttons[buttonNumber].GetBottomRight().SetX(x2);
                _buttons[buttonNumber].GetBottomRight().SetY(y2);
                Console.WriteLine("The button has moved to the new location");
                return true;
            }
            else
            {
                Console.WriteLine("No change was made, the new location is out of range");
                return false;
            }

        }
       public static bool DeleteLastButton()
        {
            if (_buttonIndex>0)
            {
                _buttons[_buttonIndex - 1] = null;
                _buttonIndex--;
                return true;
            }
            return false;
        }
       public static void ClearAllButtons()
        {
            while (DeleteLastButton())
            {
            }

        }

       public static int GetCurrentNumberOfButtons( )
        {
            return _buttonIndex;
        }

       public static int GetMaxNumberOfButtons( )
        {
            return _MaxButtons;
        }

       public static int GetTheMaxWidthOfAButtons()
        {
            int maxWith = 0;
            if (_buttonIndex>0)
            {
                for (int i = 0; i < _buttonIndex; i++)
                {
                    if (_buttons[i].GetWidth()> _maxWidth)
                    {
                        maxWith = _buttons[i].GetWidth();
                    }
                }
            }

            return maxWith;

        }

       public static int GetTheMaxHeightOfAButtons()
        {
            int maxHeight = 0;
            if (_buttonIndex > 0)
            {
                for (int i = 0; i < _buttonIndex; i++)
                {
                    if (_buttons[i].GetHeight() > maxHeight)
                    {
                        maxHeight = _buttons[i].GetHeight();
                    }
                }
            }

            return maxHeight;
        }

       public static bool IsPointInsideButton(int x, int y)
        {
            for (int i = 0; i < _buttonIndex; i++)
            {
                int buttonMinHight = _buttons[i].GetBottomRight().GetY();
                int buttonMaxHight = _buttons[i].GetTopLeft().GetY();
                int buttonRight = _buttons[i].GetBottomRight().GetX();
                int buttonLeft = _buttons[i].GetTopLeft().GetX();

                
                return y>=buttonMinHight
                       &&  
                       y <= buttonMaxHight 
                       && 
                       x<=buttonRight
                       && 
                       x >= buttonLeft;
            }

            return false;
        }

       private static bool IsPointInsideButton(Point point)
        {
            return IsPointInsideButton(point.GetX(), point.GetY());
        }

       private static bool IsPointInsideButton(MyButton button)
       {
           bool a = IsPointInsideButton(button.GetTopLeft());
           bool b = IsPointInsideButton(button.GetBottomRight());
           bool c = IsPointInsideButton(button.GetBottomRight().GetX(), button.GetTopLeft().GetY());
           bool d = IsPointInsideButton(button.GetTopLeft().GetX(),button.GetBottomRight().GetY());
            return a || b || c || d ;

       }

       public static bool CheckIfAnyButtonIsOverTapping()
        {
            int count = 0;
            for (int i = 0; i < _buttonIndex; i++)
            {
                if (IsPointInsideButton(_buttons[i]))
                {
                    count++;
                    if (count>1)
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        public static void Print()
        {
            for (int i = 0; i < _buttonIndex; i++)
            {
                Console.WriteLine($"Top left: {_buttons[i].GetTopLeft().ToString()} Button Right {_buttons[i].GetBottomRight().ToString()} width: {_buttons[i].GetWidth()} Hight: {_buttons[i].GetHeight()}" );
            }

            Console.WriteLine("done to print all buttons");

        }
        public static void Print(int i)
        {
                Console.WriteLine($"Top left: {_buttons[i].GetTopLeft().ToString()} Button Right {_buttons[i].GetBottomRight().ToString()} width: {_buttons[i].GetWidth()} Hight: {_buttons[i].GetHeight()}");
        }

        public override string ToString()
        {
            return $"{base.ToString()} {_maxWidth} ,{_MaxHeight},{_buttonIndex}" ;
        }

    }
}
