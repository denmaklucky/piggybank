﻿using piggy_bank_uwp.ViewModel;
using piggy_bank_uwp.ViewModels.Interface;
using System.Collections.Generic;
using System.Linq;

namespace piggy_bank_uwp.ViewModels.Diagram
{
    public class DiagramViewModel : BaseViewModel, IBaseViewModel
    {
        public DiagramViewModel()
        {
            Datas = new List<DataDiagramViewModel>();
        }

        public void Initialization()
        {
            AllCosts = MainViewModel.Current.Costs.Sum(c => c.Cost);

            foreach (var category in MainViewModel.Current.Categories)
            {
                var costs = MainViewModel.Current.Costs.Where(c => c.CategoryId == category.Id);

                if(costs.Count() > 0)
                {
                    double sumInCategory = costs.Sum(c => c.Cost);
                    Datas.Add(new DataDiagramViewModel
                    {
                        Value = (sumInCategory / AllCosts)*100,
                        Color = category.Color,
                        Title = category.Title
                    });
                }
            }
        }

        public void Finalization()
        {

        }

        public List<DataDiagramViewModel> Datas { get; }

        public double AllCosts { get; private set; }
    }
}
