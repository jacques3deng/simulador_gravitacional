public struct Velocidade{
    public float vx{get;set;}
    public float vy{get;set;}
    public float v{get;set;}

    public Velocidade(float f,float v0, Aceleracao a, float t){
        double theta = System.Math.Atan(a.ay/a.ax);
        vx = v0*(float)System.Math.Cos(theta) + a.ax*t;
        vy = v0*(float)System.Math.Sin(theta) + a.ay*t;
        v = 0;
    }
}