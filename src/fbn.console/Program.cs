using Google.FlatBuffers;
using fbn.Data;

// Criando uma instância de Person
var nome = "João";
DateTime dataNascimento = new DateTime(1990, 5, 15); // Exemplo de data de nascimento

// Serializando os dados com FlatBuffers
var builder = new FlatBufferBuilder(1024);
var nomeOffset = builder.CreateString(nome);
long dataNascimentoTicks = dataNascimento.ToUniversalTime().Ticks;
Offset<fbn.Data.Person> pessoaOffset = Person.CreatePerson(builder, nomeOffset, dataNascimentoTicks);
builder.Finish(pessoaOffset.Value);

byte[] buffer = builder.SizedByteArray();
File.WriteAllBytes("pessoa.bin", buffer);

// Lendo o arquivo e deserializando
byte[] data = File.ReadAllBytes("pessoa.bin");
var personLida = Person.GetRootAsPerson(new ByteBuffer(data));

// Criando a instância de Calc para calcular a idade
var calc = new Calc(personLida);
int age = calc.CalcAge(dataNascimento);

Console.WriteLine($"Nome: {personLida.Name}");
Console.WriteLine($"Idade: {age} anos");