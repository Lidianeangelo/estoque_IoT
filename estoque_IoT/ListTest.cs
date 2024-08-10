using System;
using System.Collections;


internal class HashTableTest
{
    internal static void TestHashTable()
    {
        string[] arrAndar0 = new string[] { "Alface", "Tomate", "Cebola", "Cenoura", "Morango", "Banana"};
        string[] arAndar1 = new string[] { "Leite", "Queijo", "Iogurte", "Manteiga", "Sorvete" };
        string[] arrAndar2 = new string[] { "Milho", "Ervilha", "Atum", "Creme de Leite", "Extrato de Tomate" };
        string[] arrAndar3 = new string[] { "Carne Moída", "Costela", "Picanha", "Maminha", "Luxúria", "Preguiça", "Soberba" };

        Hashtable hashTest = new Hashtable();

        hashTest.Add("T - Hortifrutis", arrAndar0);
        hashTest.Add("1º Andar - Laticínios", arAndar1);
        hashTest.Add("2º Andar - Enlatados", arrAndar2);
        hashTest.Add("3º Andar - Açougue", arrAndar3);


        // iterando usando a instrução foreach
        // O iterador gera um objeto DictionaryEntry contendo o par key/value
        foreach (DictionaryEntry element in hashTest)
        {
            //obtém os valores da HashTable usando Key e Value
            string andar = (string)element.Key;
            string[] lista = (string[])element.Value;

            Console.WriteLine(String.Format("Andar:{0} ", andar));

            foreach (var item in lista)
                Console.WriteLine($"Lista: {item}");

            //exibe os valores da HashTable
            Console.WriteLine("--------------------------");
        }
    }
}



