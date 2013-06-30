﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using POEApi.Model;

namespace Procurement.ViewModel.Recipes
{
    class SameNameRecipe : Recipe
    {
        protected string name;
        protected int setCount;

        public SameNameRecipe(string recipeName, int setCount)
        {
            this.name = recipeName;
            this.setCount = setCount;
        }

        public override string Name
        {
            get { return name; }
        }

        public override IEnumerable<RecipeResult> Matches(IEnumerable<POEApi.Model.Item> items)
        {
            return findDuplicates(items, setCount);
        }

        private IEnumerable<RecipeResult> findDuplicates(IEnumerable<POEApi.Model.Item> items, int setCount)
        {
            var gear = items.OfType<Gear>().Where(g => g.Name != string.Empty);
            var itemKeys = gear.GroupBy(i => i.Name).Where(g => g.Count() > 1);

            List<RecipeResult> matches = new List<RecipeResult>();

            foreach (var item in itemKeys)
            {
                var matchedItems = gear.Where(g => g.Name == item.Key).Select(g => g as Item).ToList();

                if (matchedItems.Count() == setCount)
                    matches.Add(new RecipeResult()
                    {
                        Instance = this,
                        IsMatch = true,
                        MatchedItems = matchedItems,
                        Missing = new List<string>(),
                        PercentMatch = 100
                    });
            }

            return matches;
        }
    }
}
