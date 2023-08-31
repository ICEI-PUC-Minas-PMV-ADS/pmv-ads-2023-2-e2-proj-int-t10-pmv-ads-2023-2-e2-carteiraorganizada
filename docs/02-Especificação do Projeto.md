# Especificações do Projeto

A definição do problema e os pontos mais relevantes a serem tratados nesse projeto foi consolidado através de observação das necessidades dos indivíduos em ter uma facilidade de levantamento e apuração do seu controle financeiro.

## Personas

Os detalhes levantados por meio, de entrevistas, foram consolidados na forma de Personas e História dos Usuários.

## Marina Fernandez

Idade: 35

Ocupação: Gerente de Recursos Humanos, funcionária de uma multinacional do setor de alimentos e bebidas. Casada, reside em uma grande capital do país.

Aplicativos:

● Instagram

● Facebook

● LinkedIn

Motivações

● Família

● Estudos

● Vontade de vencer

Frustrações

● País

● Falta de Oportunidade

● Falta de Empatia pelos colegas de trabalho

Hobbies, História

● Andar de Bicicleta

● Reunir com a família nos finais de semana

## Mario de Andrade

Idade: 40

Ocupação: Microempresário, com um pequeno comércio especializado em manutenção e vendas de máquinas de lavar usadas e peças não utilizadas. Casado, reside em uma cidade do interior de Minas Gerais.

Aplicativos:

● Facebook

● Instagram

● Aplicativos de bancos

Motivações

● Estar com a família

● Buscar rendas extras

Frustrações

● Não conseguir chegar nos objetivos determinados

Hobbies, História

● Jogar futebol com o filho

● Estar junto com a família nos finais de semana.

## Jose Maria

Idade: 20

Ocupação: Autônomo, trabalha como freelancer em criação e manutenção de sistemas de informação. Solteiro, reside com os familiares em uma grande capital do país.

Aplicativos:

● Marvel

● Instagram

● Visual basic

Motivações

● Criar novos projetos

● Buscar rendas extras

● Buscar novos conhecimentos na área em que trabalha

Frustrações

● Não concluir um projeto no prazo estipulado

Hobbies, História

● Jogar jogos de futebol

● Tocar guitarra.

## Fernanda Tavares

Idade: 31

Ocupação: Professora, leciona aulas em uma grande universidade especializada em pesquisa e extensão no Brasil. Solteira, residente na cidade de Montes Claros - MG.

Aplicativos:

● Facebook

● Instagram

● Aplicativo Bancário

Motivações

● Ser professora

● Levar o conhecimento a vários alunos

● Buscar novos conhecimentos para agregação

Frustrações

● Não ser respeitada como professora

● Sua profissão não ser valorizada, pela sua importância

Hobbies, História

● Leitura

● Viagens

## Ricardo Almeida

Idade: 50

Ocupação: enfermeiro, trabalha em uma policlínica e agente de saúde pública. Casado, residente na cidade do Rio de Janeiro.

Aplicativos:

● Facebook

● Instagram

● Aplicativo Bancário

Motivações

● Se considerar um grande profissional

● Gosta da sua profissão

● Fazer o bem ao próximo

Frustrações

● Não ter conquistado uma graduação

● Más condições de trabalho.

Hobbies, História

● Ajudar a cuidar no neto

● Viagens.


## Histórias de Usuários

Com base na análise das personas forma identificadas as seguintes histórias de usuários:

|EU COMO... `PERSONA`| QUERO/PRECISO ... `FUNCIONALIDADE` |PARA ... `MOTIVO/VALOR`                 |
|--------------------|------------------------------------|----------------------------------------|
|Marina Fernandez    | Manter toda a movimentação financeira registrado mês a mês | Melhor controle financeiro|
|Marina Fernandez    |visualizar os registros detalhados das entradas e de qual fonte pagadora.| Ter ciência de qual fonte pagadora está entrando mais dinheiro. |
|José Maria  | Visualizar a pesquisa de gastos e despesas realizados durante um ano específico.          | Para organização e planejamento do ano seguinte.|
|José Maria      | Visualizar as despesas e os gastos realizados no mês.| Para maior controle dos gastos e despesas de casa. |
|Mario de Andrade      | Ter um controle financeiro sobre as entradas das manutenções de vendas de máquinas de lavar e peças usadas.| Um melhor fluxo de entrada e saída e das despesas diversas. |
|Mario de Andrade  | Mostrar detalhadamente as entradas e saídas mês a mês.| Gerar um relatório para demonstrar se o negócio está dando lucro ou prejuízo.|
|Fernanda Tavares | Poder realizar a pesquisa de um gasto ou despesa específico.| Ficar fácil atalhar onde está ocorrendo um desembolso maior de valor. |
|Fernanda Tavares | Gerar um relatório de todas as entradas e saídas.| Para um melhor planejamento para o próximo ano/período.|
|Ricardo Almeida       | Um sistema ágil e rápido para inclusão de entradas e saídas de valores.| Para melhor controle e agilidade em uma tomada de uma decisão financeira.|
|Ricardo Almeida |Poder realizar uma pesquisa por exemplo, quanto foi gasto de luz em período específico.| Controle não só do valor gasto com luz, mas também o controle de consumo realizado em um determinado período.|


## Requisitos

### Requisitos Funcionais

|ID    | Descrição do Requisito  | Prioridade |
|------|-----------------------------------------|----|
|RF-001|O sistema deve ter página de cadastro de usuário  | ALTA | 
|RF-002| O sistema deve ter página de login  | ALTA  |
|RF-003| O sistema deve permitir o usuário cadastrar informações, modificar e alterar conforme os dados de finanças pessoas se altere | ALTA | 
|RF-004| O sistema deve permitir que o usuário avalie o serviço   | MÉDIA |
|RF-005| O usuário deve ser direcionados para um painel que mostre um resumo das suas finanças pessoais, incluindo saldo total, despesas e receitas recentes | ALTA | 
|RF-006| Os usuários devem poder registrar suas despesas e receitas, categorizá-las (alimentação, moradia, salário, etc.) e adicionar detalhes relevantes (data, descrição, etc.). É importante permitir a adição de informações recorrentes, como contas mensais| ALTA |
|RF-007| Os usuários podem configurar lembretes automáticos para pagamentos de contas importantes, evitando atrasos e penalidades| ALTA | 
|RF-008| Enviar notificações por e-mail ou mensagens internas sobre atividades importantes  | ALTA |
|RF-009| Fornecer uma seção de suporte ao cliente para responder a perguntas frequentes e permitir a abertura de tickets de suporte |ALTA | 
|RF-010| O site deve ser intuitivo e de fácil utilização, mesmo para usuários não técnicos.  | ALTA |

### Requisitos não Funcionais

| ID    | Descrição do Requisito  |Prioridade |
|-------|-------------------------|----|
|RNF-001| O site deve ter senhas de acesso e identificação para os usuários| ALTA | 
|RNF-002| Os dados pessoais devem ser armazenados sob a Lei Geral de Proteção de Dados Pessoais (LGPD)| ALTA |
|RNF-003|O sistema deve funcionar nos principais navegadores, como Chrome, Firefox, Edge, Opera.| ALTA | 
|RNF-004| O site deve estar disponível e acessível para os usuários 24 horas por dia, 7 dias por semana, com um tempo de inatividade planejado mínimo para manutenção | ALTA |
|RNF-005| O site deverá ser fácil de usar, eficiente e acessível | ALTA | 
|RNF-006|Os dados do usuário devem ser armazenados e transmitidos de forma segura, utilizando criptografia forte  |  ALTA |

### Restrições

As questões que limitam a execução desse projeto e que se configuram como obrigações claras para o desenvolvimento do projeto em questão são apresentadas na tabela a seguir.
|-------|-------------------------|----|
|RE-001| O projeto deverá ser entregue no final do semestre letivo.| ALTA | 
|RE-002| O aplicativo deve se restringir às tecnologias básicas da Web no Frontend |  ALTA |
|RE-003| A equipe não pode subcontratar o desenvolvimento do trabalho. | MÉDIA | 


Com base nas Histórias de Usuário, enumere os requisitos da sua solução. Classifique esses requisitos em dois grupos:

- [Requisitos Funcionais
 (RF)](https://pt.wikipedia.org/wiki/Requisito_funcional):
 correspondem a uma funcionalidade que deve estar presente na
  plataforma (ex: cadastro de usuário).
- [Requisitos Não Funcionais
  (RNF)](https://pt.wikipedia.org/wiki/Requisito_n%C3%A3o_funcional):
  correspondem a uma característica técnica, seja de usabilidade,
  desempenho, confiabilidade, segurança ou outro (ex: suporte a
  dispositivos iOS e Android).
Lembre-se que cada requisito deve corresponder à uma e somente uma
característica alvo da sua solução. Além disso, certifique-se de que
todos os aspectos capturados nas Histórias de Usuário foram cobertos.

## Restrições

O projeto está restrito pelos itens apresentados na tabela a seguir.

|ID| Restrição                                             |
|--|-------------------------------------------------------|
|01| O projeto deverá ser entregue até o final do semestre |
|02| Não pode ser desenvolvido um módulo de backend        |


Enumere as restrições à sua solução. Lembre-se de que as restrições geralmente limitam a solução candidata.

> **Links Úteis**:
> - [O que são Requisitos Funcionais e Requisitos Não Funcionais?](https://codificar.com.br/requisitos-funcionais-nao-funcionais/)
> - [O que são requisitos funcionais e requisitos não funcionais?](https://analisederequisitos.com.br/requisitos-funcionais-e-requisitos-nao-funcionais-o-que-sao/)

## Diagrama de Casos de Uso
[PUC - Eixo 2.pdf](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2023-2-e2-proj-int-t10-pmv-ads-2023-2-e2-carteiraorganizada/files/12481197/PUC.-.Eixo.2.pdf)



O diagrama de casos de uso é o próximo passo após a elicitação de requisitos, que utiliza um modelo gráfico e uma tabela com as descrições sucintas dos casos de uso e dos atores. Ele contempla a fronteira do sistema e o detalhamento dos requisitos funcionais com a indicação dos atores, casos de uso e seus relacionamentos. 

As referências abaixo irão auxiliá-lo na geração do artefato “Diagrama de Casos de Uso”.

> **Links Úteis**:
> - [Criando Casos de Uso](https://www.ibm.com/docs/pt-br/elm/6.0?topic=requirements-creating-use-cases)
> - [Como Criar Diagrama de Caso de Uso: Tutorial Passo a Passo](https://gitmind.com/pt/fazer-diagrama-de-caso-uso.html/)
> - [Lucidchart](https://www.lucidchart.com/)
> - [Astah](https://astah.net/)
> - [Diagrams](https://app.diagrams.net/)
