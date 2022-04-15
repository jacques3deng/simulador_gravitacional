public class Corpo{
    public float Const_Gravit{
        get{ return (float)System.Math.Pow(10,-11)*6.6743f; }
    }
    public string Nome{get;set;}
    public float Massa{get;set;}
    public float Velx{get;set;}
    public float Vely{get;set;}
    public Pos pos;

    public Corpo(string nome,float massa,float posx, float posy,float velx, float vely){
        Nome = nome;
        Massa = massa*1000;
        Velx = velx;
        Vely = vely;
        pos = new Pos(posx, posy);
    }
    
    public float r(Pos p1, Pos p2) {
        return (float)System.Math.Sqrt(System.Math.Pow(p2.posx - p1.posy, 2) + System.Math.Pow(p2.posy - p1.posy, 2));
    }
    public float forcaGravitacional(float m1, float m2, float r){
        return Const_Gravit*(m1*1000*m2*1000)/(r*r);
    }
    
    public float[] aceleracao(float f, float m, Pos p1, Pos p2){
        float a = f/m*1000;
        float ax = a*( (p2.posx - p1.posx)/r(p1,p2));
        float ay = a*( (p2.posy - p1.posy)/r(p1,p2));
        float[] _a = new float[2]{ax,ay};
        return _a;
    }
    /*
    public float velocidade(float v0, float a, float t){
        return v0 + a*t;
    }

    public float deslocamento(float s0, float v0, float t, float a){
        return s0 + v0*t + (0.5f)*a*(t*t);
    }*/
   
}