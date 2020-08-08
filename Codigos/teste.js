


let m = []

for(let i=0;i<7;i++){
    m[i] = []
    for(let j=0;j<7;j++){
        m[i][j] = (j + (i*7));
    }
}

for(var i=0; i<7;i++){
console.log(m[i])
}