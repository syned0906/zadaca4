using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;




namespace DekoraterExtraZadatak
{
    public interface IIngredient
    {
        void Add();
    }

    public class Noodles : IIngredient
    {
        IIngredient ingredient;

        public Noodles(IIngredient ingredient)
        {
            this.ingredient = ingredient;
        }

        public void Add()
        {
            ingredient.Add();
            Console.WriteLine("Add Noodles");
        }
    }

    public class Beef : IIngredient
    {
        IIngredient ingredient;

        public Beef(IIngredient ingredient)
        {
            this.ingredient = ingredient;
        }

        public void Add()
        {
            ingredient.Add();
            Console.WriteLine("Add Beef");
        }
    }

    public class Mushrooms : IIngredient
    {
        IIngredient ingredient;

        public Mushrooms(IIngredient ingredient)
        {
            this.ingredient = ingredient;
        }

        public void Add()
        {
            ingredient.Add();
            Console.WriteLine("Add Mushrooms");
        }
    }

    public class Water : IIngredient
    {
        public void Add()
        {
            Console.WriteLine("Add Water");
        }
    }

    public class Meal 
    {
        IIngredient ingredient;

        public void MakeMushroomNoodleSoup()
        {
           
            ingredient = new Noodles(new Mushrooms(new Water()));
            ingredient.Add();
        }

        
    }

    public static class ClientCode
    {
        public static void Run()
        {
           
            new Meal().MakeMushroomNoodleSoup();
        }
    }
}