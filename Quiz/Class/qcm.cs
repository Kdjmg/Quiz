
class Qcm{
    
    public static void Game(){
        Console.WriteLine("------------------------------------------------------------------------");
        Console.WriteLine("Bienvenue aux QCMQUIZ!");
        Console.WriteLine("------------------------------------------------------------------------");

Console.WriteLine("Bonjour !");
Console.WriteLine("Choisissez votre catégorie :");
Console.WriteLine("1. Une catégorie");
Console.WriteLine("2. Une seconde catégorie");
Console.Write("Votre choix : ");
int choixCategorie = Convert.ToInt32(Console.ReadLine());

switch (choixCategorie)
{
    case 1:
        Console.WriteLine("Vous avez choisi la première catégorie");
        break;
    case 2:
        Console.WriteLine("Vous avez choisi la deuxième catégorie");
        break;
    default:
        Console.WriteLine("Choix invalide !");
        break;
}
    //question 1 : 
    Console.WriteLine("\nQui est Margaret Hamilton?");
Console.WriteLine("1. une championne de ping pong");
Console.WriteLine("2. une pilote de F1");
Console.WriteLine("3. une informaticienne de légende");
Console.Write("Votre choix : ");
int choixAnswer1 = Convert.ToInt32(Console.ReadLine());

if(choixAnswer1==3){
Console.WriteLine("Bravo bonne réponse");
}else{
Console.WriteLine("Mauvaise réponse");

}

//Question 2: 
Console.WriteLine("\nQui peut accéder à un attribut protected d'une classe en C# ? ?");
Console.WriteLine("1. ses classes dérivées");
Console.WriteLine("2. sa mère");
Console.WriteLine("3. son père");
Console.WriteLine("3. toutes les classes du même domaine");
Console.Write("Votre choix : ");
int choixAnswer2 = Convert.ToInt32(Console.ReadLine());

if(choixAnswer2==1){
Console.WriteLine("Bravo bonne réponse");
}else{
Console.WriteLine("Mauvaise réponse");

}

//question 3: 
Console.WriteLine("\nQue permet le raccourci F9 sous Visual Studio Code ?");
Console.WriteLine("1. Mettre un signet");
Console.WriteLine("2. Mettre un point d'arrêt");
Console.WriteLine("3. aviguer vers la définition");
Console.Write("Votre choix : ");
int choixAnswer3 = Convert.ToInt32(Console.ReadLine());

if(choixAnswer3==2){
Console.WriteLine("Bravo bonne réponse");
}else{
Console.WriteLine("Mauvaise réponse");

}

    }




}