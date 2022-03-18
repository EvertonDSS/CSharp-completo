using System;
using System.Collections.Generic;
using CursoCSharp.Fundamentos;
using CursoCSharp.EstruturaDeControle;
using CursoCSharp.ClassesEMetodos;
using CursoCSharp.Colecoes;
using CursoCSharp.OO;
using CursoCSharp.MetodosEFuncoes;
using CursoCSharp.Excecoes;
using CursoCSharp.API;
using CursoCSharp.TopicosAvancados;

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
            {"Estrutura For - Estrutura de Controle", EstruturaFor.Executar},
            {"Estrutura ForEach - Estrutura de Controle", EstruturaForEach.Executar},
            {"Usando Break - Estrutura de Controle", UsandoBreak.Executar},
            {"Usando Continue - Estrutura de Controle", UsandoContinue.Executar},
            //Classes e Métodos
            {"Membros - Classes e métodos", Membros.Executar},
            {"Construtores- Classes e métodos", Construtores.Executar},
            {"Métodos com retorno - Classes e métodos", MetodosComRetorno.Executar},
            {"Métodos estáticos - Classes e métodos", MetodosEstaticos.Executar},
            {"Atributos estáticos - Classes e métodos", AtributosEstaticos.Executar},
            {"Desafio atributo - Classes e métodos", DesafioAtributo.Executar},
            {"Params - Classes e métodos", Params.Executar},
            {"Parametros nomeados - Classes e métodos", ParametrosNomeados.Executar},
            {"Get Set - Classes e métodos", GetSet.Executar},
            {"Props - Classes e métodos", Props.Executar},
            {"Readonly - Classes e métodos", Readonly.Executar},
            {"Exemplo Enum - Classes e métodos", ExemploEnum.Executar},
            {"Struct - Classes e métodos", ExemploStruct.Executar},
            {"Struct vs Classe - Classes e métodos", StructVsClasse.Executar},
            {"Valor vs Referencia- Classes e métodos", ValorVsReferencia.Executar},
            {"Parametros por Referencia - Classes e métodos", ParametrosPorReferencia.Executar},
            {"Parametros com Valor Padrão - Classes e métodos", ParametroPadrão.Executar},
            //Coleções
            {"Array - Coleções", Colecoes.Array.Executar },
            {"List - Coleções", ColecoesList.Executar },
            {"ArrayList - Coleções", ColecoesArrayList.Executar },
            {"Set - Coleções", ColecoesSet.Executar },
            {"Queue - Coleções", ColecoesQueue.Executar },
            {"Igualdade - Coleções", Igualdade.Executar },
            {"Coleções Stack - Coleções", ColecoesStack.Executar },
            {"Coleções Dictionary - Coleções", ColecoesDictionary.Executar },
            //OO
            {"Herança - OO", Heranca.Executar },
            {"Construtor This - OO", ConstrutorThis.Executar },
            {"Encapsulamento - OO", OO.Encapsulamento.Executar },
            {"Polimorfismo - OO", Polimorfismo.Executar },
            {"Abstrat - OO", Abstract.Executar },
            {"Interface - OO", Interface.Executar },
            {"Sealed - OO", Sealed.Executar },
            //Métodos e Funções
            {"Exemplo Lambda - Métodos e Funções", ExemploLambda.Executar },
            {"Lambda Delegate - Métodos e Funções", LambdasDelegate.Executar },
            {"Usando Delegate - Métodos e Funções", UsandoDelegate.Executar },
            {"Delegate Func Anonima - Métodos e Funções", DelegateFuncAnonima.Executar },
            {"Delegate como Parametros - Métodos e Funções", DelegatesComoParametros.Executar },
            {"Metodos de Extensão - Métodos e Funções", MetodosDeExtensao.Executar },
            //Exceções
            {"Primeira Exceção - Exceções", PrimeiraExcecao.Executar },
            {"Exceção Personalizadas - Exceções", ExcecoesPersonalizadas.Executar },
            //API
            {"Primeiro Arquvo - API", PrimeiroArquivo.Executar },
            {"Lendo Arquvos - API", LendoArquivos.Executar },
            {"Exemplo FileInfo - API", ExemploFileInfo.Executar },
            {"Diretorios - API", Diretorios.Executar },
            {"Exemplo DirectoryInfo - API", ExemploDirectoryInfo.Executar },
            {"Exemplo Path - API", ExemploPath.Executar },
            {"Exemplo DateTime - API", ExemploDateTime.Executar },
            {"Exemplo TimeSpan - API", ExemploTimeSpan.Executar },
            //Tópicos Avançados
            {"LINQ1 - Tópicos Avançados", LINQ1.Executar },
            {"LINQ2 - Tópicos Avançados", LINQ2.Executar },
            {"Nullables - Tópicos Avançados", Nullables.Executar },
            {"Dynamics - Tópicos Avançados", Dynamics.Executar },
            {"Generics - Tópicos Avançados", Generics.Executar },
           

            });

            central.SelecionarEExecutar();
        }
    }
}