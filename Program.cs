// using Universo;

Universo universo = new Universo(); 

// int numCorpos = 4;
// int numCombinacoes = 6;
// string saida = "";

// for (int j = 1; j <= numCorpos; j++){
//     for (int k = 1; k <= j; k++){
//         saida = $"c{k},c{j}\t";
//         Console.Write(saida);
//     }
//     Console.WriteLine();
// }


// exemplo entre 2 corpos fora da classe universo,
// implementaçao deve ser feita usando a classe universo

// Corpo c1 = new Corpo("c1",50,2,7,50);
// Corpo c2 = new Corpo("c2",500,20,45,5);

// Corpo[] corpo = new Corpo[2]{c1,c2};

// for(int k =0; k < 4; k++){
//     float rc0c1 = corpo[0].r(corpo[0].ponto,corpo[1].ponto);
//     float fgTotal = corpo[0].forcaGravitacional(corpo[0].Massa,corpo[1].Massa,rc0c1);
//     for(int i = 0; i < corpo.Length; i++){
//         corpo[i].setAceleracao(fgTotal, corpo[i].Massa, corpo[0].ponto, corpo[1].ponto, rc0c1);
//         corpo[i].setVelocidade(fgTotal, 50, corpo[i].aceleracao, k);
//         corpo[i].setDeslocamento(10, corpo[i].velocidade, corpo[i].aceleracao, k);
//         corpo[i].ponto.posx += corpo[i].deslocamento.sx;
//         corpo[i].ponto.posy+= corpo[i].deslocamento.sy; 
//         Console.WriteLine("deslocamento sx: {0} sy: {1}",corpo[i].deslocamento.sx,corpo[i].deslocamento.sy);
//         Console.WriteLine("r: {2}\n x: {0} y: {1}",corpo[i].ponto.posx,corpo[i].ponto.posy,rc0c1);
//     }
    
// }
