using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tutorial.Client.Pages
{
    //[Route("/counter")]
    public partial class Counter
    {

        int currentCount = 0;
        void IncrementCount()
        {
            currentCount++;
            Console.WriteLine("Writing to javascript console using C#");
        }

        void DecrementCount()
        {
            currentCount = currentCount - 2;
            Console.WriteLine($"Counter {currentCount}");
        }

        [Inject]
        protected NavigationManager LocalNavigationManagerByCodeBehind { get; set; }

        void NavigationByCodeBehind()
        {
            LocalNavigationManagerByCodeBehind.NavigateTo("/component");
        }

        
    }
}
