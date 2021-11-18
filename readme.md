# COLAB FOOD

## **O PROJETO**
Aplicação de comunicação entre um produtor ou estabelecimento comercial e uma ONG ou alguma instituição beneficente. Esse fornecedor anuncia que poderá doar certa quantidade de alimento e disponibiliza para essas instituições.

Um fornecedor cria um anúncio que notifica as intituições. A instituição tem a possibilidade de pegar os alimentos integralmente ou parcialmente. Quando uma instituição aceita a doação, o fornecdor recebe o nome da instituição e quais alimentos essa instituição vai pegar.

&nbsp;

## **A APLICAÇÃO**
A aplicação contará com uma tela de login onde o usuário, fornecedor ou instituição, poderá se autenticar para utilizar a plataforma. Com isso será possível reconhecer seus dados para futuras interações no sistema. Assim que o usuário realizar o login, a aplicação o redirecionará-lo para tela inicial, onde é possível encontrar todos os anúncios disponíveis no momento contando com informações resumidas de cada anúncio. Ao clicar no botão 'Detalhes' de um determinado anúncio, o sistema irá carregar uma página com as informações completas do anúncio, incluindo a localização do fornecedor, e será possível clicar no botão 'Retirar' a doação, integralmente ou parcialmente.

Com isso, teremos uma tela onde será registrado todas os anúncios que a instituição aceitou e realizou a retirada das doações, em forma de histórico que apresentará qual foi o anúncio, o fornecedor e a própria instituição.

Na tela de Perfil será possível conferir os dados cadastrados, sendo possível também editar os dados caso seja necessário.
&nbsp;
#### **O LAYOUT**
![Layout base da aplicação Colab Food](/web_lay-out_gs.png)

&nbsp;

## **A IMPLEMENTAÇÃO**
- ### **HOME**
  É exibida uma lista de todos os anúncios cadastrados no sistema. Para cada anúncio há um botão que irá levar o usuário para a página de detalhes do respectivo anúncio. Nesta página é exibido o anúncio com todas as informações completas:
  * Título do anúncio
  * Nome do Fornecedor (selecionado na tela de cadastro do anúncio)
  * Descrição do anúncio
  * Endereço do Fornecedor (carregado por conta do relacionamento entre entidades)
  * Quantidade ofertada

  &nbsp;
  Junto do anúncio terá um campo seletor para escolher a instituição que está fazendo a retirada e o botão de Retirar, que abrirá um modal para informar a quantidade que deseja retirar e confirmar. Caso o usuário informe uma quantidade menor que a disponível, o anúncio será atualizado para a nova quantidade restante. Se o usuário informar a quantidade total disponível, o anúncio será removido do sistema. Caso o usuário informe uma quantidade maior do que a disponível, o sistema informará que a quantidade não está disponível.

&nbsp;
- ### **NOVO ANÚNCIO**
  Nesta tela o fornecedor pode cadastrar um novo anúncio inserindo os dados necessários:
  * Título do anúncio
  * Fornecedor que está ofertando a doação (componente select carregado com todos os fornecedores cadastrado no sistema)
  * Descrição do anúncio
  * Quantidade ofertada
  
  &nbsp;
  Após preencher os dados e cadastrar o novo anúncio, será redirecionado para a tela inicial dos anúncios, Index, onde já será possível ver o novo anúncio na tela.

&nbsp;
- ### **PERFIL**
  Neste item, haverá 2 sub-menus - Cadastrar Fornecedor e Cadastrar ONG. Em ambos os casos será apresentada a respectiva tela de cadastro para inserir as informações necessárias a serem salvas no banco de dados:
  *  No. Documento
  *  Nome
  *  E-mail
  *  Telefone
  *  Endereço
  *  Cidade
  *  Estado (UF)
  *  País
  
  &nbsp;
  Após o cadastro, será exibida a tela onde é possível conferir os dados cadastrados.

&nbsp;

## **A UTILIZAÇÃO**
Para o desenvolvimento desta implementação foi utilizado o banco de dado MySql local, configurado no arquivo **`appsettings.json`** e criado a base de dados **`colabfood`**.

&nbsp;

## **FUTURA IMPLEMENTAÇÃO**
- [ ] Página de Doações: receberá o histórico de doações retiradas pelo usuário
- [ ] Login: tela com validação e autenticação
- [ ] Perfil: será exibido os dados do usuário usuário logado na plataforma, com a possibilidade de editá-los