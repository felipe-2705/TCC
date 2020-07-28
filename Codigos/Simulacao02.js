function gera_random(max,min){
       
    return Math.floor(Math.random()*(max-min+1)) + min

}


class Urna {
    constructor(bolas_ini, matriz){
        // Somando as bolas iniciais
        this.bolas = bolas_ini;
        this.ncores = bolas_ini.length; 
        this.s = 0; 
        for(let i = 0;i<this.ncores;i++ ){
            this.s = bolas_ini[i] + this.s;
        }

        this.matriz = matriz; // matriz de reposicao da urna, esta matriz adiciona sempre bolas azuis independente da cor sorteada
        this.urna = [];

        // inicia a urna adicionando as bolas iniciais ao array
        this.init = function(){ 
                for(let i=0;i<this.ncores;i++){
                    for(let j=0;j<this.bolas[i];j++){
                        this.urna.push(i); // i é o valor que represanta a cor da bola
                    }
                }
             
        }

        this.emular = function(passos){
            let posicao
            let bola

            for(let k=0;k<passos;k++)
            {
                posicao = gera_random(0,this.urna.length-1); // gerar uma posicao aleatoria da urna
                bola = this.urna[posicao]; //  retirando bola da urna na posicao aleatoria
                // o valor numerico da bola representa a coluna da matriz e sua cor correspondentes                                        
                //adicionando as bolas de acordo com a matriz
               for(let i =0; i<this.ncores;i++){
                   for(let j=0;j<this.matriz[i][bola];j++){
                        this.urna.push(i);  // adicionar j bolas da cor i de acordo com a coluna bola
                        this.bolas[i]++; // adicionando no total de bolas da cor i 
                        this.s++; // adicionando no total de bolas da urna
                        
                        //console.log("Passo "+ k);
                        //console.log(i+":"+this.bolas[i]/this.s);
                   }
               }

               
                

            }

        }


    }

};
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

let matriz03 = [
    [4,8],
    [8,4]
];


/////////////////// criando as urnas //////////////////////////
let urna01 = new Urna([3,2],matriz01);  // ambas começam com 3 bolas azuis e 2 bolas brancas//
let urna02 = new Urna([3,2],matriz02);
let urna03 = new Urna([3,2],matriz03);

urna01.init();
urna02.init();
urna03.init();
/// simulaçoes com 1000 passos 

/*console.log("Simulando Urna 01: ");
urna01.emular(1000);
console.log("Razao bolas azuis: " + (urna01.bolas[0]/urna01.s ));
console.log("Razao bolas Brancas: " + (urna01.bolas[1]/urna01.s ));*/

/*
console.log("Simulando Urna 02: ");
urna02.emular(1000);
console.log("Razao bolas Azuis: " + (urna02.bolas[0]/urna02.s ));
console.log("Razao bolas Brancas: " + (urna02.bolas[1]/urna02.s ));*/

console.log("Simulando Urna 04: ");
urna03.emular(1000);
console.log("Razao bolas Azuis: " + (urna03.bolas[0]/urna03.s ));
console.log("Razao bolas Brancas: " + (urna03.bolas[1]/urna03.s ));