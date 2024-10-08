using System;

IHamburguer hamburguer1 = new HamburguerSimples();
hambuguer1 = new Bacon(hamburguer1);
hambuguer1 = new Salada(hamburguer1);

Pedido pedido1 = new Pedido(hamburguer1);
pedido1.AdicionarAcompanhamento(new Refrigerante());
pedido1.AdicionarAcompanhamento(new BatataFrita());

MonitorProducao monitorProducao = new MonitorProducao();
MonitorMontagem monitorMontagem = new MonitorMontagem();
pedido1.AdicionarObservador(monitorProducao);
pedido1.AdicionarObservador(monitorMontagem);

pedido1.FinalizarPedido();


IHamburguer hamburguer2 = new XTudo();

Pedido pedido2 = new Pedido(hamburguer2);
pedido2.AdicionarAcompanhamento(new Suco());
pedido2.AdicionarAcompanhamento(new Nugget());
pedido2.AdicionarAcompanhamento(new Casquinha());

pedido2.AdicionarObservador(monitorProducao);
pedido2.AdicionarObservador(monitorMontagem);

pedido2.FinalizarPedido();