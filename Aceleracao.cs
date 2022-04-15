public struct Aceleracao{
    public float ax{get;set;}
    public float ay{get;set;}
    public float a{get;set;}
    public Aceleracao(float f, float massa, Ponto p1, Ponto p2, float r){
        a = f/massa;
        ax = a*( (p2.posx - p1.posx)/r );
        ay = a*( (p2.posy - p1.posy)/r );
    }

    public Aceleracao(){
        a = 0;
        ax = 0;
        ay = 0;
    }

}