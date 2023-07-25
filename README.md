<span>
  <h1>
    <img src="https://github.com/dotMota/ContaComigo/blob/main/etc/Logo/Logo.png" alt="Logo" style="width: 45px; height: 45px; margin-right: 10px;">
    ContaComigo!
  </h1>
</span>

**Divida despesas justamente entre amigos. Prático, colaborativo e sem complicações.**

## Descrição

A API ContaComigo é uma aplicação desenvolvida para facilitar a divisão de despesas entre membros de um grupo, permitindo uma partilha justa e personalizada. Com esta API, os usuários podem compartilhar despesas de forma colaborativa, escolhendo quanto desejam contribuir em cada conta e configurando despesas recorrentes, como aluguel ou mensalidades.

## Funcionalidades

### Etapa 1: Gerenciamento de Usuários

- Crie um novo usuário com informações como nome, e-mail e senha.
- Permita que o usuário faça login utilizando seu e-mail e senha.
- Recupere informações do perfil do usuário, como nome, e-mail e histórico de despesas.

### Etapa 2: Grupos e Despesas

- Crie um novo grupo para gerenciar as despesas compartilhadas.
- Adicione membros ao grupo, que podem ser usuários registrados na API.
- Registre uma nova despesa no grupo com informações como descrição, valor total e data de vencimento.
- Permita que cada usuário defina sua parte na despesa ou opte por pagar integralmente.
- Configure despesas recorrentes, com opções de frequência (mensal, semanal, etc.) e data de início.

### Etapa 3: Cálculos de Divisão de Contas

- Implemente a lógica para calcular a divisão justa das despesas entre os membros do grupo.
- Permita que cada usuário visualize sua parcela em cada despesa com base nas configurações feitas.

### Etapa 4: Liquidação de Despesas

- Permita que os usuários registrem o pagamento de sua parcela nas despesas.
- Mantenha um registro de quais despesas foram pagas por cada usuário.
- Informe o saldo atual de cada usuário em relação ao grupo (quanto ele deve ou quanto tem a receber).

## Documentação e Publicação

Ao concluir o desenvolvimento, será criada uma documentação detalhada da API, explicando como utilizá-la. A API será disponibilizada em um servidor web seguro para os usuários.