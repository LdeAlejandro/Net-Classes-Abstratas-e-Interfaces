
# Doc Program.cs Clases Abstractas e Interfaces

### Uso de Interfaces y Clases Abstractas en el Ejercicio

En este código, se están utilizando interfaces y clases abstractas para modelar diferentes comportamientos y relaciones entre objetos. A continuación, se explica cada parte del código:

#### Uso de Interfaz y Clase Implementadora


```c#
// Instancia de la interfaz ICalculadora utilizando la clase Calculadora que la implementa
ICalculadora c1 = new Calculadora();

// Llamadas a los métodos definidos en la interfaz ICalculadora
Console.WriteLine($"Soma: {c1.Somar(1,3)}");
Console.WriteLine($"Substrair: {c1.Subtrair(1,3)}");
Console.WriteLine($"Multiplicar: {c1.Multiplicar(1,3)}");
Console.WriteLine($"Dividir: {c1.Dividir(1,3)}");

```

En este fragmento, se crea una instancia de la interfaz `ICalculadora` utilizando la clase `Calculadora`, que implementa los métodos definidos en la interfaz. Luego, se realizan llamadas a estos métodos para realizar operaciones matemáticas básicas.

#### Otros Ejemplos de Uso

```c#
// Instancia de un objeto de la clase Computador y llamada al método ToString()
Computador c = new Computador();
Console.WriteLine(c.ToString());

// Creación de un objeto Aluno con un nombre específico y llamada al método Apresentar()
Aluno a1 = new Aluno("Pedrito");
a1.Apresentar();

// Creación de un objeto Corrente y llamada al método Creditar()
Corrente c = new Corrente();
c.Creditar(500);
c.ExibirSaldo();
```


Estos fragmentos muestran ejemplos adicionales de cómo se pueden utilizar clases y métodos definidos en el ejercicio. Se instancia un objeto de la clase `Computador` y se llama al método `ToString()`, se crea un objeto `Aluno` con un nombre específico y se llama al método `Apresentar()`, y se crea un objeto `Corrente` y se llama al método `Creditar()`.

# Doc Professor .cs Clases Abstractas e Interfaces

En esta clase, se modela un profesor que hereda de la clase `Pessoa`. Se proporcionan constructores que permiten la creación de instancias con o sin pasar el nombre. Se agrega una propiedad `Salario` y se sobrescribe el método `Apresentar()` de la clase base `Pessoa`, sellándolo para evitar que sea modificado en clases derivadas.

```c#
namespace Abstract_exercise.Models
{
    public class Professor : Pessoa
    {
        // Constructor de la clase Professor que llama al constructor de la clase base Pessoa
        public Professor(String nome) : base(nome)
        {

        }

        // Constructor adicional que permite instanciar la clase sin pasar el nombre
        public Professor()
        {

        }

        // Propiedad adicional de la clase Professor
        public decimal Salario { get; set; }

        // Método sobrescrito de la clase base Pessoa
        public sealed override void Apresentar()
        {
            Console.WriteLine($"Olá, meu nome sou o professor {Nome} de {Idade} anos. salario: {Salario}.");
        }
    }
}

```

# Doc Pessoa.cs Clases Abstractas e Interfaces

En esta clase, se modela una persona con un nombre y una edad. Se proporciona un constructor que requiere el nombre como parámetro y otro constructor sin parámetros para permitir la creación de instancias sin pasar el nombre. Además, se implementa un método virtual `Apresentar()` que muestra el nombre y la edad de la persona.

```c#
namespace Abstract_exercise.Models
{
    public class Pessoa
    {
        // Constructor de la clase Pessoa que requiere el nombre como parámetro
        public Pessoa (string nome)
        {
            Nome = nome;
        }

        // Constructor adicional que permite instanciar la clase sin pasar el nombre
        public Pessoa ()
        {

        }

        // Propiedades de la clase Pessoa
        public string Nome { get; set; }
        public int Idade { get; set; }

        // Método virtual que puede ser sobrescrito en clases derivadas
        public virtual void Apresentar()
        {
            Console.WriteLine($"Olá, meu nome é {Nome} e tenho {Idade} anos.");
        }
    }
}
```
#Doc ICalculadora Clases Abstractas e Interfaces

#net #netfundamentos #Dio #Doc #programming #bootcamp #bootcampAvanade #avanade #curso #ClasesAbstractas-Interfaces

### Interfaz `ICalculadora`

La interfaz `ICalculadora` define un conjunto de métodos para realizar operaciones matemáticas básicas. Estos métodos deben ser implementados por cualquier clase que desee actuar como una calculadora.

```c#
// Declaración de la interfaz ICalculadora
public interface ICalculadora
{
    // Métodos que deben ser implementados por las clases que utilicen esta interfaz
    int Somar(int num1, int num2);
    int Subtrair(int num1, int num2);
    int Multiplicar(int num1, int num2);
    int Dividir(int num1, int num2);

    // Este método también se define en la interfaz, pero proporciona una implementación predeterminada
    // Las clases que implementen esta interfaz pueden optar por usar esta implementación o proporcionar una propia
    int Dividir(int num1, int num2)
    {
        return num1, num2;
    }
}
```

Esta interfaz proporciona una especificación clara de las operaciones que una calculadora debe admitir. Cualquier clase que desee actuar como una calculadora debe implementar esta interfaz y proporcionar implementaciones para los métodos definidos en ella.

# Doc Diretor.cs Clases Abstractas e Interfaces


#net #netfundamentos #Dio #Doc #programming #bootcamp #bootcampAvanade #avanade #curso #ClasesAbstractas-Interfaces


En esta clase, se intenta sobrescribir el método `Apresentar()` de la clase base `Professor`, lo cual daría error si el método en la clase base estuviera sellado.

```c#
public class Diretor: Professor
{
     Se muestra un ejemplo de intento de sobreescritura de método en una clase sellada
     Este fragmento daría error si el método en la clase base estuviera sellado
     public override void Apresentar()
     {
         Console.WriteLine($"Diretor");
     }
}
```

#Doc Corrente.cs Clases Abstractas e Interfaces


#net #netfundamentos #Dio #Doc #programming #bootcamp #bootcampAvanade #avanade #curso #ClasesAbstractas-Interfaces

Esta clase hereda de la clase `Conta` y sobrescribe el método `Creditar()`, que agrega un valor al saldo de la cuenta.

```c#
public class Corrente : Conta
{
    // Método sobreescrito de la clase base Conta
    public override void Creditar(decimal valor)
    {
        saldo += valor;
    }
}
```
# Doc ContaCorrente.cs Doc Program.cs Clases Abstractas e Interfaces

En este conjunto de códigos, se utilizan clases y herencia para modelar diferentes tipos de objetos y comportamientos. A continuación, se documenta y explica cada parte del código:

```c#
public class ContaCorrente 
{
    // Constructor de la clase ContaCorrente
    public ContaCorrente(int numeroDeConta, decimal saldoInicial)
    {
        NumeroDeConta = numeroDeConta;
        saldo = saldoInicial;
    }

    // Propiedades de la clase ContaCorrente
    public int NumeroDeConta { get; set; }
    private decimal saldo;

    // Método para realizar un retiro de la cuenta
    public void Sacar(decimal valor)
    {
        if(saldo >= valor)
        {
            saldo -= valor;
            Console.WriteLine($"Saque de {valor} realizado.");
        }
        else
        {
            Console.WriteLine($"Sem saldo suficiente.");
        }
    }

    // Método para mostrar el saldo actual
    public void ExibirSaldo()
    {
        Console.WriteLine($"Saldo atual: {saldo}");  
    }
}

```
En esta clase, se modela una cuenta corriente con un número de cuenta y un saldo. Se implementan métodos para realizar retiros (`Sacar()`) y mostrar el saldo (`ExibirSaldo()`).


# Doc Conta.cs Abstractas e Interfaces

#net #netfundamentos #Dio #Doc #programming #bootcamp #bootcampAvanade #avanade #curso

La clase abstracta `Conta` proporciona un modelo básico para una cuenta bancaria. Define una propiedad `saldo` y un método abstracto `Creditar(decimal valor)`.

```c#
public abstract class Conta
{
    // Propiedad protegida para el saldo
    protected decimal saldo;

    // Método abstracto para acreditar dinero en la cuenta
    public abstract void Creditar(decimal valor);

    // Método para mostrar el saldo actual
    public void ExibirSaldo()
    {
        Console.WriteLine($"O seu saldo é: {saldo}");
    }
}
```

#Doc Computador.cs Clases Abstractas e Interfaces

### Clase `Computador`

La clase `Computador` sobrescribe el método `ToString()` para proporcionar una representación en forma de cadena del objeto.

```c#
public class Computador
{
    // Método ToString() sobreescrito
    public override string ToString()
    {
        return "Metodo ToString sobreescrito";
    }
}
```

# Doc Calculadora.cs Clases Abstractas e Interfaces

### Clase `Calculadora`

La clase `Calculadora` implementa la interfaz `ICalculadora` y proporciona métodos para realizar operaciones matemáticas básicas.

```c#
public class Calculadora : ICalculadora
{
    // Implementación de los métodos de la interfaz ICalculadora
    public int Somar(int num1, int num2)
    {
        return num1 + num2;
    }

    public int Somar(int num1, int num2, int num3)
    {
        return num1 + num2 + num3;
    }

    public int Subtrair(int num1, int num2)
    {
        return num1 - num2;
    }

    public int Multiplicar(int num1, int num2)
    {
        return num1 * num2;
    }

    public int Dividir(int num1, int num2)
    {
        return num1 / num2;
    }
}
```
# Doc Aluno.cs Clases Abstractas e Interfaces

### Clase `Aluno`

La clase `Aluno` representa un estudiante y hereda de la clase `Pessoa`. Contiene propiedades adicionales como `Nota` y `Email`.

```c#
public class Aluno : Pessoa
{
    // Constructor que llama al constructor de la clase base con un nombre
    public Aluno(String nome) : base(nome)
    {

    }

    // Constructor vacío adicional para instanciar sin pasar un nombre
    public Aluno()
    {

    }

    public double Nota { get; set; }
    public string Email { get; set; }

    // Método Apresentar() sobreescrito para mostrar información del alumno
    public override void Apresentar()
    {
        Console.WriteLine($"Olá, meu nome é {Nome} e tenho {Idade} anos e sou um aluno nota {Nota}, meu email é {Email}.");
    }
}
```



