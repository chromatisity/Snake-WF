using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace SnakeForm
{
    class Food
    {
        private int x;
        private int y;
        private int width;
        private int height;
        public SolidBrush brush;
        public Rectangle food;

        Color[] colors = new Color[5] {
            
                Color.Red,
                Color.Blue,
                Color.Green,
                Color.Black,
                Color.Yellow
            };
            

        public Food(Random randomFood,Random color)
        {
           x = randomFood.Next(0, 444);
           y = randomFood.Next(0, 444);
           width = 10;
           height = 10;

           Color[] colors = new Color[5] {
            
                Color.Red,
                Color.Blue,
                Color.Green,
                Color.Black,
                Color.Yellow
            };
           int randomColor = color.Next(0, 5);
            
           brush = new SolidBrush(colors[randomColor]);
           food = new Rectangle(x,y,width,height);
        }
        public void FoodRandomizer(Random randomFood)
        {
            x = randomFood.Next(0, 444);
            y = randomFood.Next(0, 444);

           
            int randomColor = randomFood.Next(0, 5);

            brush = new SolidBrush(colors[randomColor]);
        }
        public void DrawFood(Graphics paper)
        {
            food.X = x;
            food.Y = y;
            paper.FillRectangle(brush,food);
        }
       
    }
}
