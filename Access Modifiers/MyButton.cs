//

namespace Access_Modifiers
{
    internal class MyButton
    {
        protected Point _topLeft;
        protected Point _bottomRight;
        private int _width;
        private int _height;

        internal MyButton(Point topLeft, Point bottomRight)
        {
            if (checkButtonValidity(topLeft, bottomRight))
            {
                _topLeft = topLeft;
                _bottomRight = bottomRight;
                CalcWH();
            }

        }

        internal bool checkButtonValidity(Point topLeft, Point buttomRight)
        {
            return topLeft.GetY() > buttomRight.GetY() 
                   && buttomRight.GetX() > topLeft.GetX();
        }

        internal int GetWidth()
        {
            return _width;
        }

        internal int GetHeight()
        {
            return _height;
        }

        private void CalcWH()
        {
            _height = _topLeft.GetY() - _bottomRight.GetY();
            _width = _bottomRight.GetX() - _topLeft.GetX();
        }
        internal bool SetTopLeft(Point point)
        {

            if (checkButtonValidity(point, _bottomRight))
            {
                _topLeft = point;
                CalcWH();
                return true;
            }
            return false; 
        }

        internal bool SetBottomRight(Point point)
        {
            if (checkButtonValidity(_topLeft, point))
            {
                _bottomRight = point;
                CalcWH();
                return true;
            }
            return false;
        }

        internal Point GetTopLeft()
        {
            return _topLeft;
        }

        internal Point GetBottomRight()
        {
            return _bottomRight;
        }

        public override string ToString()
        {
            return $"{base.ToString()} {_topLeft.ToString()},{_topLeft.ToString()} ,{_bottomRight},{_height} ";
        }
    }
}
