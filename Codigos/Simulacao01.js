function gera_random(max,min){
       
    return Math.floor(Math.random()*(max-min+1)) + min

}


class Urna {
    constructor(t_azul, t_branco, matriz) {
        this.azul = 0;
        this.branco = 1;
        this.t_azul = t_azul; // numero de bolas azuis na urna
        this.t_branco = t_branco; // numero de bolas brancas na urna
        this.S = t_azul + t_branco; // Numero de bolas na urna
        this.matriz = matriz; // matriz de reposicao da urna, esta matriz adiciona sempre bolas azuis independente da cor sorteada
        this.urna = [];

        // inicia a urna adicionando as bolas iniciais ao array
        this.init = function(){ 
                for(let i = 0;i<this.t_azul;i++)
                {
                   this.urna.push(this.azul);
                }
                for(let i = 0;i<this.t_branco;i++){
                    this.urna.push(this.branco);
                }
             
        }

        this.emular = function(passos){
            let posicao
            let bola
            let n_azuis
            let n_brancas

            for(let i=0;i<passos;i++)
            {
                posicao = gera_random(0,this.urna.length-1); // gerar uma posicao aleatoria da urna
                bola = this.urna[posicao]; //  retirando bola da urna na posicao aleatoria

                //adicionando as bolas de acordo com a matriz
                n_azuis = this.matriz[this.azul][bola];
                n_brancas = this.matriz[this.branco][bola];
                for(let i =0;i<n_azuis;i++)
                {
                    this.urna.push(this.azul);
                }

                for(let i =0;i<n_brancas;i++)
                {
                    this.urna.push(this.branco);
                }

                this.t_azul = this.t_azul + n_azuis;
                this.t_branco= this.t_branco + n_brancas;
                this.S = this.t_azul +this.t_branco;

            }

            console.log("Proporção de bolas azuis =" + this.t_azul/this.S);
            console.log("Proporção de bolas brancas =" + this.t_branco/this.S);
        }


    }

}
;
////////////////////////////////////////////////iniciando simulaçoes /////////////////////////

// matrizes de reposiçao////
let matriz01 = [
    [1,1],
    [0,0]

];

let matriz02 = [
    [1,0],
    [0,1]
];

/////////////////// criando as urnas //////////////////////////
let urna01 = new Urna(3,2,matriz01);  // ambas começam com 3 bolas azuis e 2 bolas brancas//
let urna02 = new Urna(3,2,matriz02);

urna01.init();
urna02.init();

/// simulaçoes com 1000 passos 
console.log("Simulando Urna 01: ");
urna01.emular(1000);

console.log("Simulando Urna 02: ");
urna02.emular(1000);