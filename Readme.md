SOLID:

- S: SRP - Single Resonsabilit Princible
  É um dos princípios SOLID, que o nome já diz, a ideia é ter uma única responsabilidade por classe.
  Ou seja, coesão.

- O: OCP - Open Close Principle
  O OCP diz para escrevermos classes que sejam facilmente extensíveis (ou seja, abertas pra extensão (evolução)).
  Dessa forma, mudar o comportamento da classe atual é fácil:
  basta passar outras implementações concretas das abstrações que ela depende.
  Classes abertas para extensão, mas fechadas para modificação, também são mais coesas.

- L: LSP - Liskov Substitution Priciple
  Uma classe base deve poder ser substituida por sua classe derivada
  implementar OCP permite isso

- I: ISP - Interface Segregation Priciple
  Clientes (classes) não devem ser forcadas a depender de metodos que elas não usam
  Evitar criar interfaces genericas que forçam a implementação de metodos

- D: DIP - Dependency Inversion Principle
  O DIP nos diz para sempre dependermos de módulos que sejam mais estáveis que o módulo corrente.
  Abstrações devem depender de abstrações, e implementação deve depender de abstração.

  Com isso, diminuímos o risco do acoplamento, afinal abstrações são estáveis, e tendem a não mudar
  frequentemente, diminuindo a propagação de problemas.

  Inversão de controle ou injeção de dependencia
  Modulos de alto nível não devem depender de modulos de baixo nivel. Ambos devem depender
  de abstrações; abstraçoes não devem de detalhes. Detalhes devem depender de abstrações

  depender de abstração(interface) e nao de implementação, a implementação muda de acordo
  com a interface
  maior coesao - (é a ligação harmônica entre duas partes, utilizada na gramática como forma de obter um texto claro e compreensível.)

  Quem chama é responsável por fornecer a dependias (controla o comportamento)
  A classe é responsável por chamar dependencia (define o comportamento)

---

- Coesão
  Uma classe coesa é aquela que contém apenas uma única responsabilidade.
  Ou seja, ela toma conta de apenas um conceito dentro do sistema.
  Classes coesas tendem a ser menores, e por consequência, mais fáceis de serem lidas e mantidas.
  Elas também tendem a ser mais reutilizáveis, afinal é mais fácil.

- Acoplamento e estabilidade
  Devemos acoplar classes, interfaces e módulos que sejam estáveis.
  Lembre-se: um módulo estável é aquele que tenta mudar pouco, ou seja,
  ele possui alguma coisa ao redor dele que o faz mudar muito pouco.
  E eu mostrei que, no caso da interface, o número de implementações embaixo,
  o número de pessoas usando aquela interface, são uma força contra mudança.
  Então, acople-se com coisas que são estáveis e evite ao máximo acoplamento com coisas instáveis no seu sistema!

- OCP vc DIP (injeção de dependencia)
  DIP permite implementar OCP
  Ao pensar em classes abertas (OCP), o programador precisa pensar em abstrações (DIP).
  Afinal, é por meio delas que ele vai conseguir estender o comportamento.
  Ao pensar em abstrações, idealmente o programador também pensa na estabilidade de cada uma dessas abstrações.
  Afinal, ele precisa gerenciar o problema do acoplamento.
