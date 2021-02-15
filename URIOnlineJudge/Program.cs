using System;
using System.Collections.Generic;

using URIOnlineJudge.Iniciante;
using URIOnlineJudge.EstruturaCondicional;
using URIOnlineJudge.EstruturaRepetitiva;

namespace CursoCSharp {
    class Program {
        static void Main(string[] args) {
            var central = new CentralDeExercicios(new Dictionary<string, Action>() {

                //Iniciante
                {"1002 - Area Do Circulo - Iniciante", _1002_AreaDoCirculo.Executar},
                {"1003 - Soma Simples - Iniciante", _1003_SomaSimples.Executar},
                {"1004 - Produto Simples - Iniciante", _1004_ProdutoSimples.Executar},
                {"1005 - Media1 - Iniciante", _1005_Media1.Executar},
                {"1006 - Media2 - Iniciante", _1006_Media2.Executar},
                {"1007 - Diferença - Iniciante", _1007_Diferença.Executar},
                {"1008 - Salário - Iniciante", _1008_Salario.Executar},
                {"1009 - Salário com Bonus - Iniciante", _1009_SalarioComBonus.Executar},
                {"1010 - Cálculo Simples - Iniciante", _1010_CalculoSimples.Executar},
                {"1011 - Esfera - Iniciante", _1011_Esfera.Executar},
                {"1012 - Área - Iniciante", _1012_Area.Executar},
                {"1013 - O Maior - Iniciante", _1013_OMaior.Executar},
                {"1014 - Consumo - Iniciante", _1014_Consumo.Executar},
                {"1015 - Distância Entre Dois Pontos - Iniciante", _1015_DistanciaEntreDoisPontos.Executar},
                {"1016 - Distancia - Iniciante", _1016_Distancia.Executar},
                {"1017 - Gasto De Combustivel - Iniciante", _1017_GastoDeCombustivel.Executar},
                {"1018 - Cédulas - Iniciante", _1018_Cedulas.Executar},
                {"1019 - Conversao De Tempo - Iniciante", _1019_ConversaoDeTempo.Executar},
                {"1020 - Idade Em Dias - Iniciante", _1020_IdadeEmDias.Executar},
                {"1021 - Notas e Moedas - Iniciante", _1021_NotasEMoedas.Executar},

                //Seção_03 - Exercícios sobre Estrutura Condicional (if-else)
                {"Exercício if-else - 01", Secao03Exercicio02_01.Executar},
                {"Exercício if-else - 02", Secao03Exercicio02_02.Executar},
                {"Exercício if-else - 03", Secao03Exercicio02_03.Executar},
                {"Exercício if-else - 04", Secao03Exercicio02_04.Executar},
                {"Exercício if-else - 05", Secao03Exercicio02_05.Executar},
                {"Exercício if-else - 06", Secao03Exercicio02_06.Executar},
                {"Exercício if-else - 07", Secao03Exercicio02_07.Executar},
                {"Exercício if-else - 08", Secao03Exercicio02_08.Executar},

                //Seção_03 - Exercícios sobre Estrutura Repetitiva WHILE
                {"Exercício WHILE - 01", Secao03Exercicio03_01.Executar},
                {"Exercício WHILE - 02", Secao03Exercicio03_02.Executar},
                {"Exercício WHILE - 03", Secao03Exercicio03_03.Executar},

                //Seção_03 - Exercícios sobre Estrutura Repetitiva FOR
                 {"Exercício FOR - 01", Secao03Exercicio04_01.Executar},
                 {"Exercício FOR - 02", Secao03Exercicio04_02.Executar},
                 {"Exercício FOR - 03", Secao03Exercicio04_03.Executar},
                 {"Exercício FOR - 04", Secao03Exercicio04_04.Executar},
                 {"Exercício FOR - 05", Secao03Exercicio04_05.Executar},
                 {"Exercício FOR - 06", Secao03Exercicio04_06.Executar},
                 {"Exercício FOR - 07", Secao03Exercicio04_07.Executar},

            });

            central.SelecionarEExecutar();
        }
    }
}