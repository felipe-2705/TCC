﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace UrnPolya
{

    public class Urn
    {

        protected int[] balls; //  it keeps the quantity of each color of balls. each colors is identified by their index in the array.
        protected int[] initBalls; // it keeps the init quantity of balls.
        protected int totalcolorsnumber; // it keeps the number of diferente colors in the urn.
        protected int totalballs;// total of balls in the urn.
        protected int[,] matrix; // matrix of reposition.
        protected double[,] proportions; // it keeps the proportions of each color allong the execution of the simulation.
        protected List<int> urn; // the urn it self is represented by a list of balls.

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
            for (int color = 0; color < this.totalcolorsnumber; color++)
            {
                this.proportions[0, color] = this.getProportionOfBall(color);
            }
            for (int iterations = 1; iterations <= steps; iterations++)
            {
                int index = rm.Next(this.totalballs);
                int color = this.urn[index];
                this.insert_balls(iterations, color);
                
            }
            return true;
        }

        protected void insert_balls(int iteration, int column)
        {
            for (int color = 0; color < this.totalcolorsnumber; color++)
            {
                this.balls[color] += this.matrix[color, column];
                this.totalballs += this.matrix[color, column];
                for (int c = 0; c < this.matrix[color, column]; c++)
                {
                    this.urn.Add(color);
                }
                this.proportions[iteration, color] = this.getProportionOfBall(color);
            }
        }

        public Boolean simulation(int steps, BackgroundWorker b)
        {
            Random rm = new Random();
            this.proportions = new double[steps + 1, this.totalcolorsnumber];
            for (int color = 0; color < this.totalcolorsnumber; color++)
            {
                this.proportions[0, color] = this.getProportionOfBall(color);
            }
            for (int iterations = 1; iterations <= steps; iterations++)
            {
                int index = rm.Next(this.totalballs);
                int color = this.urn[index];
                this.insert_balls(iterations, color);
                b.ReportProgress((iterations * 100) / steps);
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

        public static List<double[]> probability_of_colors_ration(Urn u,int steps, int iterations, BackgroundWorker b)
        {
           List<double[]> result = new List<double[]>();
            int valor_pos = u.getTotalColorsNumber();
            Boolean flag = false;

            for (int i = 0; i < iterations; i++)
            {
                u.simulation(steps);
               
                

                for (int j = 0; j < u.getTotalColorsNumber(); j++)
                {
                    double valor_cor = u.getProportionOfBall(j);
                    flag = false;
                    if (result.Count == 0)
                    {
                        double[] novo = new double[valor_pos + 1]; // esse valor guarda a razao e quantas vezes aquele valor apareceu para cada cor sendo que o index do array é a cor. 
                        novo[valor_pos] = valor_cor;
                        novo[j]++;
                        result.Add(novo);
                    }
                    else
                    {
                        foreach (double[] aux in result)
                        {
                            if (Math.Floor(aux[valor_pos] * 1000) == (Math.Floor(valor_cor * 1000)))
                            {
                                result[result.IndexOf(aux)][j]++;
                                flag = true;
                                break;
                            }
                        }

                        if (flag == false)
                        {
                            double[] novo = new double[valor_pos + 1];
                            novo[valor_pos] = valor_cor;
                            novo[j]++;
                            result.Add(novo);
                        }

                    }
                    
                }
                u.reset();
                b.ReportProgress((i*100)/iterations);
            }

            bool ordenado = true;
            for(int i =0;i< result.Count-1; i++)
            {
               for(int j = 0; j < result.Count - i-1; j++)
                {
                    if (result[j][valor_pos] > result[j + 1][valor_pos])
                    {
                        double[] aux = result[j];
                        result[j]=result[j + 1];
                        result[j + 1] = aux;
                        ordenado = false;
                    }
                    
                }
                if (ordenado)
                {
                    break;
                }
            }

            return result;


        }
    }


    ///////////////////////////////////////////////// model with a bad player urn/ lapso de memoria ////////////////////////////////////////////////////////
    
    public class Urn_memory_lapse:Urn
    {
        private double LapseProbability;
        private double[] BaseProbabilityColor;

         public Urn_memory_lapse(int[,] m, int[] b, double LapseProbability, double[] BaseProbabilityColor):base(m,b) // LapseProbability is the chance of forgot the past on that iteration, Base
        {
            this.LapseProbability = LapseProbability;
            this.BaseProbabilityColor = BaseProbabilityColor;
        }

        public  new Boolean simulation(int steps, BackgroundWorker b)
        {
            Random rm = new Random();
            this.proportions = new double[steps + 1, this.totalcolorsnumber];
            for (int i = 0; i < this.totalcolorsnumber; i++)
            {
                this.proportions[0, i] = this.getProportionOfBall(i);  // init balls proportions 
            }

            double memorylapse;
            double p;
            double aux=0.0;
            for (int iteration = 1; iteration <= steps; iteration++)
            {
                memorylapse = rm.NextDouble();
                if (memorylapse <= this.LapseProbability)
                {
                    //memory lapse steps 
                    p = rm.NextDouble();
                    for (int column = 0; column < this.totalcolorsnumber; column++)
                    {
                        aux += this.BaseProbabilityColor[column];
                        if (aux <= p)
                        {
                            this.insert_balls(iteration, column);
                            break;
                        }
                    }

                }
                else
                {
                    //past looking steps
                    int index = rm.Next(this.totalballs);
                    int Column_color = this.urn[index];
                    for (int Row_color = 0; Row_color < this.totalcolorsnumber; Row_color++)
                    {
                        this.balls[Row_color] += this.matrix[Row_color, Column_color];
                        this.totalballs += this.matrix[Row_color, Column_color];
                        for (int k = 0; k < this.matrix[Row_color, Column_color]; k++)
                        {
                            this.urn.Add(Row_color);
                        }
                        this.proportions[iteration, Row_color] = this.getProportionOfBall(Row_color);
                    }
                    b.ReportProgress((iteration * 100) / steps);
                }
            }
            return true;




        }
    }


    public class Urn_memory: Urn
    {
        private int[] history;
        private double agree_probability;
        
        public Urn_memory(int[,] m, int[] b, double agree_probability) : base(m, b) // LapseProbability is the chance of forgot the past on that iteration, Base
        {
            this.agree_probability = agree_probability;
       
        }

        public new Boolean simulation(int steps,BackgroundWorker b)
        {
            Random rm = new Random();
            this.proportions = new double[steps + 1, this.totalcolorsnumber];
            this.history = new int[steps];
            for (int color = 0; color < this.totalcolorsnumber; color++)
            {
                this.proportions[0, color] = this.getProportionOfBall(color);
            }
            for (int iterations = 1; iterations <= steps; iterations++)
            {
                int index = rm.Next(this.totalballs);
                int color = this.urn[index];
                this.insert_balls(iterations, color);
                b.ReportProgress((iterations * 100) / steps);
            }
            return true;
        }
    }


    // Model with a probability 
    public class Urn_probability: Urn
    {
        private double[,] agree_matrix;
  
        public Urn_probability(int[,]matriz, int[] balls, double[,] agree_matrix) : base(matriz,balls) // agree_matrix is the matrix with the information of probabilities of all colors 
        {
            this.agree_matrix = agree_matrix;
        }

        private int check_probability(int color)    // return the color of the probability agreed or not to the in color;
        {
  
            Random rm = new Random();
            double prob = rm.NextDouble();
            double diff = 1 / this.totalcolorsnumber; // size of each interval 
            for(int c = 0; c < this.totalcolorsnumber; c++)
            {
                if((this.agree_matrix[c,color]- diff)< prob && prob < this.agree_matrix[c, color])
                   {
                    return c;
                   }
            }
            return -1; // error probability is wrong 
        }


        public new Boolean simulation(int steps, BackgroundWorker b)
        {
            Random rm = new Random();
            this.proportions = new double[steps + 1, this.totalcolorsnumber];
            int index;
            int color;
            for (color = 0; color < this.totalcolorsnumber; color++)
            {
                this.proportions[0, color] = this.getProportionOfBall(color);
            }
            for (int iterations = 1; iterations <= steps; iterations++)
            {
                index = rm.Next(this.totalballs);
                color = this.urn[index];
                color = this.check_probability(color); // return same color if agreed , diferente color if don't
                this.insert_balls(iterations, color);
                b.ReportProgress((iterations * 100) / steps);
            }
            return true;
        }
    }
}