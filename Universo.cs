using System.IO;
public class Universo{
    // List<Corpo> corpos;
    public List<Corpo> corpo;
    public float ForcaGtotal{get;set;}
    public int numero_corpos,qtdIteracoes,timeInterect;
    public void ler_Dados_setar_Variaveis(){
        //TODO: ler dados no arquivo e setar valores para cada corpo
        StreamReader reader = new StreamReader("universo.txt");
        string dados = reader.ReadToEnd();
        string[] corpos = dados.Split("\n");
        int numLine = corpos.Length;      
                
        for (int i = 0; i < numLine; i++){
            if (i == 0){
                
                string[] value = corpos[i].Split(";");
                numero_corpos = Int32.Parse(value[0]);
                qtdIteracoes = Int32.Parse(value[1]);
                timeInterect = Int32.Parse(value[2]);
            }
            else {
                string[] value = corpos[i].Split(";");
                corpo.Add(new Corpo(value[0], Int32.Parse(value[1]),float.Parse(value[2]),float.Parse(value[3]),Int32.Parse(value[4]),float.Parse(value[5])));
            }   
        }
    }
    public float calcularForçaGtotal(){
        //TODO: somar todas forças gravitacionais dos corpos
        int k = 0;
        float raio;
        float[] forca = new float[numero_corpos*100];
        float constGravit = (float)System.Math.Pow(10,-11)*6.6743f;
        ForcaGtotal = 0;

        for(int i = 0; i < numero_corpos; i++){
            for(int j = 0; j < numero_corpos; j++){
                raio = (float)System.Math.Sqrt(System.Math.Pow(corpo[j].PosX - corpo[i].PosY, 2) + System.Math.Pow(corpo[j].PosY - corpo[i].PosY, 2));
                forca[k] = constGravit*(corpo[i].Massa * corpo[j].Massa)/(raio * raio);
                k++;
                ForcaGtotal += forca[k];
            }
        }
        return ForcaGtotal;
    }

    public void calculosNosCorpos(){
        //TODO: calcular e setar posição, aceleraçao, velocidade e deslocameto para cada corpo
        float raio;
        for(int i =0; i < numero_corpos; i++){
            for(int j = 0; j < numero_corpos; j++){
                raio = (float)System.Math.Sqrt(System.Math.Pow(corpo[j].PosX - corpo[i].PosY, 2) + System.Math.Pow(corpo[j].PosY - corpo[i].PosY, 2));
                
                corpo[i].setAceleracao(ForcaGtotal, corpo[i].Massa, corpo[i].ponto, corpo[j].ponto, raio);
                corpo[i].setVelocidade(ForcaGtotal, corpo[i].v0, corpo[i].aceleracao, timeInterect);
                corpo[i].setDeslocamento(corpo[i].posicao, corpo[i].velocidade, corpo[i].aceleracao, timeInterect);
            }
        }        
    }

    public void gravarDados(){
        //TODO: gravar saidas no arquivo
        string result = "resultados.txt";
        using (StreamWriter sw = new StreamWriter(result)){
            sw.Write(string.Empty);
            for(int i = 0; i < numero_corpos; i++){
                sw.Write($"{corpo[i].Nome}; ");
                sw.Write($"{corpo[i].Massa}; ");
                sw.Write($"{corpo[i].Raio}; ");
                sw.Write($"{corpo[i].PosX}; ");
                sw.Write($"{corpo[i].PosY}; ");
                sw.Write($"{corpo[i].aceleracao}; ");
                sw.Write($"{corpo[i].velocidade}; ");
                sw.WriteLine($"{corpo[i].deslocamento}");
            }
        }
    }
    public void atualizarValores(){
        //TODO: atualizar valores de cada corpo após as transformações
        corpo.Clear();
    }
    public Universo(){
        instrucoes();
        //corpo = new Corpo[50];        
        corpo = new List<Corpo>();
        ler_Dados_setar_Variaveis();
    }

    public void instrucoes(){
        Console.WriteLine("1-Ler Arquivo e Setar Variaveis\n" + 
                            "2-Calcular força gravitacional total\n"+
                            "3-Calcular e aplicar transformações nos corpos\n"+
                            "4-Gravar dados em arquivo\n"+
                            "5-Atualizar valores transformados\n");
    }
    
}