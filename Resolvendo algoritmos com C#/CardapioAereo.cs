/*

Desafio: Durante um longo voo é comum que as companhias aéreas ofereçam alguma refeição aos seus passageiros, e é comum as aeromoças conduzirem carrinhos contendo tais refeições pelos corredores do avião. Sentado numa fileira, você avista o carrinho chegando até você, a qual em um piscar de olhos você é questionado imediatamente: “Pizza, salada, ou massa?”.
Mesmo tendo noção das opção, você tem apenas alguns segundos para selecionar, mas sua relutância imediata vem da dúvida de como pode ser a aparência de sua escolha, pois seu vizinho ainda não abriu o embrulho…

Então a aeromoça decidiu mudar o procedimento. Primeiro ela vai perguntar a todos os passageiros o que eles querem, e com base nisso vai checar se o estoque pode satisfazer todo mundo. Obviamente, ela quer automatizar esse processo e você se prontificou a ajudar.
Então assim, por exemplo, considere que o número de refeições de pizza, salada e massa disponíveis são respectivamente (80, 20, 40), enquanto o número de passageiros que escolheu pizza, salada e massa seja respectivamente (45, 23, 48). Neste caso, onze pessoas seguramente ficaram sem suas respectivas escolhas de refeição, já que três passageiros que queriam salada e oito que gostariam de massa não poderão ser atendidos.

Dada a quantidade de refeições disponíveis para cada escolha e o número de refeições pedidas para cada escolha, você poderia ajudar a aeromoça a determinar quantos passageiros certamente não poderão ser atendidos?

Entrada: A primeira linha contem três inteiros Ca, Ba e Pa (0 ≤ Ca, Ba, Pa ≤ 100), representando respectivamente o número de refeições disponiveis de pizza, salada e massa. A segunda linha contem três inteiros Cr, Br e Pr (0 ≤ Cr, Br, Pr ≤ 100), indicando respectivamente o número de refeições requisitadas de pizza, salada e massa respectivamente.
Saída: Imprima uma única linha com um inteiro representando o número total de passageiros que seguramente não receberão sua escolha de refeição.
 
Exemplos de Entrada |	Exemplos de Saída
------------------------------------------
80 20 40            |
45 23 48            |        11
-----------------------------------------
0 0 0               |
100 100 100         |        300
-----------------------------------------
41 42 43            |
41 42 43            |         0
-----------------------------------------
*/

using System;

class Desafio7 {

 public static void Main (string[] args) {

    string[] RefDisponiveis = Console.ReadLine().Split(' ');
    string[] RefRequisitadas = Console.ReadLine().Split(' ');
    
    int Ca = int.Parse(RefDisponiveis[0]);
    int Ba = int.Parse(RefDisponiveis[1]);
    int Pa = int.Parse(RefDisponiveis[2]);
    
    int Cr = int.Parse(RefRequisitadas[0]);
    int Br = int.Parse(RefRequisitadas[1]);
    int Pr = int.Parse(RefRequisitadas[2]);
    
    int sub1 = Cr - Ca;
    int sub2 = Br - Ba;
    int sub3 = Pr - Pa;
    
    int soma = 0;
    if(sub1 >0){
      soma = soma + sub1;
    }
    
    
    if(sub2 >0){
      soma = soma + sub2;
    }
    
    if(sub3 >0){
      soma = soma + sub3;
    }
    
    Console.WriteLine("{0}", soma);
}

}
