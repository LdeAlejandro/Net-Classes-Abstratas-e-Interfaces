# Doc Program.cs Herancia-Poliformismo

## Categorización y Documentación del Código

En este documento se presenta una categorización y documentación detallada del código proporcionado, que muestra ejemplos de uso de herencia, polimorfismo y encapsulamiento en C#.

## Herencia y Polimorfismo

El código ejemplifica el uso de herencia y polimorfismo a través de las clases `Aluno` y `Professor`, las cuales heredan de una clase base común `Pessoa`.

# Código Documentado y Categorizado

## Introducción

Este documento contiene ejemplos de código que ilustran conceptos de herencia, polimorfismo y encapsulamiento en C#. Las secciones incluyen el uso de herencia con clases `Aluno` y `Professor`, y encapsulamiento con la clase `ContaCorrente`.

## Código

### Uso de Herencia y Polimorfismo

El siguiente código demuestra el uso de herencia y polimorfismo creando instancias de `Aluno` y `Professor`, que heredan de la clase base `Pessoa`.

```csharp
using Heranca_polimorfismo.Models;

//***********************************************************************
// Herança e polimorfismo

Aluno a1 = new Aluno();

a1.Nome = "Juanito";
a1.Idade = 17;
a1.Nota = 10;
a1.Email = "juanito@gmail.com";
a1.Apresentar();

Professor p1 = new Professor();

p1.Nome = "Eduardo";
p1.Idade = 30;
p1.Salario = 1000;
p1.Apresentar();

```

**Respuesta esperada:**

```text
Olá, meu nome é Juanito e tenho 17 anos e sou um aluno nota 10, meu email é juanito@gmail.com.
Olá, meu nome sou o professor Eduardo de 30 anos. salario: 1000.
```

### Encapsulamiento

El siguiente código muestra el uso del encapsulamiento con la clase `ContaCorrente`, que permite manejar operaciones bancarias básicas.

```c#
//***********************************************************************
Encapsulamento
ContaCorrente c1 = new ContaCorrente(12312312, 1000);

c1.ExibirSaldo();
c1.Sacar(350);
c1.ExibirSaldo();

```

**Respuesta esperada:**

```
Saldo atual: 1000
Saque de 350 realizado.
Saldo atual: 650
```
### Clase Base `Pessoa`

Este código muestra la creación y uso de la clase `Pessoa`, la cual es utilizada como clase base para `Aluno` y `Professor`.

```c#
//***********************************************************************
Pessoa p1 = new Pessoa();
p1.Nome = "Alejandro";
p1.Idade = 29;

p1.Apresentar();
```

**Respuesta esperada:**

```
Olá, meu nome é Alejandro e tenho 29 anos.
```

Código completo:

```c#
﻿using Heranca_polimorfismo.Models;



//***********************************************************************
//Herança e polimorfismo

Aluno a1 = new Aluno();

a1.Nome = "Juanito";
a1.Idade = 17;
a1.Nota = 10;
a1.Email = "juanito@gmail.com";
a1.Apresentar();

Professor p1 = new Professor();

p1.Nome = "Eduardo";
p1.Idade = 30;
p1.Salario = 1000;
p1.Apresentar();

//***********************************************************************
//encapsulamiente
// ContaCorrente c1 = new ContaCorrente(12312312, 1000);

// c1.ExibirSaldo();
// c1.Sacar(350);
// c1.ExibirSaldo();
//***********************************************************************
// Pessoa p1 = new Pessoa();
// p1.Nome = "Alejandro";
// p1.Idade = 29;

// p1.Apresentar();
```
## Conclusión

El código presentado ilustra conceptos fundamentales de herencia, polimorfismo y encapsulamiento en C#. Las secciones están categorizadas para facilitar su comprensión y aplicación en proyectos de programación orientada a objetos.


## Notas Adicionales

- **Herencia y Polimorfismo**: Se demuestra cómo las clases `Aluno` y `Professor` heredan propiedades y métodos de la clase `Pessoa`, y cómo se puede sobrescribir el método `Apresentar` para incluir información específica de cada clase derivada.
- **Encapsulamiento**: Se muestra cómo encapsular datos y operaciones dentro de la clase `ContaCorrente`, asegurando que el saldo de la cuenta no pueda ser modificado directamente desde fuera de la clase.
- **Uso de la Clase Base `Pessoa`**: Se incluye un ejemplo básico de cómo crear e interactuar con una instancia de la clase `Pessoa`.

Este formato documentado y categorizado proporciona una referencia clara y estructurada de los conceptos y su implementación en C#.

# Doc Pessoa.cs Herancia-Poliformismo

### Información y Categorización del Código

#### Descripción General

El código proporcionado define una clase llamada `Pessoa` en el espacio de nombres `Heranca_polimorfismo.Models`. Esta clase modela una entidad genérica de una persona, con propiedades para el nombre y la edad, así como un método virtual para presentar a la persona.

#### Definición de la Clase `Pessoa`

La clase `Pessoa` tiene las siguientes características:

- **Propiedades**:
    
    - `Nome`: Propiedad que almacena el nombre de la persona (tipo `string`).
    - `Idade`: Propiedad que almacena la edad de la persona (tipo `int`).
- **Métodos**:
    
    - `Apresentar()`: Método virtual que imprime un saludo con el nombre y la edad de la persona. El saludo está formateado con el nombre y la edad de la persona. Este método puede ser sobrescrito por clases derivadas para proporcionar un saludo personalizado.
- **Modificador `virtual`**: El método `Apresentar()` se declara con el modificador `virtual`, lo que indica que puede ser sobrescrito por clases derivadas utilizando el mecanismo de polimorfismo.

```c#
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Heranca_polimorfismo.Models
{
    public class Pessoa
    {
        public string Nome { get; set; }
        public int Idade { get; set; }


        // com virtual indicamos que este metodo pode ser alterado com polimorfismo
        public virtual void Apresentar()
        {
            Console.WriteLine($"Olá, meu nome é {Nome} e tenho {Idade} anos.");
        }
    }
}
```
    

#### Comentarios y Documentación

El código proporcionado no incluye comentarios o documentación específica. Sería útil agregar comentarios para explicar el propósito de la clase y los miembros, así como para proporcionar información sobre el uso y el comportamiento esperado de la clase.

# Doc Aluno.cs Herancia-Poliformismo

#### Descripción General

El código proporcionado define una clase llamada `Aluno` que hereda de la clase base `Pessoa` en el espacio de nombres `Heranca_polimorfismo.Models`. Esta clase modela un estudiante y extiende las funcionalidades de la clase base al agregar propiedades específicas para la nota y el correo electrónico del estudiante, así como una implementación sobrescrita del método `Apresentar()`.

#### Definición de la Clase `Aluno`

La clase `Aluno` tiene las siguientes características:

- **Hereda de `Pessoa`**: La clase `Aluno` hereda de la clase base `Pessoa`, lo que significa que adquiere todas las propiedades y métodos de la clase base.
    
- **Propiedades Adicionales**:
    
    - `Nota`: Propiedad que almacena la nota del estudiante (tipo `double`).
    - `Email`: Propiedad que almacena el correo electrónico del estudiante (tipo `string`).
- **Método `Apresentar()` Sobrescrito**: Se sobrescribe el método `Apresentar()` de la clase base para proporcionar una presentación personalizada para los estudiantes. La implementación sobrescrita agrega información sobre la nota y el correo electrónico del estudiante.
    
```c#
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Heranca_polimorfismo.Models
{
    public class Aluno : Pessoa
    {
        public double Nota { get; set; }
        public string Email { get; set; }

        public override void Apresentar()
        {
            Console.WriteLine($"Olá, meu nome é {Nome} e tenho {Idade} anos e sou um aluno nota {Nota}, meu email é {Email}.");
        }

    }
}
```
#### Comentarios y Documentación

El código proporcionado no incluye comentarios o documentación específica. Sería útil agregar comentarios para explicar el propósito de la clase y los miembros, así como para proporcionar información sobre el uso y el comportamiento esperado de la clase.

# Doc ContaCorrente.cs Herancia-Poliformismo

### Información y Categorización del Código

#### Descripción General

El código define una clase llamada `Professor` en el espacio de nombres `Heranca_polimorfismo.Models`, que representa a un profesor y hereda de la clase base `Pessoa`. La clase proporciona una propiedad adicional para el salario del profesor y sobrescribe el método `Apresentar()` para proporcionar una presentación personalizada para los profesores.

#### Definición de la Clase `Professor`

La clase `Professor` tiene las siguientes características:

- **Hereda de `Pessoa`**: La clase `Professor` hereda de la clase base `Pessoa`, lo que significa que adquiere todas las propiedades y métodos de la clase base.
    
- **Propiedad Adicional**:
    
    - `Salario`: Propiedad que almacena el salario del profesor (tipo `decimal`).
- **Método `Apresentar()` Sobrescrito**: Se sobrescribe el método `Apresentar()` de la clase base para proporcionar una presentación personalizada para los profesores. La implementación sobrescrita agrega información sobre el salario del profesor.

```c#
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Heranca_polimorfismo.Models
{
    public class ContaCorrente
    {
        public ContaCorrente(int numeroDeConta, decimal saldoInicial)
        {
            NumeroDeConta = numeroDeConta;
            saldo = saldoInicial;
        }
        public int NumeroDeConta { get; set; }

        private decimal saldo;

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

        
            public void ExibirSaldo()
            {
              Console.WriteLine($"Saldo atual: {saldo}");  
            }
            


    }
}
```


#### Comentarios y Documentación

El código proporcionado no incluye comentarios ni documentación específica. Sería útil agregar comentarios para explicar el propósito de la clase y los miembros, así como para proporcionar información sobre el uso y el comportamiento esperado de la clase.

# Doc Professor.cs Herancia-Poliformismo


### Información y Categorización del Código

#### Descripción General

El código define una clase llamada `Professor` en el espacio de nombres `Heranca_polimorfismo.Models`, que representa a un profesor y hereda de la clase base `Pessoa`. La clase proporciona una propiedad adicional para el salario del profesor y sobrescribe el método `Apresentar()` para proporcionar una presentación personalizada para los profesores.

#### Definición de la Clase `Professor`

La clase `Professor` tiene las siguientes características:

- **Hereda de `Pessoa`**: La clase `Professor` hereda de la clase base `Pessoa`, lo que significa que adquiere todas las propiedades y métodos de la clase base.
    
- **Propiedad Adicional**:
    
    - `Salario`: Propiedad que almacena el salario del profesor (tipo `decimal`).
- **Método `Apresentar()` Sobrescrito**: Se sobrescribe el método `Apresentar()` de la clase base para proporcionar una presentación personalizada para los profesores. La implementación sobrescrita agrega información sobre el salario del profesor.

```c#
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Heranca_polimorfismo.Models;

namespace Heranca_polimorfismo.Models
{
    /// <summary>
    /// Representa um professor que herda as características da classe Pessoa.
    /// </summary>
    public class Professor : Pessoa
    {
        /// <summary>
        /// Obtém ou define o salário do professor.
        /// </summary>
        public decimal Salario { get; set; }

        /// <summary>
        /// Sobrescreve o método Apresentar() da classe base Pessoa para fornecer uma apresentação personalizada para professores.
        /// </summary>
        public override void Apresentar()
        {
            Console.WriteLine($"Olá, meu nome sou o professor {Nome} de {Idade} anos. Salário: {Salario}.");
        }
    }
}
```

#### Comentarios y Documentación

El código incluye comentarios XML que proporcionan información sobre la clase, propiedades y métodos. Estos comentarios son útiles para generar documentación utilizando herramientas como Sandcastle o para proporcionar información contextual dentro del entorno de desarrollo integrado (IDE) durante el desarrollo del código.

