// See https://aka.ms/new-console-template for more information

Corpo c1 = new Corpo("c1",5.0f,2.0f,6.0f,5.0f,4.0f);
Corpo c2 = new Corpo("c2",10.0f,4.0f,12.0f,10.0f,8.0f);

float c1fg = c1.forcaGravitacional( c1.Massa,c2.Massa,c1.r(c1.pos,c2.pos));
float c1r =  c1.r(c1.pos,c2.pos);
float[] ac = c1.aceleracao(c1fg,c1.Massa,c1.pos,c2.pos);
/*
Console.Write(c1r);
Console.Write(c1fg);*/
Console.Write("ax: {0} ay:{1}",ac[0],ac[1]);



