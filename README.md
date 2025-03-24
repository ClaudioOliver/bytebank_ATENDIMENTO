
# Projeto bytebank_Atendimento

Neste projeto iniciamos a criação de varios metodos de array lista estarei descrevendo cada um dos metodos utilizados no projeto.
## Metodos de array list 

## 📘TestaArrayInt 
- Esse método, chamado TestaArrayInt, demonstra o uso de arrays (int[]) em C#

### Descrição passo a passo:

#### Criação e Inicialização do Array:
- Um array de inteiros chamado idades é criado com tamanho 5.
- Cada posição do array recebe um valor específico (30, 15, 60, 45, 19).

#### Exibição do Tamanho do Array:
- O método exibe no console o tamanho total do array (idades.Length), que é 5.

#### Percorrendo o Array com um for:
- Um loop for percorre todas as posições do array.
- Para cada índice, o valor correspondente é impresso no console.
- Os valores do array são somados em uma variável acumulador.

#### Cálculo da Média:
- Após o loop, a média dos valores armazenados no array é calculada como:
Media = Soma das idades / quantidade de elementos

- O valor da média é então impresso no console.

## 📘TesteBuscaPalavra
- Esse método, chamado TesteBuscaPalavra, permite que o usuário insira palavras em um array e, em seguida, faça uma busca por uma palavra específica dentro desse array.

### Descrição passo a passo:

#### Criação e Inicialização do Array:

- Um array de strings chamado arrayDePalavras é criado com tamanho 5.

#### Leitura das palavras do usuário:

- Um loop for percorre todas as posições do array.
- Em cada iteração, solicita ao usuário que digite uma palavra e armazena essa palavra no array.

#### Entrada da palavra a ser buscada:

- Após preencher o array, o usuário digita uma palavra que deseja buscar.

#### Busca da palavra no array:

- Um loop foreach percorre o array.
- A cada iteração, verifica se a palavra do array é igual à palavra digitada pelo usuário.
- Se encontrar, imprime a palavra e interrompe a busca com break.

## 📘TestaMediana
- Esse Metodo calcula a mediana de um conjunto de números armazenados em um array dinâmico criado com Array.CreateInstance.

### Descrição passo a passo:

#### Criação e Preenchimento do Array:
![image](https://github.com/user-attachments/assets/18c5ad22-6e44-4db1-8104-791d496fb987)

- Aqui, um array do tipo double com 5 posições é criado.
- Os valores são atribuídos manualmente com SetValue.

#### Ordenação dos Números e Cálculo da Mediana

double[] numerosOrdenados = (double[])array.Clone();
Array.Sort(numerosOrdenados);

- Faz uma cópia do array original para não alterá-lo.
- Ordena os números de forma crescente.

#### Cálculo da Mediana

![image](https://github.com/user-attachments/assets/e2bf4fb1-0dfa-4d5d-8d93-3c489e5baf05)

- Se o tamanho do array for ímpar, a mediana é o elemento central.
- Se for par, a mediana é a média dos dois elementos centrais.

#### Saída Esperada
- Com os valores [5.9, 1.8, 7.1, 10, 6.9], após a ordenação [1.8, 5.9, 6.9, 7.1, 10], o elemento central é 6.9.


## 📘TesteArrayDeContasCorrentes 
- Esse método TesteArrayDeContasCorrentes demonstra o uso de uma lista de contas correntes por meio de uma classe ListaDeContasCorrentes. Ele adiciona, exibe e remove contas bancárias da lista.

### Descrição passo a passo:

#### Criação da Lista de Contas:
ListaDeContasCorrentes listaDeContas = new ListaDeContasCorrentes();

- Instancia um objeto da classe ListaDeContasCorrentes (Uma lista interna para armazenar contas).

#### Adição de Contas Correntes à Lista:
![image](https://github.com/user-attachments/assets/d9d1d3c0-15d4-4e18-9715-319d0eab41c2)


- Adiciona seis contas bancárias à lista.
- Algumas contas têm o mesmo número, o que sugere que ListaDeContasCorrentes pode permitir duplicatas.

#### Adição da Conta do André:
var contaDoAndre = new ContaCorrente(963, "4456668-B");
listaDeContas.Adicionar(contaDoAndre);

- Cria uma nova conta com agência 963 e o mesmo número "4456668-B" de uma conta já existente.
- Adiciona essa conta à lista.

#### Exibição da Lista:
listaDeContas.ExibeLista();
- Exibe todas as contas armazenadas.

#### Remoção da Conta do André:
listaDeContas.Remover(contaDoAndre);
- Remove a conta do André da lista.

#### Exibição Atualizada da Lista:
listaDeContas.ExibeLista();
- Exibe a lista de contas após a remoção.

## 📘Implamentação de Classe Genericas
![image](https://github.com/user-attachments/assets/93921ab7-9b48-46bb-97f8-178f83359478)

### Descrição passo a passo:
- A classe Generica<T> permite criar objetos que podem trabalhar com qualquer tipo de dado.
- O método MostrarMensagem(T t) recebe um valor do tipo T e exibe esse valor no console.
- O uso de generics torna o código mais reutilizável e flexível, evitando a necessidade de criar múltiplas versões da mesma classe para diferentes tipos de dados.
Esse conceito é amplamente utilizado em estruturas como listas genéricas (List<T>), dicionários (Dictionary<TKey, TValue>) e em métodos genéricos. 🚀

## 📘Implamentação de List
- A implementação acima manipula listas genéricas do tipo List<ContaCorrente> e demonstra o uso de métodos da classe List<T>, como AddRange(), Reverse(), GetRange() e Clear().

![image](https://github.com/user-attachments/assets/c457a134-f1e0-4aab-a93d-ce84e8340087)

### Descrição passo a passo:
- Duas listas de contas são criadas e preenchidas.
- Os elementos da _listaDeContas3 são adicionados à _listaDeContas2.
- A _listaDeContas2 é invertida e seus elementos são exibidos.
- Um subconjunto (GetRange()) é extraído da _listaDeContas3 e impresso.
- A _listaDeContas3 é esvaziada (Clear()).

### Principais métodos utilizados:
- AddRange(): adiciona todos os elementos de uma lista a outra.
- Reverse(): inverte a ordem dos elementos da lista.
- GetRange(início, quantidade): retorna uma sublista da lista original.
- Clear(): remove todos os elementos da lista.


