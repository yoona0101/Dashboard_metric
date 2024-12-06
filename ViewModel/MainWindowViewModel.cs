using Dashboard_metric.Command;
using Dashboard_metric.Controller;
using Dashboard_metric.Model;
using System.Windows.Input;
using static MudBlazor.CategoryTypes;

namespace Dashboard_metric.ViewModel
{
    public class MainWindowViewModel
    {
        private readonly MainWindowController _controller;
        public ICommand Get { get; private set; }
        public MainWindowViewModel()
        {
            _controller = new MainWindowController();

            Get = new DelegateCommand(GetData);
            TestMetric();
        }

        private async void TestMetric()
        {
            try
            {

                var interval = new IntervalData()
                {
                    StartDate = "30.10.2024",
                    EndDate = "30.11.2024"

                };

                var result = await _controller.GetMetrics(interval);
            }
            catch (Exception ex)
            {
               // MessageBox(ex.Message);
            }
        }
        private async void GetData(object obj)
        {
            /*try
            {
                if (string.IsNullOrEmpty(IntervalData.EndDate) || string.IsNullOrEmpty(SelectedGroup))
                {
                    //MessageBox.Behavior = "Все поля должны быть заполнены";

                    return;
                }

                var result = await _controller.GetSchedule(SelectedGroup, SelectedFaculty);

                //result?.ForEach(.Add);
            }
            catch
            {
                //MessageBox("При попытке получить данные произошла ошибка");
            }*/
        }
    }

}

