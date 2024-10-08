### Relatório do Projeto: Sistema de Pedidos para Lanchonete

**Disciplina:** Programação Orientada a Objetos 2  
**Autor:** Pedro Calezane Lyra  
**Linguagem:** C#  
**Padrões Aplicados:** Decorator e Observer

---

## 1. Objetivo do Projeto

O objetivo deste projeto é desenvolver um sistema de gerenciamento de pedidos para uma lanchonete, permitindo a personalização de hambúrgueres e a adição de acompanhamentos como bebidas e sobremesas. O sistema aplica os padrões de projeto **Decorator** e **Observer**, garantindo flexibilidade na adição de ingredientes e notificações automáticas para a equipe de produção e montagem.

### Requisitos Específicos:
1. **Personalização de Hambúrgueres:**  
   Permitir que o cliente escolha um hambúrguer base e adicione ingredientes extras, como bacon, picles, ovo, etc. A personalização é feita através do padrão **Decorator**.

2. **Notificações Automáticas:**  
   Utilizando o padrão **Observer**, a equipe de produção e montagem deve ser notificada automaticamente sempre que um novo pedido for criado ou modificado.

3. **Acompanhamentos:**  
   O sistema deve possibilitar a adição de acompanhamentos ao pedido, como bebidas, batata frita, nuggets e sobremesas.

---

## 2. Estrutura do Código

O código foi estruturado para seguir as boas práticas de Orientação a Objetos, com uma clara separação de responsabilidades e aderência aos padrões de projeto.

### 2.1. Padrão Decorator

O padrão **Decorator** foi utilizado para permitir a adição de ingredientes ao hambúrguer de forma dinâmica, sem alterar a estrutura do hambúrguer base. Assim, cada ingrediente adicional é tratado como um "decorador" que modifica o comportamento do hambúrguer, adicionando uma descrição e um custo extra.

### 2.2. Padrão Observer

O padrão **Observer** foi implementado para gerenciar as notificações automáticas aos monitores da equipe de produção e montagem. Sempre que um pedido é criado ou modificado, os monitores são informados sobre os ingredientes e o estado do pedido (por exemplo, "em produção" ou "pronto para entrega").

- **Sujeito:** A classe `Pedido` que mantém o estado do pedido e notifica os observadores.
- **Observadores:** As classes `MonitorProducao` e `MonitorMontagem`, que são notificadas sobre mudanças no pedido.

### 2.3. Acompanhamentos

Para incluir outros itens no pedido, como bebidas e sobremesas, foi criada uma estrutura modular que permite adicionar acompanhamentos ao pedido de forma simples. Os acompanhamentos são tratados separadamente dos hambúrgueres, mas são incluídos na descrição final e no cálculo do preço total.

---

## 3. Funcionamento do Sistema

### 3.1. Fluxo do Pedido:
1. O cliente escolhe um hambúrguer base.
2. Ingredientes adicionais são incorporados ao hambúrguer por meio do padrão **Decorator**.
3. Acompanhamentos são adicionados ao pedido (bebidas, batata frita, etc.).
4. Ao finalizar o pedido, os **Observers** (monitores de produção e montagem) são notificados automaticamente.
5. O sistema exibe a descrição completa do pedido e o preço total.

### 3.2. Exemplo de Execução Final:
Um cliente pode fazer o seguinte pedido:
- Hambúrguer simples com bacon e ovo.
- Acompanhamento de refrigerante e batata frita.

Assim que o pedido é finalizado, a equipe de produção é informada sobre os ingredientes do hambúrguer a ser preparado, e a equipe de montagem é informada sobre os itens que precisam ser organizados para entrega.

---

## 4. Conclusão

O sistema desenvolvido atendeu a todos os requisitos propostos. O padrão **Decorator** foi aplicado corretamente para permitir a personalização dinâmica dos hambúrgueres, enquanto o padrão **Observer** garantiu que a equipe da lanchonete fosse notificada automaticamente sobre novos pedidos. A inclusão de acompanhamentos foi feita de forma modular, garantindo flexibilidade ao sistema de pedidos.

A solução demonstrou ser eficiente e flexível, proporcionando um exemplo prático da aplicação de padrões de projeto no desenvolvimento de sistemas orientados a objetos. O projeto pode ser facilmente expandido, adicionando novos tipos de hambúrgueres, ingredientes ou notificações, sem necessidade de grandes modificações na estrutura atual.

---

## Melhorias Futuras

- **Aprimoramento da Interface Gráfica:** Poderia ser implementada uma interface gráfica (GUI) para melhorar a experiência do usuário.
- **Persistência de Dados:** Incluir uma camada de persistência (banco de dados) para armazenar os pedidos realizados.
- **Sistema de Relatórios:** Gerar relatórios sobre os pedidos realizados, ingredientes mais solicitados e acompanhamentos mais vendidos.

---

