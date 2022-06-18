using Microsoft.AspNetCore.Components;

namespace BlazorServer.BaseComponents
{
    public class DateTimeBaseComponent : ComponentBase
    {
        public DateTime dateTime { get; set; }

        protected override void OnInitialized()
        {
            base.OnInitialized();

            dateTime = DateTime.Now;
        }
    }
}
