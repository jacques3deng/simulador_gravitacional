public class Universo{
    List<Corpo> corpos;
    public float ForçaGtotal{get;set;}
    public int numero_corpos;
    public void ler_Dados_setar_Variaveis(){
        //TODO: ler dados no arquivo e setar valores para cada corpo
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

    public Universo(){
        instrucoes();
        corpos = new List<Corpo>();
    }

    public void instrucoes(){
        Console.WriteLine("1-Ler Arquivo e Setar Variaveis\n" + 
                            "2-Calcular força gravitacional total\n"+
                            "3-Calcular e aplicar transformações nos corpos\n"+
                            "4-Gravar dados em arquivo\n");
    }
    
}