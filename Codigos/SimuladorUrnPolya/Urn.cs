using System;
using System.Collections.Generic;


namespace UrnPolya
{

    public class Urn
    {

        private int[] balls; //  it keeps the quantity of each color of balls. each colors is identified by their index in the array.
        private int[] initBalls; // it keeps the init quantity of balls.
        private int totalcolorsnumber; // it keeps the number of diferente colors in the urn.
        private int totalballs;// total of balls in the urn.
        private int[,] matrix; // matrix of reposition.
        private double[,] proportions; // it keeps the proportions of each color allong the execution of the simulation.
        private List<int> urn; // the urn it self is represented by a list of balls.

        public Urn(int[,] m, int[] b)
        {

            this.balls = b;
            this.initBalls = b;
            this.totalballs = 0;
            this.totalcolorsnumber = this.initBalls.Length;
            this.matrix = m;
            this.urn = new List<int>();// begin the urn list 
            for (int i = 0; i < this.balls.Length; i++)
            {
                for (int j = 0; j < this.balls[i]; j++)
                {
                    urn.Add(i); //adding the initial balls to the urn. remenber that the index i represent the ball color.    
                    this.totalballs += 1;
                }
            }
        }

        public int getBall(int index)
        {
            return this.urn[index];
        }

        public int getTotalBalls()
        {
            return this.totalballs;
        }

        public int getTotalColorsNumber()
        {
            return this.totalcolorsnumber;
        }

        public int getNumberOfBalls(int color)
        {
            return this.balls[color];
        }
        public Boolean reset()
        {
            this.balls = this.initBalls;
            this.urn.Clear();
            this.totalballs = 0;
            this.proportions = null;
            for (int i = 0; i < this.balls.Length; i++)
            {
                for (int j = 0; j < this.balls[i]; j++)
                {
                    urn.Add(i); //adding the initial balls to the urn. remenber that the index i represent the ball color.    
                    this.totalballs += 1;
                }
            }
            return true;
        }

        public Boolean simulation(int steps)
        {
            Random rm = new Random();
            this.proportions = new double[steps + 1, this.totalcolorsnumber];
            for (int i = 0; i < this.totalcolorsnumber; i++)
            {
                this.proportions[0, i] = this.getProportionOfBall(i);
            }
            for (int i = 1; i <= steps; i++)
            {
                int index = rm.Next(this.totalballs);
                int color = this.urn[index];
                for (int j = 0; j < this.totalcolorsnumber; j++)
                {
                    this.balls[color] += this.matrix[j, color];
                    this.totalballs += this.matrix[j, color];
                    for (int k = 0; k < this.matrix[j, color]; k++)
                    {
                        this.urn.Add(j);
                    }
                    this.proportions[i, j] = this.getProportionOfBall(j);
                }
            }
            return true;
        }

        public double getProportionOfBall(int color)
        {
            return ((double)this.balls[color] / (double)this.totalballs);
        }

        public double[,] getProportions()
        {
            return this.proportions;
        }
    }
}