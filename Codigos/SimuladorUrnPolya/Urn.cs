using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

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

        public Boolean simulation(int steps, BackgroundWorker b)
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
                b.ReportProgress((i * 100) / steps);
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

   
    
   
}