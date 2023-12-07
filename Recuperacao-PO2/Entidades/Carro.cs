public class Carro
{
    public int Id { get; set; }
    public string Marca { get; set; }
    public string Modelo { get; set; }
    public int AnoDeFabricacao { get; set; }
    public int AnoDoModelo { get; set; }
    public string TipoDeCarroceria { get; set; }
    public int NumeroDePortas { get; set; }
    public string Cor { get; set; }
    public string NumeroDoChassi { get; set; }
    public string NumeroDoMotor { get; set; }
    public string TipoDeCombustivel { get; set; }
    public double CapacidadeDoTanque { get; set; }
    public double PotenciaDoMotor { get; set; }
    public string TipoDeTransmissao { get; set; }
    public string TipoDeTracao { get; set; }
    public string Renavam { get; set; }
    public string NumeroDaPlaca { get; set; }
    public DateTime DataDeLicenciamento { get; set; }
    public DateTime DataDaUltimaInspecaoVeicular { get; set; }
    public Carro(int id, string marca, string modelo, int anoDeFabricacao, int anoDoModelo, string tipoDeCarroceria, int numeroPortas, string cor, string numeroDoChassi, string numeroDoMotor, string tipoDeCombustivel, double capacidadeDoTanque, double potenciaDoMotor, string tipoDeTransmissao, string tipoDeTracao, string renavam, string numeroDaPlaca, DateTime dataDeLicenciamento, DateTime dataDaUltimaInspecaoVeicular)
    {
        Id = id;
        Marca = marca;
        Modelo = modelo;
        AnoDeFabricacao = anoDeFabricacao;
        AnoDoModelo = anoDoModelo;
        TipoDeCarroceria = tipoDeCarroceria;
        NumeroDePortas = numeroPortas;
        Cor = cor;
        NumeroDoChassi = numeroDoChassi;
        NumeroDoMotor = numeroDoMotor;
        TipoDeCombustivel = tipoDeCombustivel;
        CapacidadeDoTanque = capacidadeDoTanque;
        PotenciaDoMotor = potenciaDoMotor;
        TipoDeTransmissao = tipoDeTransmissao;
        TipoDeTracao = tipoDeTracao;
        Renavam = renavam;
        NumeroDaPlaca = numeroDaPlaca;
        DataDeLicenciamento = dataDeLicenciamento;
        DataDaUltimaInspecaoVeicular = dataDaUltimaInspecaoVeicular;
    }
    public Carro()
    {
    }
}