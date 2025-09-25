**N2 SISTEMA DE CHAMADOS**



Ideia inicial: Criar um sistema de abertura e controle de chamados, isto é, um "helpdesk", um sistema em que seja possível criar um abrir chamados em um perfil e que serão respondidos e devolvidos por outro.

O que deverá conter no projeto:



•	Id do chamado (sugira o próximo id disponível ao inserir um novo chamado)

•	Data de abertura do chamado (obrigatório)

•	Descrição do problema (obrigatório)

•	Descrição do atendimento (obrigatório se situação for “Atendido”)

•	Data do atendimento (obrigatório se situação for “Atendido”)

•	Situação do chamado (Obrigatório. Valores válidos: “Pendente” e “Atendido”)

•	Código do usuário que está atendendo o chamado. (obrigatório caso o chamado esteja com situação “Atendido”)







**GUILHERME**



Função: BackEnd.




* Criar banco e sua estrutura
* Criar regras de negocio do helpdesk
* Controle de Login e Perfil





**RHYU**



Função: FrontEnd.


* Construir as telas de login, cadastro e resposta de chamados
* fazer com que tudo isso converse com o backend





