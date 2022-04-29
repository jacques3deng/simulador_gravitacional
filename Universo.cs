using System.IO;
public class Universo{
    // List<Corpo> corpos;
    Corpo[] corpo;
    public float ForçaGtotal{get;set;}
    public int numero_corpos;
    public void ler_Dados_setar_Variaveis(){
        //TODO: ler dados no arquivo e setar valores para cada corpo
        StreamReader reader = new StreamReader("universo.txt");
        string dados = reader.ReadToEnd();
        string[] corpos = dados.Split("\n");
        int numLine = corpos.Length;
        int qtdCorpos, qtdIteracoes, timeUtil;
        

        for (int i = 0; i < numLine; i++){
            if (i == 0){
                var value = corpos[i].Split(";");
                qtdCorpos = Int32.Parse(value[0]);
                qtdIteracoes = Int32.Parse(value[1]);
                timeUtil = Int32.Parse(value[2]);
            }
            else if (i != 0) {
                var value = corpos[i].Split(";");
                Console.WriteLine(value[0]);
                
                corpo[i-1].Nome = value[0];
                corpo[i-1].Massa = Int32.Parse(value[1]);
                corpo[i-1].Raio = float.Parse(value[2]);
                corpo[i-1].PosX = Int32.Parse(value[3]);
                corpo[i-1].PosY = Int32.Parse(value[4]);
                corpo[i-1].VelX = Int32.Parse(value[5]);
                corpo[i-1].VelY = Int32.Parse(value[6]);
            }

            Console.WriteLine(corpo[1].Nome);
        }
    }
    public float calcularForçaGtotal(){
        //TODO: somar todas forças gravitacionais dos corpos
        return ForçaGtotal;
    }
    public void calculosNosCorpos(){
        //TODO: calcular e setar posição, aceleraçao, velocidade e deslocameto para cada corpo
    }
    public void gravarDados(){
        //TODO: gravar saidas no arquivo
    }
    public void atualizarValores(){
        //TODO: atualizar valores de cada corpo após as transformações
    }
    public Universo(){
        instrucoes();

        Corpo[] corpo = new Corpo[50];
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