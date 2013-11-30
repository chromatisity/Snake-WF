using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace SnakeForm
{
    public class Snake
    {
        public Rectangle[] snakeBody;
        private SolidBrush brush;
        private int lenght = 30;
        public int x = 20;
        public int y = 0;
        public int width = 10;
        public int height = 10;
        public Color color = Color.Blue;

        public Snake()
        {
            this.snakeBody=new Rectangle[this.lenght];
            this.brush = new SolidBrush(this.color);

            for (int i = 0; i < snakeBody.Length; i++)
            {
                snakeBody[i] = new Rectangle(x, y, width, height);
                x -= 10;
            }
        }
       
        public void Draw (Graphics paper)
        {
            foreach (var element in snakeBody)
            {
                paper.FillRectangle(brush,element);
            }
        }
        public void Draw ()
        {
            for (int i = snakeBody.Length - 1; i > 0; i--)
            {
                snakeBody[i] = snakeBody[i - 1];
            }
        }
        public void Grow()
        {
            List<Rectangle> tempSnake = snakeBody.ToList();
            
            for (int i = 0; i < 4; i++)
            {
                tempSnake.Add(new Rectangle(snakeBody[snakeBody.Length - 1].X, snakeBody[snakeBody.Length - 1].Y, width, height));
            }
            snakeBody = tempSnake.ToArray();
        }
        public bool Contains(int x, int y)
        {
            for (int i = 0; i < snakeBody.Length; i++)
            {
                if (snakeBody[i].X == x && snakeBody[i].Y == y)
                {
                    return true;
                }
            }
            return false;
        }
        public void RandomizeSnakeColor(Random number)
        {
            Color[] colors = new Color[5] {
            
                Color.Red,
                Color.Blue,
                Color.Green,
                Color.Black,
                Color.Yellow
            };
            brush.Color = colors[number.Next(0, 5)];
        }
        public void MoveRight()
        {
            snakeBody[0].X += 2;
        }
        public void MoveLeft()
        {
            snakeBody[0].X -= 2;
        }
        public void MoveUp()
        {
            snakeBody[0].Y -= 2;
        }
        public void MoveDown()
        {
            snakeBody[0].Y += 2;
        }
    }
}
