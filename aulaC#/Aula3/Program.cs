using System.Runtime.InteropServices;
using aula2.models;

//cabeçalho
Pedido pedido = new Pedido();

pedido.Id = 12345;

pedido.Data = DateTime.Parse("22/08/2025");

//cliente
pedido.Cliente.Id = 198064;
pedido.Cliente.Nome = "Eduardo";
pedido.Cliente.CNPJ = "198.064.037-89";


//itens do pedido
PedidoItem item = new PedidoItem();

item.Id = 1;
item.Quantidade = 10;
item.Preco = 10.45;

pedido.PedidoItens.Add(item);

pedido.Print();




