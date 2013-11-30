using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace SnakeForm
{
    public partial class SnakeForm : Form
    {
        Food food;
        Random randomFood = new Random();
        Random randomColor = new Random();

        int points = 0;
        string path;
        bool right = true;
        bool left = false;
        bool up = false;
        bool down = false;

        Snake snake = new Snake();
        Graphics paper;

        public SnakeForm()
        {
            InitializeComponent();
            food = new Food(randomFood,randomColor);
        }
        public void Collide()
        {
            for (int i = 1; i < snake.snakeBody.Length - 1; i++)
            {
                if ((snake.snakeBody[0].X == snake.snakeBody[i].X && snake.snakeBody[0].Y == snake.snakeBody[i].Y))
                {
                    GameOver();
                }
                if (snake.snakeBody[0].X < 0)
                {
                    snake.snakeBody[0].X = 761;
                    left = true;
                }
                if (snake.snakeBody[0].X > 761)
                {
                    snake.snakeBody[0].X = 0;
                    right = true;
                }
                if (snake.snakeBody[0].Y < 0)
                {
                    snake.snakeBody[0].Y = 607;
                }
                if (snake.snakeBody[0].Y > 607)
                {
                    snake.snakeBody[0].Y = 0;
                }
            }
        }
        public void HighScore()
        {
            string line;
            List<int> scores = new List<int>();
        
            StreamReader highScores = new StreamReader(path+"HighScores.txt");
            
            while ((line = highScores.ReadLine()) != null)
            { 
                scores.Add(int.Parse(line));
            }
            highScores.Close();
            if (scores.Count < 3)
            {
                for (int i = scores.Count - 1; i < 3 ; i++)
                {
                    scores.Add(0);
                }
            }

            scores.Sort();
            FirstPlayerScoreLabel.Text = "first :" + scores[scores.Count-1].ToString();
            SecondPlayerScoreLabel.Text = "second :" + scores[scores.Count-2].ToString();
            ThirdPlayerScoreLabel.Text = "third :" + scores[scores.Count-3].ToString();

            FirstPlayerScoreLabel.Visible = true;
            SecondPlayerScoreLabel.Visible = true;
            ThirdPlayerScoreLabel.Visible = true;
        }
        public void GameOver()
        {
            timer.Enabled = false;
            MessageBox.Show("Game over!");

            path = Environment.CurrentDirectory;
            var HighScores = new StreamWriter(path+"HighScores.txt", true);
            HighScores.WriteLine(points.ToString());
            HighScores.Close();
           
           

            StartLabel.Visible = true;

            HighScore();
        }
        private void SnakeForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                timer.Enabled = true;
                StartLabel.Visible = false;
                FirstPlayerScoreLabel.Visible = false;
                SecondPlayerScoreLabel.Visible =false;
                ThirdPlayerScoreLabel.Visible = false;

                snake = new Snake();
            }
           
            if (e.KeyData == Keys.Right && left == false)
            {
                right=true;
                left = false;
                up = false;
                down = false;
            }
            if (e.KeyData==Keys.Left && right == false)
            {
                left=true;
                right = false;
                up = false;
                down = false;
            }
            if (e.KeyData==Keys.Up && down == false)
            {
                up=true;
                right = false;
                left = false;
                down = false;
            }
            if (e.KeyData==Keys.Down && up == false)
            {
                down=true;
                right = false;
                left = false;
                up = false;
            } 
        }

        private void SnakeForm_Paint(object sender, PaintEventArgs e)
        {
            paper = e.Graphics;
            food.DrawFood(paper);
           
            snake.color = Color.Aqua;
            snake.Draw(paper);
        }
        public void GameSpeed(int score)
        {
            if (score > 100 && score < 200)
            {
                timer.Interval = 5;
            }
            if (score > 200 && score < 300)
            {
                timer.Interval = 3;
            }
            if (score > 300 && score < 400)
            {
                timer.Interval = 1;
            }
        }
        private void timer_Tick(object sender, EventArgs e)
        {

            snake.Draw();
            if (right){snake.MoveRight();}
           
            if (left){snake.MoveLeft();}
            
            if (up) {snake.MoveUp();}
           
            if (down) {snake.MoveDown();}

            if (snake.snakeBody[0].IntersectsWith(food.food))
            {
                do
                {
                    food.FoodRandomizer(randomFood);
                } while (snake.Contains(food.food.X,food.food.Y));
                food.FoodRandomizer(randomFood);
                snake.RandomizeSnakeColor(randomColor);
                snake.Grow();
                points += 10;
                PlayerScore.Text = points.ToString();
                
            }
            GameSpeed(points);
            Collide();
            this.Invalidate();
        }

        
    }
}
