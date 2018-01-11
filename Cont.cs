using System;
using System.Collections.Generic;

namespace Contando_as_letras_dos_números
{
    internal class Cont{
        public int contar(int numero, int numeroFim){               //exemplo: de 1 a 2
            int[] numerosAContar = new int[numeroFim-numero+1];     //2-1+1 => 2 (1,2)

            int aux = 0;
            int numeroAux = numero;
            while (numeroAux <= numeroFim){
             
                numerosAContar[aux] = numeroAux;                    //numeros a contar {1,2}         

                numeroAux++;
                aux++;                                              
            }
            
            int[] unidades = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9};
            String[] unidadesExtenso = { "zero", "um", "dois", "três", "quatro", "cinco", "seis", "sete",
            "oito", "nove"};

            int[] especial = { 10, 11, 12, 13, 14, 15, 16, 17, 18, 19}; //Caso especial
            String[] especialExtenso = { "dez", "onze", "doze", "treze", "catorze", "quinze", "dezesseis", "dezesete",
                    "dezoito", "dezenove", };

            int[] dezenas = { 20, 30, 40, 50, 60, 70, 80, 90 };
            String[] dezenasExtenso = { "vinte", "trinta", "quarenta", "cinquenta", "sessenta", "setenta",
                "oitenta", "noventa" };

            int[] centenas = { 100, 200, 300, 400, 500, 600, 700, 800, 900 };
            String[] centenasExtenso = { "cento", "duzentos", "trezentos", "quatrocentos", "quinhentos", "seiscentos",
                "setecentos", "oitocentos", "novecentos"};

            int cemFechado = 100;
            String cemExtenso = "cem";
            int mil = 1000;
            String milExtenso = "mil";

            List<int> listaDeRespostas = new List<int>();
 
            foreach (int numeroAContar in numerosAContar){                     //resposta pra um intervalo de numeros de 0 a 19

                if (numeroAContar>=0 && numeroAContar<=9){      //0 a 9 Unidades
                    foreach (int number in unidades)
                    {
                        if (number == numeroAContar)
                        {
                            int numeroDeCaracteres = unidadesExtenso[number].Length;
                            listaDeRespostas.Add(numeroDeCaracteres);
                        }
                    }
                }

                if (numeroAContar>=10 && numeroAContar<=19){    //10 a 19 Especial
                    foreach (int number in especial)
                    {
                        if (number == numeroAContar)
                        {
                            int numeroDeCaracteres = especialExtenso[number-10].Length;
                            listaDeRespostas.Add(numeroDeCaracteres);
                        }
                    }
                }

                if (numeroAContar>=20 && numeroAContar<=99){    //20 a 99 dezenas e unidades
                    int numeroDecimal = (numeroAContar / 10) * 10;      //(42/10)*10 = 40   , já tenho o decimal 40
                    int numeroUnidade = numeroAContar % 10;             //42%10 = 2         , já tenho a unidade 2    

                    int numeroDeCaracteresDaParteDecimal=0;
                    int numerodeCaracteresDaParteUnitaria=0;

                    foreach (int number in dezenas){
                        if (number == numeroDecimal){
                            numeroDeCaracteresDaParteDecimal = dezenasExtenso[(number/10)-2].Length;
                        }
                    }

                    foreach (int number in unidades){
                        if (number == numeroUnidade && numeroUnidade != 0){ //numero unitario não pode ser 0, por que não existe vinte e zero
                            numerodeCaracteresDaParteUnitaria = (unidadesExtenso[number].Length)+1;     //+1 por causa do "e"
                        }                                                                               //vinte E um
                    }

                    int numeroDeCaracteresFinal = numeroDeCaracteresDaParteDecimal + numerodeCaracteresDaParteUnitaria;
                    listaDeRespostas.Add(numeroDeCaracteresFinal);
                }

                if (numeroAContar >= 100 && numeroAContar <= 999){  //100 a 999 centenas dezenas e unidades
                    int numeroCentenario = (numeroAContar / 100) * 100;     //(121/100)*100 = 100       , já tenho a centena 100
                    int numeroDecimal = ((numeroAContar % 100) / 10) * 10;  //((121%100)/10)*10 = 20     , já tenho a dezena 10
                    int numeroDecimalEspecial = numeroAContar%100;          //121%100 = 21              , já tenho a dezena especial 10
                    int numeroUnidade = numeroAContar % 10;                 //110%10 = 1               , já tenho a unidade 1

                    int numeroDeCaracteresDaParteCentenaria = 0;
                    int numeroDeCaracteresDaParteDecimal = 0;
                    int numeroDeCaracteresDaParteDecimalEspecial = 0;
                    int numerodeCaracteresDaParteUnitaria = 0;

                    if (numeroAContar == cemFechado && numeroDeCaracteresDaParteDecimalEspecial == 0 && numeroDeCaracteresDaParteDecimal == 0 && numerodeCaracteresDaParteUnitaria == 0)
                    {
                        listaDeRespostas.Add(cemExtenso.Length);
                    }

                    foreach (int number in centenas){
                        if (number == numeroCentenario){
                            numeroDeCaracteresDaParteCentenaria = centenasExtenso[(number / 100)-1].Length;
                        }
                    }

                    if (numeroDecimal >= 10 && numeroDecimal <= 19){   //caso entre nos casos especiais
                        foreach (int number in especial){   
                            if (number == numeroDecimalEspecial){
                                numeroDeCaracteresDaParteDecimalEspecial = (especialExtenso[number - 10].Length)+1; //+1 por causa do "e"
                            }                                                                                       //duzentos E doze
                        }
                    }else{
                        foreach (int number in dezenas){                //caso entre no caso dos decimais
                            if (number == numeroDecimal){
                                numeroDeCaracteresDaParteDecimal = (dezenasExtenso[(number/10)-2].Length)+1;
                            }
                        }

                        foreach (int number in unidades)                //caso entre no caso das unidades
                        {
                            if (number == numeroUnidade && number != 0)
                            {
                                numerodeCaracteresDaParteUnitaria = (unidadesExtenso[number].Length)+1;                  
                            }
                        }
                    }

                    //numeroDeCaracteresDaParteCentenaria;            //100, cento, 5       100 , 5
                    //numeroDeCaracteresDaParteDecimal;               //10 , dez, 3         10  , 4         TESTES
                    //numeroDeCaracteresDaParteDecimalEspecial;       //10                  12  , 5
                    //numerodeCaracteresDaParteUnitaria;              //0  ,zero, 4         2   , 3


                    int numeroDeCararteresFinal = 0;

                    if (numeroDeCaracteresDaParteDecimal == 0 && numeroAContar != cemFechado){
                        numeroDeCararteresFinal = numeroDeCaracteresDaParteCentenaria + numerodeCaracteresDaParteUnitaria;
                    }

                    if (numeroUnidade == 0 && numeroDecimal%10 == 0 && numeroDecimal != 10 && numeroAContar != cemFechado){ //multiplos de 10 ex 120
                        numeroDeCararteresFinal = numeroDeCaracteresDaParteCentenaria + numeroDeCaracteresDaParteDecimal;
                    }

                    if (numeroDecimalEspecial>=10 && numeroDecimalEspecial<=19){ //caseo para numeros especiais
                        numeroDeCararteresFinal = numeroDeCaracteresDaParteCentenaria + numeroDeCaracteresDaParteDecimalEspecial;
                    }

                    if (!(numeroDecimalEspecial >= 10 && numeroDecimalEspecial <= 19) && numeroAContar != cemFechado)
                    {
                        numeroDeCararteresFinal = numeroDeCaracteresDaParteCentenaria + numeroDeCaracteresDaParteDecimal + numerodeCaracteresDaParteUnitaria;
                    }

                    listaDeRespostas.Add(numeroDeCararteresFinal);

                }

                if (numeroAContar == mil){
                    listaDeRespostas.Add(milExtenso.Length);
                }
            }

            int cont = 0;
            for (int i = 0; i<listaDeRespostas.Count; i++)
            {
                cont = cont + listaDeRespostas[i];
            }
            return cont;

            //foreach (int number in unidades){         //resposta pra um unico numero
            //    if (number == numero){
            //        int resposta = unidadesExtenso[number].Length;
                    
            //        return resposta;

            //    }
            //}
            
            //return -1;
        }
    }
}
