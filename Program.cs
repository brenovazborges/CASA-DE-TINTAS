//é 1:50 da manhã e esse código já fez minha calvície avançar mais 3cm, aproveitem :D

double litrosLata = 18, litrosGalao = 3.6, margem = 1.1;
double litrosNecessarios;
int area, rendimento = 3;

Console.WriteLine("==ATIVIDADE CASA DE TINTAS=");
Console.Write("\nÁrea a ser pintada (m²)...:") ;
area = Convert.ToInt32(Console.ReadLine());
litrosNecessarios = (area / rendimento) * margem;

Console.WriteLine($"\nTotal de {litrosNecessarios:F1} litros de tinta necessarios.\n");

int latasNessesarias = (int) (litrosNecessarios / litrosLata);
double restoLata = (litrosNecessarios % litrosLata);
int galoesNecessarios = (int)Math.Ceiling(restoLata / litrosGalao);

    
if (restoLata > 0 && galoesNecessarios * litrosGalao < restoLata)
{
    latasNessesarias++;
    galoesNecessarios = 0;
}

Console.WriteLine("Distribuição:");
Console.WriteLine($"Latas...: {latasNessesarias} unidade(s)");
Console.WriteLine($"Galões..: {galoesNecessarios} unidade(s)");

