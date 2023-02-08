namespace змейка
{
    internal class Program
    {

        public void logicOfGame(int mode)
        {
            //Поле = new Поле();
            tailX[0] = x;
            tailY[0] = y;
            int prevx = tailX[0];
            int prevy = tailY[0];
            int prev2X, prev2Y;
            for (int i = 1; i < ntail; i++)
            {
                prev2X = tailX[i];
                prev2Y = tailY[i];
                tailX[i] = prevx;
                tailY[i] = prevy;
                prevx = prev2X;
                prevy = prev2Y;
            }
            switch (dir)
            {
                case EActiv.LEFT:
                    x--;
                    break;
                case EActiv.RIGHT:
                    x++;
                    break;
                case EActiv.DOWN:
                    y++;
                    break;
                case EActiv.UP:
                    y--;
                    break;

            }
            if (mode == 2)
            {
                if (x == width || x == 0 || y == height || y == 0)
                {
                    gameOver = true;
                }
            }
            if (mode == 1 || mode == 0)
            {
                if (x >= width)
                    x = 0;
                else if (x < 0)
                    x = width - 1;
                if (y >= height)
                    y = 0;
                else if (y < 0)
                    y = height - 1;
            }
            for (int i = 0; i < ntail; i++)
            {
                if (tailX[i] == x && tailY[i] == y)
                {
                    gameOver = true;
                }
            }
        }
}