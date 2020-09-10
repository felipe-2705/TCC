function gera_random(max,min){
       
    return Math.floor(Math.random()*(max-min+1)) + min

}

// cria os resultados das simulaçoes
function criaResultTable(tests,passos,urna){
    //cria a matriz de resultado [ntest][cor]
    let result = []
    for(let nteste = 0;nteste<tests; nteste++){
        result[nteste] = []
        for(let cor=0;cor<urna.ncores;cor++){
            result[nteste][cor]=0
        }
    }
    ///////////
    
    for(let nteste = 0;nteste<tests;nteste++){
    urna.emular(passos);  // executa a simulaçao 
    
    // vamos guardar os resultados na matriz de resultado
    for(let cor=0;cor<urna.ncores;cor++){
        result[nteste][cor] = (urna.bolas[cor]/urna.s)
        
    }
    urna.reset()
    }
    return result
    }

//Processa e organiza os resultados 
function ProcessaDados(result){
    let aparicoes =[]
    let tests = result.length
    let ncores = result[0].length
    let flag = false  // flag para saber se o valor ja consta na matriz de apariçoes
    for(let nteste = 0;nteste<tests;nteste++){
        let cores = result.pop()
        for(let cor = 0; cor<ncores;cor++){
              let valor = cores[cor]
              flag = false
              for(let i =0;i<aparicoes.length;i++){
                  if(aparicoes[i][2]== Math.floor(valor*1000))  // pegar 3 casas de precisão
                  {
                      
                      aparicoes[i][cor]++
                      flag = true 
                      break;
                  }
              }
              if(!aparicoes.length || flag==false){
                let newline = [0,0,Math.floor(valor*1000)]
                newline[cor]++
                aparicoes.push(newline) 
              }
        }
        
    
    }
    console.log("Aparicoes antes de orderar:"+aparicoes)
    aparicoes = bubblesort(aparicoes)  // ordena a saida 
    return aparicoes
   }

   //ordena os resultados 
   function bubblesort(aparicoes){
    let aux;
    
    for(let j=aparicoes.length;j>0;j--){
    for(let i = 0;i<j-1;i++){
     if(aparicoes[i][2]>aparicoes[i+1][2]){
         aux = aparicoes[i]
         aparicoes[i]=aparicoes[i+1]
         aparicoes[i+1]=aux
        
    }
    
    }}

    console.log("Depois de ordenar"+aparicoes)
    return aparicoes
    }
class Urna {
    constructor(bolas_ini, matriz){
       
        this.bolas = bolas_ini; // numero de bolas de cada cor na urna
        this.ncores = bolas_ini.length; //quantidade de cores 
        this.s = 0;  //total de bolas 
        this.resetbola = bolas_ini;
        // calculando bolas iniciais no total 
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

        this.reset = function(){
            this.bolas = this.resetbola
            this.ncores = this.resetbola.length
            this.s = 0
            for(let i = 0;i<this.ncores;i++ ){
                this.s = this.resetbola[i] + this.s;
            }

            this.urna= []

            
            this.init()

        }

        this.emular = function(passos){
            let posicao
            let bola
         
        
            for(let k=0;k<passos;k++)
            {
                posicao = gera_random(0,this.urna.length-1)
                 // gerar uma posicao aleatoria da urna
                bola = this.urna[posicao]; //  retirando bola da urna na posicao aleatoria
                // o valor numerico da bola representa a coluna da matriz e sua cor correspondentes                                        
                
         
                //adicionando as bolas de acordo com a matriz
               for(let i =0; i<this.ncores;i++){
                   for(let j=0;j<this.matriz[i][bola];j++){
                        this.urna.push(i);  // adicionar j bolas da cor i de acordo com a coluna bola
                        this.bolas[i]++; // adicionando no total de bolas da cor i 
                        this.s++; // adicionando no total de bolas da urna
                        
                       
                   }
               }

               
                

            }

        }


    }

};
////////////////////////////////////////////////iniciando simulaçoes /////////////////////////

// matrizes de reposiçao////



/////////////////// criando as urnas //////////////////////////


let urna =  new Urna([3,2],[
    [1,0],
    [0,1]
])





/////////////////////////////////// processar os dados de cada urna ///////////////////////////////////



//   google charts para desenha graficos


google.charts.load('current', {packages: ['corechart']});
google.charts.setOnLoadCallback(drawChartBlue)
google.charts.setOnLoadCallback(drawChartRed)

 //preparando os dados e realizando as simulaçoes 
let aparicoes =  ProcessaDados(criaResultTable(1000,1000,urna))

function drawChartBlue() {
   
let array = []

array[0]=['valor','Blue'] 

for(let i = 0;i<aparicoes.length; i++){

array[i+1] = [aparicoes[i][2],(aparicoes[i][0]*100)/1000]
}


var data = google.visualization.arrayToDataTable(array);

var options = {
  title: 'Probabilidade de apariçoes ',
  legend: { position: 'bottom' },
  colors: ['blue'] ,
  height: 900,
  width: 1000
};

var chart = new google.visualization.LineChart(document.getElementById('curve_chartblue'));

chart.draw(data, options);
}

function drawChartRed() {

   
    let array = []
    
    array[0]=['valor','Red'] 
    
    for(let i = 0;i<aparicoes.length; i++){
    
    array[i+1] = [aparicoes[i][2],(aparicoes[i][1]*100)/1000]
    }
    
    
    var data = google.visualization.arrayToDataTable(array);
    
    var options = {
      title: 'Probabilidade de apariçoes ',
      legend: { position: 'bottom' },
      colors: ['red'] ,
      height: 900,
      width: 1000
    };
    
    var chart = new google.visualization.LineChart(document.getElementById('curve_chartred'));
    
    chart.draw(data, options);
    }
    


