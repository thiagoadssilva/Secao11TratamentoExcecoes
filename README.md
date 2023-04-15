# Seção 11: Tratamento de exceções

### O tratamento de exceções é uma parte importante da programação em C#. Ele permite que você lide com erros e situações inesperadas que podem ocorrer durante a execução de um programa. Em C#, você pode usar o bloco "try-catch" para capturar exceções e tratá-las adequadamente.

### O bloco "try" é usado para envolver o código que pode lançar uma exceção. Se uma exceção é lançada, o controle é transferido para o bloco "catch" correspondente. No bloco "catch", você pode lidar com a exceção, exibir mensagens de erro, registrar informações e/ou tomar outras medidas apropriadas.

    Exemplo:
    try
    {
        // código que pode lançar uma exceção
    }
    catch (Exception ex)
    {
        // código para tratar a exceção
        Console.WriteLine("Ocorreu um erro: " + ex.Message);
    }

    O exemplo acima captura todas as exceções e exibe uma mensagem de erro genérica. No entanto, é uma boa prática capturar exceções específicas e tratar cada uma delas adequadamente. Por exemplo:
    try
    {
        int resultado = dividendo / divisor;
    }
    catch (DivideByZeroException ex)
    {
        Console.WriteLine("Divisão por zero não é permitida: " + ex.Message);
    }
    catch (Exception ex)
    {
        Console.WriteLine("Ocorreu um erro: " + ex.Message);
    }

### O exemplo acima captura a exceção "DivideByZeroException" de forma específica e exibe uma mensagem de erro apropriada. Para qualquer outra exceção, uma mensagem de erro genérica é exibida.
### Além disso, em C#, você também pode usar o bloco "finally" para executar um código, independentemente de uma exceção ser lançada ou não. 

    Por exemplo:
    try
    {
        // código que pode lançar uma exceção
    }
    catch (Exception ex)
    {
        // código para tratar a exceção
    }
    finally
    {
        // código que deve ser executado independentemente de uma exceção ser lançada ou não
    }

### O bloco "finally" é útil para limpar recursos ou executar outras ações que devem ser realizadas independentemente de uma exceção ser lançada ou não.

<hr>

# A classe Exception

### A classe Exception em C# é a classe base para todas as exceções que podem ser lançadas durante a execução de um programa. É usada para representar informações sobre erros e exceções que ocorrem durante a execução do programa.
### Ao lançar uma exceção em um programa, você pode criar uma instância da classe Exception e passar informações detalhadas sobre o erro para a exceção. Essas informações incluem uma mensagem de erro, uma descrição detalhada do erro e um objeto de exceção interna que pode ser usado para rastrear a origem do erro.
### Além disso, a classe Exception também contém uma série de propriedades e métodos que permitem que você obtenha informações adicionais sobre a exceção, como o tipo de exceção, o nome do método que lançou a exceção, a linha do código onde a exceção foi lançada e outras informações úteis.
### A classe Exception é uma classe muito importante em C# porque permite que você capture e trate exceções de forma eficaz, o que é essencial para escrever programas robustos e confiáveis. Usando a classe Exception, você pode lidar com erros e exceções de forma adequada, evitando falhas de aplicativos e garantindo a estabilidade do seu programa.

<hr>

# Classes systemExeception e applicationException

### A classe System.Exception é a classe base para todas as exceções em C#, como mencionado anteriormente. Já as classes System.SystemException e System.ApplicationException são classes derivadas da classe base System.Exception e são usadas para representar exceções específicas em um programa.

### A classe System.SystemException é uma classe base para exceções definidas pelo sistema, ou seja, exceções que são geradas pela própria infraestrutura do .NET Framework ou pelo tempo de execução do sistema. Essas exceções incluem erros de acesso a arquivos, falhas de rede, falta de memória, entre outras. A classe System.SystemException é usada como base para todas essas exceções.

### Já a classe System.ApplicationException é uma classe base para exceções definidas pelo usuário, ou seja, exceções que são criadas pelos desenvolvedores para representar erros específicos de seus programas. Esta classe é usada como base para todas as exceções que são criadas pelos desenvolvedores.
### No entanto, a partir do .NET Framework 2.0, a Microsoft recomenda que os desenvolvedores criem exceções personalizadas derivando diretamente da classe System.Exception, em vez de usar a classe System.ApplicationException. A razão para isso é que a classe System.ApplicationException não adiciona nenhum comportamento adicional à classe base System.Exception, e a criação de exceções personalizadas diretamente da classe base é considerada uma abordagem mais limpa e simples.

### Resumindo, enquanto a classe System.SystemException é usada para exceções definidas pelo sistema, a classe System.ApplicationException é usada para exceções definidas pelo usuário, mas a partir do .NET Framework 2.0, a recomendação é criar exceções personalizadas diretamente da classe base System.Exception.

