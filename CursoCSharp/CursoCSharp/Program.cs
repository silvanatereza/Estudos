using System;
using System.Collections.Generic;

using CursoCSharp.Fundamentos;
using CursoCSharp.EstruturaDeControle;
using CursoCSharp.ClasseseMetodos;
using CursoCSharp.colecoes;

namespace CursoCSharp {
    class Program {
      

        static void Main(string[] args) {
            var central = new CentralDeExercicios(new Dictionary<string, Action>() {
                    //Fundamentos 
                
                {"Primeiro Programa - Fundamentos", PrimeiroProjeto.Executar},
                {"Comentarios - Fundamentos", Comentarios.Executar},
                {"Variaveis e Constantes -Fundamentos", VariaveisEConstantes.Executar },
                {"Inferencias´- Fundamentos ", Inferencias.Executar },
                {"Interpolação - Fundamentos" , Interpolação.Executar },
                {"Notação Ponto - Fundamentos ", NotaçãoPonto.Executar },
                {"Lendo Dados - Fundamentos" , LendoDados.Executar },
                {"Formatando Números - Fundamentos" , FormatandoNumeros.Executar },
                {"Conversões- Fundamentos" , Conversões.Executar },
                {"Operadores Aritimeticos - Fundamentos" , OperadoresAritimeticos.Executar },
                {"Operadores Relacionais - Fundamentos" ,  OperadoresRelacionais.Executar },
                {"Operadores Lógicos - Fundamentos" ,  OperadoresLogicos.Executar },
                {"Operadores de Atribuição  - Fundamentos" ,  OperadoresAtribuicao.Executar },
                {"Operadores Unários  - Fundamentos" ,  OperadoresUnarios.Executar },
                {"Operadores Ternario - Fundamentos" ,  OperadorTernario.Executar },

                //  Estruturas de controle 
               
                {" Estrutura IF  -  Estruturas de controle " ,  EstruturaIF.Executar },
                {" Estrutura IF/ELSE  -  Estruturas de controle " ,  EstruturaIFELSE.Executar },
                {" Estrutura IF/ELSE/IF  -  Estruturas de controle " ,  EstruturaIfElseIf.Executar },
                {" Estrutura Swith  -  Estruturas de controle " ,  EstruturaSwith.Executar },
                {" Estrutura While  -  Estruturas de controle " ,  EstruturaWhile.Executar },
                {" Estrutura DoWhile  -  Estruturas de controle " ,EstruturaDoWhile.Executar },
                {" Estrutura For -  Estruturas de controle " , EstruturaFor.Executar },
                {" Estrutura ForEach -  Estruturas de controle " , EstruturaForEach.Executar },
                {" Usando Break -  Estruturas de controle " , UsandoBreak.Executar },
                {" Usando Continue-  Estruturas de controle " , UsandoContinue.Executar },
                
                /// Classes e Métodos
                
                {" Membros - Clsses e Métodos " , Membros.Executar },
                {" Construtores - Clsses e Métodos " , Construtores.Executar },
                {" Metodos Com Retorno  - Clsses e Métodos " , MetodoComRetorno.Executar },
                {" Metodos Estáticos   - Clsses e Métodos " , MetodosEstaticos.Executar },
                {" Atributos Estáticos   - Clsses e Métodos " , AtributosEstaticos.Executar },
                {" Params - Clsses e Métodos " , Params.Executar },
                {" Parâmetros Nomeados - Clsses e Métodos " , ParametrsoNomeados.Executar },
                {" Get Set  - Clsses e Métodos " ,  GetSet.Executar },
                {" Props  - Clsses e Métodos " ,  Props.Executar },
                {" Readonly - Clsses e Métodos " ,  Readonly.Executar },
                {" Enum     - Clsses e Métodos " ,  ExemploEnum.Executar },
                {" Struct    - Clsses e Métodos " ,  ExemploStruct.Executar },
                {" Struct vs Classes   - Clsses e Métodos " ,  StructVsClasses.Executar },
                {" Valor  vs Referência   - Clsses e Métodos " ,  ValorVsReferencia.Executar },
                {"Parâmetros por Referência   - Clsses e Métodos " ,  ParametrosPorReferencia.Executar },

                //     Coleções 

                {"Array   - Coleções " ,  colecoes.Array.Executar },
                {"list  - Coleções " ,  Colecoeslist.Executar },
            });

         

            central.SelecionarEExecutar();
        }
    }
}