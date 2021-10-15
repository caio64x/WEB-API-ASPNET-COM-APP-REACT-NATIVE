	Comunicação da API com o APP

Durante o desenvolvimento houve problemas na comunicação em rede local.
As causas foram os problemas com portas de comunicação, o próprio firewall do Windows bloqueando a comunicação e até o próprio Windows não interpretando o IPv4 e também IPv6.
A solução foi o uso de uma ferramenta disponível no visual studio, o Conveyor by Keyoti

Para instalação, feche o visual studio e acesse o link 
< https://marketplace.visualstudio.com/items?itemName=vs-publisher-1448185.ConveyorbyKeyoti>, clique em Download, abra o executável e prossiga com a instalação

![image](https://user-images.githubusercontent.com/53580975/137529606-4914ed37-9050-4962-92fb-8f2b141a9919.png)



Acesse este link para efetuar o registro na plataforma, assim poderá utilizar em rede local ou em rede externa:
< https://conveyor.cloud/Account/Register>

![image](https://user-images.githubusercontent.com/53580975/137529658-114c11b2-02f3-4d3b-92e8-3c62016d47c8.png)


Para utilizar, basta iniciar o projeto e a extensão já está ativa.
Para este projeto a função “Access  Over Internet” será usada, pois ela é a que realiza a comunicação externa.
Clique nela e aguarde gerar o link.

![image](https://user-images.githubusercontent.com/53580975/137529698-742160e8-3bc3-45ea-a9e9-1fd3e6afcdbb.png)

