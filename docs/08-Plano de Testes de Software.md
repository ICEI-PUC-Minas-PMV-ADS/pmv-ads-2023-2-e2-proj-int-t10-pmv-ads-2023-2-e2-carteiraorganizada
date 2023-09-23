# Plano de Testes de Software

Os requisitos para realização dos testes de software são:

- Site publicado na Internet
- Navegador da Internet - Chrome, Firefox ou Edge
- Conectividade de Internet para acesso às plataformas (APISs)


 
| **Caso de Teste** 	| **CT 01 – Cadastrar Perfil** 	|
|:---:	|:---:	|
|	Requisito Associado 	|RF 001 - O sistema deve ter página de cadastro de usuário.|
| Objetivo do Teste 	| Verificar se o usuário consegue se cadastrar na aplicação.|
| Passos 	| Acessar o navegador - Informar o endereço do site Clicar em “Criar Conta” - Preencher os campos obrigatórios (e-mail, nome, sobrenome, senha e confirmar senha. |
|Critério de Êxito |O cadastro foi realizado com sucesso. |
|  	|  	|
| Caso de Teste 	| CT-02 – Efetuar login	|
|Requisito Associado | RF 002 - O sistema deve ter página de login  |
| Objetivo do Teste 	| Verificar se o usuário consegue realizar o login.  |
| Passos 	|  Acessar o navegador - Informar o endereço do site - Acessar o link de login- Preencher o campo e-mail -Preencher o campo da senha - Clicar em login.|
|Critério de Êxito |O login ser realizado com sucesso  |
|  	|  	|
| Caso de Teste 	| CT-03 – Cadastro de Usuário	|
|Requisito Associado | RF 003 - O sistema deve permitir o usuário cadastrar informações e alterar conforme os dados de finanças pessoas se altere.|
| Objetivo do Teste 	| Verificar se o usuário consegue inserir e alterar dados. |
| Passos 	|  Acessar a tela de cadastro das informações financeiras - Inserir as informações solicitadas - Alterar as informações já cadastradas|
|Critério de Êxito |Os dados cadastrados e alterados com sucesso.|
|  	|  	|
| Caso de Teste 	| CT-04 – Avaliação do Serviço	|
|Requisito Associado |RF 004 - O sistema deve permitir que o usuário avalie o serviço.|
| Objetivo do Teste 	| Verificação se a ferramenta de avaliação está funcionando.|
| Passos 	| Após a inserção das informações e salvamento, gerar a janela de avaliação.|
|Critério de Êxito | Mostrar a mensagem: Obrigado pela avaliação. |
|  	|  	|
| Caso de Teste 	| CT-05 – Resumo Financeiro|
|Requisito Associado |RF 005 - O usuário deve ser direcionado para um painel que mostre um resumo das suas finanças pessoais, incluindo saldo total, despesas e receitas recentes.|
| Objetivo do Teste 	| Visualização de todo o resumo financeiro   |
| Passos 	| Acessar a página de relatório financeiro |
|Critério de Êxito | Geração de um painel destacando todas despesas receitas recentes.|
|  	|  	|
| Caso de Teste 	| CT-06 – Registro da Demonstração Financeira	|
|Requisito Associado |RF 006 - Os usuários devem poder registrar suas despesas e receitas, categorizá-las (alimentação, moradia, salário, etc.) e adicionar detalhes relevantes (data, descrição, etc.). É importante permitir a adição de informações recorrentes, como contas mensais.|
| Objetivo do Teste 	|Verificar se o usuário está conseguindo registrar e adicionar os detalhes de cada conta.|
| Passos 	| Acessar o site - Clicar no link de receitas ou despesas -Inserir os dados conforme a demanda.|
|Critério de Êxito | Sucesso nas inclusões e alterações.|
|  	|  	|
| Caso de Teste 	| CT-07 – Configuração para Lembretes Automáticos	|
|Requisito Associado | RF – 007 Os usuários podem configurar lembretes automáticos para pagamentos de contas importantes, evitando atrasos e penalidades.|
| Objetivo do Teste 	|Informar automaticamente ao usuário contas importante.|
| Passos 	| Acessar a página principal - Acessar o link da opção lembretes - Selecionar as contas importantes e salvar |
|Critério de Êxito | Geração do lembrete do pagamento e a data ser efetivado.|
|  	|  	|
| Caso de Teste 	| CT-08 – Envio de notificações por e-mail|
|Requisito Associado |RF 008 - Enviar notificações por e-mail ou mensagens internas sobre atividades importantes.|
| Objetivo do Teste 	| Verificar se as mensagens estão sendo direcionadas para o e-mail cadastrado pelo usuário. |
| Passos 	|  Acessar a página principal - Acessar o link da opção de lembretes - Clicar na caixa receber notificações. |
|Critério de Êxito | Usuário receber as notificações por email |
|  	|  	|
| Caso de Teste 	| CT-09 – Abertura e visualização de suporte ao cliente	|
|Requisito Associado |RF 009 - Fornecer uma seção de suporte ao cliente para responder a perguntas frequentes e permitir a abertura de tickets de suporte.|
| Objetivo do Teste 	| Oferecer ao cliente a opção de suporte ao sistema, em caso de dúvidas, com perguntas e respostas.|
| Passos 	| Acessar a página principal - Acessar o link de suporte - Registrar a abertura de tickets com as dúvidas.|
|Critério de Êxito | Registro efetivado com sucesso e envio de resposta ao cliente.|
|  	|  	|
| Caso de Teste 	| CT-10 – Teste de acessibilidade	|
|Requisito Associado |RF 010 - O site deve ser intuitivo e de fácil utilização, mesmo para usuários não técnicos.|
| Objetivo do Teste 	| Verificar se o sistema e de fácil usabilidade pelos usuários.|
| Passos 	| Acessar a página Inicial - Acessar os links cadastrados|
|Critério de Êxito | Pagina rápida e intuitiva com fácil visualização |
|  	|  	|
| Caso de Teste 	| CT-11 – Verificação Autenticação Usuários	|
|Requisito Associado | RNF  - 01 O site deve ter senhas de acesso e identificação para os usuários. |
| Objetivo do Teste 	| Verificar se a aplicação e de acesso restrita. |
| Passos 	| Acessar o navegador - Informar o endereço do site - Informar e-mail  e senha na tela de login - Clicar em login |
|Critério de Êxito | Acesso de dados somente do usuário autorizado, pela senha.|
|  	|  	|
| Caso de Teste 	| CT-12 – Proteção de Dados 	|
|Requisito Associado |  RNF  - 12 Os dados pessoais devem ser armazenados sob a Lei Geral de Proteção de Dados Pessoais (LGPD)|
| Objetivo do Teste 	|Verificação da Integridade e proteção dos dados dos usuários cadastrados|
| Passos 	| Acessar o gerenciador do banco de dados|
|Critério de Êxito |Somente a pessoal autorizada tem acesso a todos os dados cadastrados.|
|  	|  	|
| Caso de Teste 	| CT-13 – Compatibilidade de Navegadores 	|
|Requisito Associado | RNF  - 03 O sistema deve funcionar nos principais navegadores, como Chrome, Firefox, Edge, Opera. |
| Objetivo do Teste 	| Verificar se o sistema funciona corretamente nas aplicações disponíveis no mercado.|
| Passos 	| Acessar o site nos navegadores Chrome, Firefox, Edge e  Opera - Acessar os links - Acessar todas as telas disponíveis.|
|Critério de Êxito | Site funcionando corretamente, sem nenhum erro nos navegadores.|
|  	|  	|
| Caso de Teste 	| CT-14 – Verificação de disponibilidade 	|
|Requisito Associado | RNF  - 04 O site deve estar disponível e acessível para os usuários 24 horas por dia, 7 dias por semana, com um tempo de inatividade planejado mínimo para manutenção.|
| Objetivo do Teste 	| Disponibilidade da aplicação 24 horas por dia 7 dias por semana|
| Passos 	|  Contratação de um servidor/banco de dados com disponibilidade regional e internacional.|
|Critério de Êxito | Sistema funcionando sem interrupção. |
|  	|  	|
| Caso de Teste 	| CT-15 – Acessibilidade	|
|Requisito Associado | RNF  - 05 O site deverá ser fácil de usar, eficiente e acessível.|
| Objetivo do Teste 	| Verificar se o site possui interface intuitiva para pessoas com necessidades especial.|
| Passos 	| Acessar a aplicação - Acessar o link aumento das letras - Acessar o link pra a leitura da pagina.|
|Critério de Êxito | Aumento das letras e texto gerado em áudio. |
|  	|  	|
| Caso de Teste 	| CT-16 – Segurança dos dados 	|
|Requisito Associado | RNF  - 06 Os dados do usuário devem ser armazenados e transmitidos de forma segura, utilizando criptografia forte.|
| Objetivo do Teste 	| Verificação de segurança dos dados  |
| Passos 	| Acessar a aplicação - Verificar se os dados são de fácil acesso.|
|Critério de Êxito | Aplicação com criptografia forte. |
|  	|  	|

