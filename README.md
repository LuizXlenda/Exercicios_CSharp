# Exercicios_CSharp
Atividade Avaliativa C# 1,0 Pontos - Luiz Henrique Storrer - Amanda Edling Ferreira

Exercicio01 - Validador de Senhas Fortes: 
Foram criadas funções estáticas que fazem a verificação da senha digitada. Uma função para verificar se tem uma letra maiúscula, uma que verifica se tem pelo menos um número e outra que verifica se tem pelo menos um carácter especial. 
Foi criado uma função estática que retorna um booleano que caso seja true a senha está correta, caso falso, incorreto. 
No Main foi criado um if que caso a senha digitada esteja correta é mostrado na tela que a senha está correta, caso contrário incorreta. Se estiver incorreta, o programa apresenta na tela os requisitos que devem ser cumpridos para a validação da senha.

Exercicio02 - Tabuada Completa com Laço:
Foi realizado um For, onde o número digitado percorre um loop onde ele é multiplicado pelo índice, até que chegue a 10.

Exercicio03 - Cálculo de Fatorial com while:
No programa foi solicitado um número maior que zero para ser realizado a fatoração. Em seguida, um If caso o número for menor que zero é apresentado na tela que o número é inválido. Em seguida foi feito um while que calcula o fatorial através de um índice (contador), que multiplica o número digitado, fatorando e armazenando na variável "fatorial". Em seguida, apresenta o resultado na tela.

Exercicio04 - Conversor de Temperaturas com Menu (detalhado):
Foi realizado um loop "do while" que repetia o conversor de temperatura até que o usuario selecionasse a opção de sair na função "switch". Dentro do "do", fizemos um menu simples, onde o usuario seleciona o tipo de conversão que quer fazer assim como menciona no exercicio, e uma opção para caso queira encerrar o programa. Em seguida fizemos um switch. 
- Caso 1 (switch): Conversão de Celsius para Fahrenheit. Foi criado uma variavel "cel" onde é armazenado o valor em celsius digitado pelo usuario (utilizando double.Parse(Console.ReadLine()) que converte o valor em double pois a função Console.ReadLine() pega o valor inputado pelo usuario em string), em seguida é feito o calculo de acordo com a formula de conversão para fahrenheit e armazenado na variavel "fah", após isso o resultado é mostrado na tela com o comando "Console.WriteLine()". 

- Caso 2 (switch): Conversão de Fahrenheit para Celsius. Assim como no caso 1, criamos uma variavel chamada "fah1" (digito 1 para não conflitar com o caso 1), que armazena o valor em fahrenheit digitado pelo usuario. Em seguida é realizado o calculo de acordo com a formula de conversão para celsius e armazenado na variavel "cel1", após isso o resultado é armazenado na tela. Essas seleções podem se repetir de acordo com a vontade do usuario, ele pode continuar escolhendo fazer as conversões até que escolha a opção 3. 

- Caso 3 (switch): é apresentado na tela a mensagem "Programa encerrado!" e o loop se encerra devido a condição do while "(opcao != 3)" que significa que se a variavel "opcao" declarada no menu for diferente de 3 o loop continuará sendo executado, então como a opção selecionada foi 3, o loop se encerra e consequentemente o programa também. 

- Caso 4 (switch): Mensagem de erro para caso a opção selecionada no menu for diferente de 1, 2 ou 3, após a mensagem, o loop se repete e o menu é apresentado novamente.

Exercicio05 - Verificador de Palíndromos: Foi utilizado a função Replace e ToLower para tirar os espaços em branco e deixar as letras minusculas da string digitada pelo usuario, em seguida essa string é transformada em um array de caracteres, após isso transformamos esse array em uma string novamente, porem de forma invertida, em seguida fizemos um if onde se a string lá do começo sem espaços ou letras maiúsculas coincidir com a string com o texto invertido, apresenta na tela "É um palindromo" se não "Não é um palindromo".

Exercicio06 - Cadastro Simples de Produtos: Foi criada uma classe chamada Produto que representa um produto com nome, preço e quantidade. Essa classe tem um construtor para facilitar o cadastro dos dados e um método chamado Total que calcula o valor total em estoque multiplicando o preço pela quantidade. No método Main foi criado um array com três posições para armazenar os produtos. Em um laço for o programa pede ao usuário que digite o nome, o preço e a quantidade de cada produto. Depois, um laço foreach exibe na tela os dados de cada produto junto com o total em estoque calculado pelo método da classe.

Exercicio07 - Soma de Números Pares de um Array: Foi criado um array para armazenar 10 números inteiros digitados pelo usuário. Durante o laço for o programa pede que o usuário digite um número e verifica se esse número é par usando o operador de módulo. Se for par ele é somado em uma variável chamada soma. Ao final do laço o programa exibe na tela o total da soma dos números pares que foram digitados.

Exercicio08 - Cálculo de IMC com Classificação (detalhado): Foram criadas variáveis para armazenar o peso em kg e a altura em metros do usuário, utilizando o Console.ReadLine(), porem como se trata de uma double e essa função captura string, utilizamos a função double.Parse() para converter a string para double. Em seguida fizemos o cauculo do IMC (peso dividido pela a altura ao quadrado) e armazenamos em uma variável e apresentamos na tela, logo em seguida fizemos varias condicionais com if, else if. Se caso o IMC for menor ou igual a 18.5, é apresentado na tela a informação de que o usuário está abaixo do peso, caso for maior que 18.5 e menor que 24.9, peso ideal, caso for maior que 25 e menor que 29.9, sobrepeso, e caso for maior ou igual a 30, obesidade.

Exercicio09 - Jogo da Adivinhação: Foi usado um gerador de número aleatório com a classe Random do C#. O programa gera um número secreto entre 1 e 100 e pede para o usuário tentar adivinhar. Cada vez que o usuário digita um palpite o programa compara com o número secreto e diz se o número é maior ou menor. O laço do while repete até que o usuário acerte o número. A cada tentativa a variável tentativas é incrementada e ao final o programa mostra quantas tentativas foram necessárias para acertar.

Exercicio10 - Lista de Tarefas (To-Do List): Criamos listas para armazenar as tarefas do usuario (string) e as informações booleanas para marcar tarefa como concluida. Dentro de um do while com a condição de finalizar com a opção 0 do switch, criamos um switch com 3 opções sem contar a opção de sair, onde a primeira opção é para adicionar uma nova tarefa a lista, a segunda opção é para listar todas as tarefas da lista, a opção 3 é para marcar uma tarefa como concluida, e caso o usuario digite algo diferende de 1, 2, 3 ou 0, o default do switch vai apresentar na tela que a opção está inválida e repetir o loop, até que o usuario selecione o caso 0.
