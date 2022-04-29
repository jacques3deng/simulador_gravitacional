using System.IO;
public class Universo{
    // List<Corpo> corpos;
    List<Corpo> corpo;
    public float ForçaGtotal{get;set;}
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