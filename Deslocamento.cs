public struct Deslocamento{
    public float sx{get;set;}
    public float sy{get;set;}
    public float s0{get;set;}

    public Deslocamento(float s0, Velocidade v, Aceleracao a,float t){
        double theta = System.Math.Atan(v.vy/v.vx);
        sx = s0*(float)System.Math.Cos(theta) + v.vx*t + 0.5f*a.ax*t*t;
        sy = s0*(float)System.Math.Sin(theta) + v.vy*t + 0.5f*a.ay*t*t;
        this.s0= s0;
    }
}