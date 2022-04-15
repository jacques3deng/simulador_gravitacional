// See https://aka.ms/new-console-template for more information

Corpo c1 = new Corpo("c1",25.0f,2.0f,6.0f,5.0f);
Corpo c2 = new Corpo("c2",500.0f,4.0f,12.0f,10.0f);

float fgc1c2 = c1.forcaGravitacional( c1.Massa,c2.Massa,c1.r(c1.ponto,c2.ponto));
float c1r =  c1.r(c1.ponto,c2.ponto);
c1.setAceleracao(fgc1c2,c1.Massa, c1.ponto,c2.ponto,c1r);
c1.setVelocidade(fgc1c2,50,c1.aceleracao,2);

Console.WriteLine("Força {0}",fgc1c2);
Console.WriteLine("Massa de c1 {0}",c1.Massa);
Console.WriteLine("distania r: {0}",c1r);
Console.WriteLine("aceleraçao ax: {0} ay: {1}",c1.aceleracao.ax,c1.aceleracao.ay);
Console.WriteLine("velocidade vx: {0} vy: {1} ",c1.velocidade.vx, c1.velocidade.vy);


