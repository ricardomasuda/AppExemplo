using AppTurmas.Model;
using AppTurmas.View.PopupPage;
using Rg.Plugins.Popup.Extensions;
using Syncfusion.SfCalendar.XForms;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace AppTurmas.ViewModel
{
    class CalendarioViewModel
    {
        public CalendarEventCollection CalendarInlineEvents { get; set; } = new CalendarEventCollection();
        public CalendarioViewModel()
        {
            CalendarInlineEvent event1 = new CalendarInlineEvent()
            {
                StartTime = DateTime.Today.AddHours(9),
                EndTime = DateTime.Today.AddHours(10),
                Subject = "Culto Ecumenico",
                Color = Color.Green
                
            };
           
            CalendarInlineEvent event2 = new CalendarInlineEvent()
            {
                StartTime = DateTime.Today.AddHours(11),
                EndTime = DateTime.Today.AddHours(12),
                Subject = "Reunião com a Turma",
                Color = Color.Fuchsia
            };

            CalendarInlineEvent event3 = new CalendarInlineEvent()
            {
                StartTime = DateTime.Today.AddHours(05),
                EndTime = DateTime.Today.AddHours(08),
                Subject = "Formatura",
                Color = Color.Aqua
            };

            // Add events into a CalendarInlineEvents collection
          
            CalendarInlineEvents.Add(event1);
            CalendarInlineEvents.Add(event2);
            CalendarInlineEvents.Add(event3);
            CarregarAgenda();
        }
         public async void  CarregarAgenda()
        {
            var _request = new BuscarAgendaRequest();
            //var _response = await HttpsRequests<BuscarAgendaRequest, SimpleResponse>.PostAsync(_request);

           
        }
    }
   
}
