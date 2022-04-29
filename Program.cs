// using Universo;

Universo universo = new Universo(); 
Console.Write($"numero corpos: {universo.numero_corpos} numero interações: {universo.qtdIteracoes}" );

Console.WriteLine(universo.corpo[35].Nome);
universo.ler_Dados_setar_Variaveis();
universo.calcularForçaGtotal();
universo.gravarDados();
universo.atualizarValores();