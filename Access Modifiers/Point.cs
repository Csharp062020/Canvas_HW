//

namespace Access_Modifiers
{
    internal class Point
    {
        private int _x;
        private int _y;

        internal Point(int x , int y)
        {
            SetX(x);
            SetY(y);
        }

        internal int GetX()
        {
            return _x;
        }

        internal int GetY()
        {
            return _y;
        }


        // i change it , becuse i need it on Move Button to get a status. 
        internal void SetX(int x)
        {
            if (CheckThatThereIsNoException(MyCanvas._maxWidth,MyCanvas._minWidth,x))
            {
                _x = x;
            }
            else
            {
                System.Console.WriteLine("X not allowed");
            }
        }

        internal void SetY(int y)
        {
            if (CheckThatThereIsNoException(MyCanvas._MaxHeight, MyCanvas._minHight, y))
            {
                _y = y;
            }
            else
            {
                System.Console.WriteLine("Y not allowed");
            }
        }

        internal static bool CheckThatThereIsNoException(int maxValue, int minValue, int myValue)
        {
            return (maxValue > myValue) && (minValue< myValue );
        }

        /// <summary>
        ///             // I check that none of the points of the button cross the defined limits
        /// </summary>
        /// <param name="buttonRange"></param>
        /// <returns> true: no cross , false: cross</returns>
        internal static bool CheckThatThereIsNoException(Point point , int xAdd=0,int yAdd=0)
        {
            return CheckThatThereIsNoException(MyCanvas._MaxHeight, MyCanvas._minHight, point.GetY()+ yAdd)
                   &&
                   CheckThatThereIsNoException(MyCanvas._maxWidth, MyCanvas._minWidth, point.GetX()+ xAdd);
        }

        internal static bool CheckThatThereIsNoException(MyButton button, int xAdd = 0, int yAdd = 0)
        {
            return CheckThatThereIsNoException(button.GetTopLeft(), xAdd, yAdd)
                   &&
                   CheckThatThereIsNoException(button.GetBottomRight(), xAdd, yAdd);
        }


        public override string ToString()
        {
            return $"(x,y): ({_x},{_y})";
        }
    }

}
