# Conta Comigo APP - Estrutura de Pastas do Backend

Este repositório contém o código-fonte para o backend do projeto Conta Comigo APP, uma aplicação que auxilia na divisão de despesas e cálculos de pagamentos em grupos.

## Estrutura de Pastas

O projeto possui a seguinte estrutura de pastas:

### 1. `Controllers`

Nesta pasta, estão localizados os controladores responsáveis por receber as requisições HTTP da API e direcionar o fluxo para os serviços apropriados. Aqui, você implementará os endpoints da API, que podem ser testados usando o Swagger ou outras ferramentas de teste de API.

### 2. `Data`

A pasta `Data` contém os repositórios ou classes responsáveis por acessar os dados necessários para a aplicação. Se a aplicação estiver utilizando um banco de dados em memória para fins de testes com o Swagger, essa pasta pode não ser necessária. Caso contrário, você implementará aqui a lógica para interagir com o banco de dados, como consultas e atualizações.

### 3. `Infrastructure`

A pasta `Infrastructure` abriga as implementações específicas de infraestrutura, como conexões com bancos de dados ou serviços externos. Essa pasta também pode ser dispensável se estiver usando um banco de dados em memória para fins de testes com o Swagger. Aqui, você trata de aspectos de infraestrutura da aplicação.

### 4. `Interfaces`

A pasta `Interfaces` contém as interfaces que definem os contratos para os serviços e repositórios utilizados pela aplicação. Essas interfaces podem ser implementadas nas pastas `Services` e `Data`, respectivamente.

### 5. `Models`

Nesta pasta, encontram-se as classes que representam os modelos de dados utilizados pela API. Aqui, você definirá os modelos para as despesas, usuários, grupos e outros elementos relevantes para o funcionamento da aplicação. Os modelos ajudam a estruturar os dados que serão manipulados e processados pela API.

### 6. `Services`

A pasta `Services` contém os serviços de aplicação, que orquestram toda a lógica de negócio da aplicação. É aqui que você implementará as regras de negócio relacionadas à divisão de despesas, cálculos de pagamentos e outras operações importantes para o funcionamento da aplicação.

### 7. `Utilities`

A pasta `Utilities` abriga utilitários e classes auxiliares que podem ser utilizados em várias partes da aplicação. Aqui, você pode colocar funções e métodos de uso geral.

## Fluxo das Requisições HTTP

As requisições HTTP são direcionadas da seguinte forma através das pastas:

<table>
        <tr>
            <td>↓ Requisições HTTP</td>
        </tr>
	<tr>
		<td>ContaComigo/src/Controllers --&gt;</td>
		<td>ContaComigo/src/Services</td>
	</tr>
	<tr>
		<td rowspan="5"></td>
	</tr>
	<tr>
	</tr>
        <tr>
            <td>↑ ↓ ContaComigo/src/Models</td>
        </tr>
        <tr>
            <td>↑ ↓ ContaComigo/src/Data</td>
        </tr>
        <tr>
            <td>↑ ↓ ContaComigo/src/Infrastructure</td>
        </tr>
</table>


- As requisições HTTP são recebidas pelos controladores em `ContaComigoAPP/src/Controllers`, que direcionam o fluxo para os serviços apropriados em `ContaComigoAPP/src/Services`.

- Os serviços de aplicação podem interagir com as classes de modelos em `ContaComigoAPP/src/Models` para representar os dados manipulados pela API.

- Caso seja necessário acessar dados, os serviços de aplicação podem fazer uso dos repositórios ou classes em `ContaComigoAPP/src/Data`.

- Se houver implementações específicas de infraestrutura, como conexões com bancos de dados ou serviços externos, elas ficarão em `ContaComigoAPP/src/Infrastructure`.

Lembre-se de seguir as melhores práticas de desenvolvimento e organização de código ao trabalhar com essa estrutura de pastas para o backend do projeto Conta Comigo APP. O UML apresentado anteriormente representa visualmente essa estrutura e a interação entre as pastas e componentes do sistema.
