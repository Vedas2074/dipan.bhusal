using System;
public class Country
{
   public string Name {get;set;}

    public string Capital {get; set;}
   public long Population { get; set;}

    public string Continent { get; set;}

    public DateTime IndependanceDay {get; set;}


    public Country(string n, string c, string co, long pop, DateTime i = default){
        Name = n;
        Capital = c;
        Continent = co;
        Population = pop;
        IndependanceDay = i;
    }

}