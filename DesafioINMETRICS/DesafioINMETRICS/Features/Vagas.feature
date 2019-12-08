Feature: Acesso a LP de Vagas 
	A fim de Aplicar para uma vaga na INMETRICS
	Eu como um candidato
	Eu desejo acessar a pagina com as vagas abertas.

@mytag
Scenario: Acessar pagina de vagas
	Given Eu acessei a url base 
	And Localizei o botão “confira nossas vagas”. 
	When eu clico no botão “confira nossas vagas”.
	Then A pagina com as vagas em aberto é devidaemnte exibida
