using System;
using UrnPolya;
public class Program{

    public static void Main(string[] args){
        int [,] matriz = {{1,0},
                          {0,1}};
        int [] bolas = {3,2};
        Urn u = new Urn(matriz,bolas);
        u.simulation(1000);
        double [,] proportions = u.getProportions();
        for(int i=0;i<=1000;i++){
            for(int j=0;j<u.getTotalColorsNumber();j++){
                Console.WriteLine("{0},{1}: {2}",i,j,proportions[i,j]);
            }
        }
    }
}