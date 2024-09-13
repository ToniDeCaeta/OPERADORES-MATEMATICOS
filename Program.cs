using Calculate; //Usando o namespace, para conectar com nossa Classe localizada na pasta Models.

Calculadora calc = new Calculadora();

//necessário instanciar uma classe, para poder usá-la.

calc.Somar(2, 10);
calc.Subtracao(20, 36);
calc.Multiplicacao(9, 91);
calc.Divisao(3, 3);
calc.Potencia(3, 3);

calc.Seno(30);
calc.Coseno(20);
calc.Tangente(37);

calc.RaizQuadrada(9);

//Acima, testando cada uma das funções de nossa calculadora.

/* O objetivo foi apenas treinar matemárica base e algumas das funções Math. , devido a esse intuito
a calculadora, tem uma lógica de funcionamento pouco elaborada */