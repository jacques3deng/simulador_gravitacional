public class Corpo{
    public float Const_Gravit{
        get{ return (float)System.Math.Pow(10,-11)*6.6743f; }
    }
    public string Nome{get;set;}
    public int Massa{get;set;}
    public float Raio{get;set;}
    public int PosX{get;set;}
    public int PosY{get;set;}
    public int VelX{get;set;}
    public int VelY{get;set;}
    public float v0{get;set;}
    public Ponto ponto;
    public Aceleracao aceleracao;
    public Velocidade velocidade;
    public Deslocamento deslocamento;
    
    // public Corpo(string nome,float massa,float posx, float posy,float vel){
    //     Nome = nome;
    //     Massa = massa;
    //     v0 = vel;
    //     ponto = new Ponto(posx, posy);
    // }
    
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
    
    public Velocidade setVelocidade(float f,float v0, Aceleracao a, float t){
        velocidade = new Velocidade(f,v0,a,t);
        return velocidade;
    }
     
    public Deslocamento setDeslocamento(float s0, Velocidade v, Aceleracao a, float t){
        deslocamento = new Deslocamento(s0,v,a,t);
        return deslocamento;
    }
   
}