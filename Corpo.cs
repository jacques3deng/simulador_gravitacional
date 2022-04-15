public class Corpo{
    public float Const_Gravit{
        get{ return (float)System.Math.Pow(10,-11)*6.6743f; }
    }
    public string Nome{get;set;}
    public float Massa{get;set;}
    public float v0{get;set;}
    public Ponto ponto;
    public Aceleracao aceleracao;
    public Corpo(string nome,float massa,float posx, float posy,float vel){
        Nome = nome;
        Massa = massa*1000;
        v0 = vel;
        ponto = new Ponto(posx, posy);
        aceleracao = new Aceleracao();
    }
    
    public float r(Ponto p1, Ponto p2) {
        return (float)System.Math.Sqrt(System.Math.Pow(p2.posx - p1.posy, 2) + System.Math.Pow(p2.posy - p1.posy, 2));
    }
    public float forcaGravitacional(float m1, float m2, float r){
        return Const_Gravit*(m1*m2)/(r*r);
    }

    public Aceleracao setAceleracao(float f,float massa,Ponto p1, Ponto p2, float r){
        aceleracao = new Aceleracao(f,massa,p1,p2,r);
        return aceleracao;
    }
    /*
    public Velocidade(){
        v = v0 + a*t;
    }
    
    public Deslocamento(float s0, float v0, float t, float a){
        return s0 + v0*t + (0.5f)*a*(t*t);
    }*/
   
}