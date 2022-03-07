using System;
using System.Collections.Generic;

using CursoCSharp.Fundamentos;
using CursoCSharp.EstruturaDeControle;

namespace CursoCSharp {
    class Program {
        static void Main(string[] args) {
            var central = new CentralDeExercicios(new Dictionary<string, Action>() {
                //Fundamentos
            {"Primeiro Programa - Fundamentos", PrimeiroPrograma.Executar},
            {"Comentários - Fundamentos", Comentarios.Executar},
            {"Variaveis e constantes - Fundamentos", VariaveisEConstantes.Executar},
            {"Inferencia - Fundamentos", Inferencia.Executar},
            {"Interpolação - Fundamentos", Interpolacao.Executar},
            {"Notação Ponto - Fundamentos", NotacaoPonto.Executar},
            {"Lendo Dados - Fundamentos", LendoDados.Executar},
            {"Formatando Numero - Fundamentos", FormatandoNumero.Executar},
            {"Conversões - Fundamentos", Conversoes.Executar},
            {"Operadores Aritmeticos - Fundamentos", OperadoresAritmeticos.Executar},
            {"Operadores Relacionais - Fundamentos", OperadoresRelacionais.Executar},
            {"Operadores Logicos - Fundamentos", OperadoresLogicos.Executar},
            {"Operadores Atribuição - Fundamentos", OperadoresAtribuicao.Executar},
            {"Operadores Unarios - Fundamentos", OperadoresUnarios.Executar},
            {"Operador Ternario - Fundamentos", OperadorTernario.Executar},
           //Estrutura de controle
            {"Estrutura If - Estrutura de Controle", EstruturaIf.Executar},
            {"Estrutura If/Else - Estrutura de Controle", EstruturaIfElse.Executar},
            {"Estrutura If/Else/If - Estrutura de Controle", EstruturaIfElseIf.Executar},
            {"Estrutura Switch - Estrutura de Controle", EstruturaSwitch.Executar},
            {"Estrutura While - Estrutura de Controle", EstruturaWhile.Executar},
            {"Estrutura Do/While - Estrutura de Controle", EstruturaDoWhile.Executar},


            });

            central.SelecionarEExecutar();
        }
    }
}