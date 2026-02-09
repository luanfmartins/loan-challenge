<h1>💰 Desafio de Empréstimos</h1>
Este projeto resolve o desafio de determinar quais modalidades de empréstimo uma pessoa pode acessar, com base em regras de negócio definidas, utilizando ASP.NET Core Web API.

<h2>📌 Modalidades analisadas</h2>

Empréstimo Pessoal – Juros de 4%

Empréstimo Consignado – Juros de 2%

Empréstimo com Garantia – (se aplicável conforme as regras)

<h2>🏗️ Estrutura do Projeto</h2>
Controllers/  → Endpoints da API <br>
Enums/        → Tipos e constantes do domínio <br>
Models/       → Modelos de dados <br>
Services/     → Regras de negócio dos empréstimos <br>
Properties/   → Configurações do projeto <br>

<h2>⚙️ Funcionamento</h2>

A API recebe os dados do cliente, processa as regras no Service, e retorna as modalidades de empréstimo disponíveis com suas respectivas taxas de juros.

<h2>🚀 Tecnologias</h2>

.NET / ASP.NET Core

C#

Injeção de Dependência

Arquitetura em camadas
