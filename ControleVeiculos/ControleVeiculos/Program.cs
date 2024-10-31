using ControleVeiculos;
using System.Globalization;

Console.WriteLine(" --  SISTEMA DE VEÍCULOS  -- ");

int opcao = 0;

VeiculoDAO vdao = new VeiculoDAO();

do
{
    Console.Write(@"ESCOLHA UMA DAS OPÇÕES:
        1 - Cadastrar
        2 - Listar 
        3 - Excluir
        4 - Buscar
        5 - Sair
..............: ");
    opcao = int.Parse(Console.ReadLine());
    Console.WriteLine();

    if (opcao == 1)
    {
        Console.WriteLine("CADASTRO DE VEÍCULOS");
        Console.WriteLine();

        Console.Write("Informe a placa: ");
        string placa = Console.ReadLine(); 

        Console.Write("Informe o modelo: ");
        string modelo = Console.ReadLine();

        Veiculo v = new Veiculo(placa, modelo); //Proibindo o usuário de criar o objeto sem a placa e o modelo, pois na classe Veiculo, foi criado o método construtor onde há essa obrigatoriedade.

        Console.Write("Informe a marca: ");
        v.marca = Console.ReadLine();

        Console.Write("Informe o renavam: ");
        v.renavam = Console.ReadLine();

        Console.Write("Informe o N° do motor: ");
        v.numMotor = Console.ReadLine();

        Console.Write("Informe o NIV: ");
        v.niv = Console.ReadLine();

        Console.WriteLine();
        vdao.Cadastrar(v);      
    }

    else if (opcao == 2)
    {
        Console.WriteLine("LISTA DE VEÍCULOS");
        Console.WriteLine("");
        List<Veiculo> veiculos = vdao.ListarTodos();
        foreach (Veiculo v in veiculos)
        {
            Console.WriteLine($"Modelo: {v.modelo} Placa: {v.placa}");
            Console.WriteLine( );
        }
    }

    else if (opcao == 3)
    {
        Console.WriteLine("REMOVER VEÍCULO");
        Console.WriteLine("");
        Console.Write("Informe a placa: ");
        string placa = Console.ReadLine();
        vdao.Remover(placa);
    }

    else if (opcao == 4)
    {
        Console.WriteLine("BUSCAR VEÍCULO");
        Console.WriteLine("");
        Console.Write("Informe a placa: ");
        string placa = Console.ReadLine();
        Veiculo v1 = vdao.BuscarPlaca(placa);
        Console.WriteLine($"Modelo: {v1.modelo} Placa: {v1.placa}");
        Console.WriteLine($"Marca: {v1.marca} NIV: {v1.niv}");
        Console.WriteLine($"Renavam: {v1.renavam} N° Motor: {v1.numMotor}");
    }

    else
    {
        break;
    }

}
while (opcao != 5);