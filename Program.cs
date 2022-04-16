// See https://aka.ms/new-console-template for more information
Universo universo = new Universo();

//exemplo entre 2 corpos fora da classe universo

Corpo c1 = new Corpo("c1",50,2,7,50);
Corpo c2 = new Corpo("c2",500,10,8,5);
float rc1c2 = c1.r(c1.ponto,c2.ponto);
float fgTotal = c1.forcaGravitacional(c1.Massa,c2.Massa,rc1c2);
Console.WriteLine("força gravitacional total c1 e c2 fgTotal: {0}",fgTotal);
c1.setAceleracao(fgTotal,c1.Massa,c1.ponto,c2.ponto,rc1c2);
Console.WriteLine("aceleração ax: {0} ay: {1}",c1.aceleracao.ax,c1.aceleracao.ay);
c1.setVelocidade(fgTotal,50,c1.aceleracao,2);
Console.WriteLine("velocidade vx: {0} vy: {1}",c1.velocidade.vx,c1.velocidade.vy);
c1.setDeslocamento(4,c1.velocidade,c1.aceleracao,2);
Console.WriteLine("deslocamento sx: {0} sy: {1}",c1.deslocamento.sx,c1.deslocamento.sy);

