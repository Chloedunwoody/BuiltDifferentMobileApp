﻿using MvvmHelpers.Commands;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BuiltDifferentMobileApp.ViewModels
{
    public class AddMealViewModel:ViewModelBase
    {
       
       
        private string name;
        public string Name { get => name; set => SetProperty(ref name, value); }

        private double calories;
        public double Calories { get => calories; set => SetProperty(ref calories, value); }
        private double protein;
        public double Protein { get => protein; set => SetProperty(ref protein, value); }
        private double carbs;
        public double Carbs { get => carbs; set => SetProperty(ref carbs, value); }
        private double fat;
        public double Fat { get => fat; set => SetProperty(ref fat, value); }
        private string recipe;
        public string Recipe { get => recipe; set => SetProperty(ref recipe, value); }
        private string imageLink;
        public string ImageLink { get => imageLink; set => SetProperty(ref imageLink, value); }
        private string mealType;
        public string MealType { get => mealType; set => SetProperty(ref mealType, value); }
        private string date;
        public string Date { get => date; set => SetProperty(ref date, value); }
        public AsyncCommand SaveCommand { get; }
        

        public AddMealViewModel()
        {

            Title = "Add Meal";
            SaveCommand = new AsyncCommand(Save);
            
        }

        async Task Save()
        {

            
            await AppShell.Current.GoToAsync("..");

        }

        


    }
}
