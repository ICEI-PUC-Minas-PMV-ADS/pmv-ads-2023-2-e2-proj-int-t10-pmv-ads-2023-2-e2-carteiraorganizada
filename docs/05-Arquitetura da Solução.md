# Arquitetura da Solução

<span style="color:red">Pré-requisitos: <a href="3-Projeto de Interface.md"> Projeto de Interface</a></span>

Definição de como o software é estruturado em termos dos componentes que fazem parte da solução e do ambiente de hospedagem da aplicação.

## Diagrama de Classes

O diagrama de classes ilustra graficamente como será a estrutura do software, e como cada uma das classes da sua estrutura estarão interligadas. Essas classes servem de modelo para materializar os objetos que executarão na memória.

![Classe UML](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2023-2-e2-proj-int-t10-pmv-ads-2023-2-e2-carteiraorganizada/assets/48370523/ec8c312c-f076-4308-910a-e71e542d37c0)




## Modelo ER (Projeto Conceitual)

Um diagrama entidade relacionamento (ER) é um tipo de fluxograma que ilustra como “entidades”, p. ex., pessoas, objetos ou conceitos, se relacionam entre si dentro de um sistema. Diagramas ER são mais utilizados para projetar ou depurar bancos de dados relacionais nas áreas de engenharia de software, sistemas de informações empresariais, educação e pesquisa. Também conhecidos como DERs, ou modelos ER, usam um conjunto definido de símbolos, tais como retângulos, diamantes, ovais e linhas de conexão para representar a interconectividade de entidades, relacionamentos e seus atributos. Eles espelham estruturas gramaticais, onde entidades são substantivos e relacionamentos são verbos.

![DiagramaER CarteiraOrganizada](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2023-2-e2-proj-int-t10-pmv-ads-2023-2-e2-carteiraorganizada/assets/114626925/124b06a3-a926-4ca6-ad7a-0e32ce394b4b)

## Projeto da Base de Dados

O projeto da base de dados corresponde à representação das entidades e relacionamentos identificadas no Modelo ER, no formato de tabelas, com colunas e chaves primárias/estrangeiras necessárias para representar corretamente as restrições de integridade.

*Requisitos: Informações de Entidade como id, nome de usuario, email e senha, estando essas informações diretamente relacionadas para acesso ao aplicativo. A seguir um cadastro mais completo de perfil solicitando nome, cpf e data de nascimento para uma relação mais definitiva entre os dados. 
*Sistema de Gerenciamento de Banco de Dados (SGBD): Utilizaremos o MYSQL para gerenciamento de DB e também o SQLyog para a criação e gerenciamento de DB com uma visualização gráfica organizada.
*Modelo de dados: Usaremos um modelo de dados simples que descreverá as entidades (tabelas), seus atributos e os relacionamentos entre elas.
*Normalização: Aplicaremos a normalização para que não haja redundâncias ou repetições no BD.
*Segurança: Foco na segurança desde o início. Os dados disponibilizados ficarão em segurança na DB criado e somente o admin do DB terá acesso para alguma possível correção mantendo sigilo das senhas dos clientes.
*Testes: Realizaremos testes frequentes para garantir que o banco de dados funcione como esperado e que os dados sejam armazenados corretamente.
*Documentação do Projeto: Vamos manter uma documentação clara do projeto de base de dados, incluindo esquemas de tabelas, diagramas e descrições de campos.
![tabela DB carteira organizada](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2023-2-e2-proj-int-t10-pmv-ads-2023-2-e2-carteiraorganizada/assets/115134851/3aa4e389-d3fa-4895-979a-372609974936)

![Sem título](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2023-2-e2-proj-int-t10-pmv-ads-2023-2-e2-carteiraorganizada/assets/115134851/82b2df90-317c-4ee8-96ee-9c71f0ecbde6)



## Tecnologias Utilizadas

- [Lucidchart](https://www.lucidchart.com) Ferramenta utilizada para Criar o Diagrama de Classe.
- [Figma](https://www.figma.com) Ferramenta utilizada para criar o Wireframe.

## Hospedagem

Explique como a hospedagem e o lançamento da plataforma foi feita.

> **Links Úteis**:
>
> - [Website com GitHub Pages](https://pages.github.com/)
> - [Programação colaborativa com Repl.it](https://repl.it/)
> - [Getting Started with Heroku](https://devcenter.heroku.com/start)
> - [Publicando Seu Site No Heroku](http://pythonclub.com.br/publicando-seu-hello-world-no-heroku.html)
